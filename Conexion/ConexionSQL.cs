using Npgsql;
using System;
using System.Collections.Generic;

namespace Datos
{
    public class ConexionSQL
    {
        public NpgsqlTransaction Transaccion { get; private set; }
        public NpgsqlConnection ConexionRetorno;
        public NpgsqlConnection Conexion;
        public NpgsqlCommand cmd;

        private static string usuarioApp = "Sistema";
        private static string tipoUsuarioApp = "Sistema";

        public static string UsuarioApp
        {
            get => usuarioApp;
            set => usuarioApp = value ?? "Sistema";
        }

        public static string TipoUsuarioApp
        {
            get => tipoUsuarioApp;
            set => tipoUsuarioApp = value ?? "Sistema";
        }

        public ConexionSQL(string user = null, string tipoUser = null)
        {
            if (user != null) UsuarioApp = user;
            if (tipoUser != null) TipoUsuarioApp = tipoUser;
        }

        public NpgsqlConnection ConexionBD()
        {

            string Servidor = "localhost";
            int Puerto = 5432;
            string Usuario = "postgres";
            string Clave = "password";
            string BaseDatos = "tienda2";

            string CadenaConexion = "Server=" + Servidor + ";" + "Port=" + Puerto + ";" +
                                    "User Id=" + Usuario + ";" + "Password=" + Clave + ";" +
                                    "Database=" + BaseDatos;

            Conexion = new NpgsqlConnection(CadenaConexion);
            Conexion.Open();

            // Iniciar la transaccion
            Transaccion = Conexion.BeginTransaction();

            using (NpgsqlCommand cmd1 = new NpgsqlCommand($"SET LOCAL app.usuario = '{UsuarioApp.Replace("'", "''")}'", Conexion, Transaccion))
            {
                _ = cmd1.ExecuteNonQuery();
                using (NpgsqlCommand check = new NpgsqlCommand("SELECT current_setting('app.usuario')", Conexion, Transaccion))
                {
                    object result = check.ExecuteScalar();
                    Console.WriteLine($"Usuario seteado en la sesión actual: {result}");
                }

            }

            using (NpgsqlCommand cmd2 = new NpgsqlCommand($"SET LOCAL app.tipo_usuario = '{TipoUsuarioApp.Replace("'", "''")}'", Conexion, Transaccion))
            {
                _ = cmd2.ExecuteNonQuery();
            }

            return Conexion;
        }

        public bool CambiarEstadoCRUD(int Id, bool Estado, string Schema, string Tabla)
        {
            Conexion = ConexionBD();

            cmd = new NpgsqlCommand(
                $"SELECT modificar_estado_tablas({Id}, {Estado}, '{Schema}', '{Tabla}', '{UsuarioApp}', '{TipoUsuarioApp}')",
                Conexion,
                Transaccion
            );

            try
            {
                cmd.ExecuteNonQuery();
                Transaccion.Commit();
                return true;
            }
            catch
            {
                Transaccion.Rollback();
                return false;
            }
            finally
            {
                Conexion.Close();
            }
        }

        public int BuscarSiguienteId(string Tabla)
        {
            int UltimoId = 0;

            using (ConexionRetorno = ConexionBD())
            {
                cmd = new NpgsqlCommand("SELECT COALESCE(MAX(id) + 1, 1) FROM " + Tabla, ConexionRetorno);
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        UltimoId = dr.GetInt32(0);
                    }
                }

                Transaccion.Commit();
                ConexionRetorno.Close();
            }

            return UltimoId;
        }


        public int BuscarIdEstado(string Tabla, string Nombre)
        {
            int Id = 0;

            ConexionRetorno = ConexionBD();

            cmd = new NpgsqlCommand("SELECT id FROM " + Tabla + " WHERE nombre_estado = '" + Nombre + "'", ConexionRetorno);

            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Id = dr.GetInt32(0);
            }

            ConexionRetorno.Close();

            return Id;
        }

        public string BuscarNombreEstado(string Tabla, int Id)
        {
            string Nombre = "";

            ConexionRetorno = ConexionBD();

            cmd = new NpgsqlCommand("SELECT nombre_estado FROM " + Tabla + " WHERE id = " + Id, ConexionRetorno);

            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Nombre = dr.GetString(0);
            }

            ConexionRetorno.Close();

            return Nombre;
        }

        public string BuscarNombreXIdBD(string Tabla, int Id)
        {
            string Nombre = "";

            using (ConexionRetorno = ConexionBD())
            {
                cmd = new NpgsqlCommand("SELECT nombre FROM " + Tabla + " WHERE id = " + Id, ConexionRetorno);

                NpgsqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Nombre = dr.GetString(0);
                }
            }

            return Nombre;
        }

        public int BuscarIdXNombreBD(string Tabla, string Nombre)
        {
            int Id = 0;
            using (ConexionRetorno = ConexionBD())
            {
                cmd = new NpgsqlCommand("SELECT id FROM " + Tabla + " WHERE nombre = '" + Nombre + "'", ConexionRetorno);
                NpgsqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Id = dr.GetInt32(0);
                }
            }
            return Id;
        }

        public bool ConfirmarDuplicidad(string tabla, string atributo, string valor, int idExclusion = -1)
        {
            using (ConexionRetorno = ConexionBD())
            {
                string query = "SELECT COUNT(*) FROM " + tabla + " WHERE " + atributo + " = '" + valor + "'";
                if (idExclusion != -1)
                {
                    // Una exclusion para evitar que se considere a si mismo como un duplicado al hacer un update
                    query += " AND id != " + idExclusion;
                }
                cmd = new NpgsqlCommand(query, ConexionRetorno);
                long count = Convert.ToInt64(cmd.ExecuteScalar() ?? 0);
                return count > 0; // True (Duplicados) - False (Sin Duplicidad)
            }
        }
        public Dictionary<string, byte[]> CargarImagenesBD()
        {
            using (ConexionRetorno = ConexionBD())
            {
                Dictionary<string, byte[]> Imagenes = new Dictionary<string, byte[]>();
                cmd = new NpgsqlCommand("SELECT nombre, imagen FROM imagenes", ConexionRetorno);
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Imagenes.Add(dr.GetString(0), (byte[])dr[1]);
                }
                return Imagenes;
            }
        }
    }
}