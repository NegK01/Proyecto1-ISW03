//Using Añadidos
using Npgsql;
using Objetos;
using System.Collections.Generic;

namespace Conexion
{
    public class BDRoles
    {
        public NpgsqlConnection ConexionRetorno;
        public NpgsqlCommand cmd;

        ConexionSQL conexion = new ConexionSQL();

        public bool InsertarRol(ObjRol NuevoRol)
        {
            ConexionRetorno = conexion.ConexionBD();

            cmd = new NpgsqlCommand("INSERT INTO rol (id, tipo_rol, id_estado) VALUES (" +
                                    NuevoRol.Id + " , '" +
                                    NuevoRol.Nombre + "'," +
                                    NuevoRol.Estado + ")", ConexionRetorno);

            int affectedRows = cmd.ExecuteNonQuery();

            ConexionRetorno.Close();

            return affectedRows > 0;
        }

        public bool ModificarRol(ObjRol NuevoRol)
        {
            ConexionRetorno = conexion.ConexionBD();

            cmd = new NpgsqlCommand("UPDATE rol SET " +
                                    "tipo_rol     =  '" + NuevoRol.Nombre + "'" +
                                    "WHERE id   =  " + NuevoRol.Id, ConexionRetorno);

            int affectedRows = cmd.ExecuteNonQuery();

            ConexionRetorno.Close();

            return affectedRows > 0;
        }

        public List<ObjRol> CargarRoles(string Condicion)
        {
            ConexionRetorno = conexion.ConexionBD();

            List<ObjRol> ListaRoles = new List<ObjRol>();

            cmd = new NpgsqlCommand("SELECT * FROM rol " + Condicion, ConexionRetorno);

            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ObjRol Rol = new ObjRol
                {
                    Id = dr.GetInt32(0),
                    Nombre = dr.GetString(1),
                    Estado = dr.GetInt32(2)
                };
                ListaRoles.Add(Rol);
            }

            ConexionRetorno.Close();

            return ListaRoles;
        }

        public int BuscarIdRol(string Nombre)
        {
            int IdRol = 0;

            ConexionRetorno = conexion.ConexionBD();

            cmd = new NpgsqlCommand("SELECT id FROM rol WHERE tipo_rol = '" + Nombre + "'", ConexionRetorno);

            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                IdRol = dr.GetInt32(0);
            }

            ConexionRetorno.Close();

            return IdRol;
        }

        public string BuscarNombreRol(int Id)
        {
            string NombreRol = "";

            ConexionRetorno = conexion.ConexionBD();

            cmd = new NpgsqlCommand("SELECT tipo_rol FROM rol WHERE id = " + Id, ConexionRetorno);

            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                NombreRol = dr.GetString(0);
            }

            ConexionRetorno.Close();

            return NombreRol;
        }
    }
}
