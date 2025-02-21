//Using Añadidos
using Npgsql;
using System;

namespace Conexion
{
    public class ConexionSQL
    {
        public NpgsqlConnection ConexionRetorno;
        public NpgsqlConnection Conexion;
        public NpgsqlCommand cmd;

        public NpgsqlConnection ConexionBD()
        {

            string Servidor = "localhost";
            int Puerto = 5432;
            string Usuario = "postgres";
            string Clave = "password";
            string BaseDatos = "tienda";

            string CadenaConexion = "Server=" + Servidor + ";" + "Port=" + Puerto + ";" +
                                    "User Id=" + Usuario + ";" + "Password=" + Clave + ";" +
                                    "Database=" + BaseDatos;

            Conexion = new NpgsqlConnection(CadenaConexion);
            Conexion.Open();

            return Conexion;
        }

        public int BuscarSiguienteId(string Tabla)
        {
            int UltimoId = 0;

            ConexionRetorno = ConexionBD();

            cmd = new NpgsqlCommand("SELECT MAX(id) + 1 FROM " + Tabla, ConexionRetorno);
            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                UltimoId = dr.GetInt32(0);
            }

            ConexionRetorno.Close();

            return UltimoId;
        }

        public bool CambiarEstadoCRUD(int Id, string Tabla)
        {
            ConexionRetorno = ConexionBD();

            cmd = new NpgsqlCommand("UPDATE " + Tabla + " SET id_estado = CASE WHEN id_estado = 1 " +
                                    "THEN 2 ELSE 1 END WHERE id = " + Id, ConexionRetorno);

            int affectedRows = cmd.ExecuteNonQuery();

            ConexionRetorno.Close();

            return affectedRows > 0;
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
    }
}
