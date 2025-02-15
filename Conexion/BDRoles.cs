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

            cmd = new NpgsqlCommand("INSERT INTO rol (id, tipo_rol) VALUES ('" +
                                    NuevoRol.Id + " , '" +
                                    NuevoRol.Nombre + "')", ConexionRetorno);

            int affectedRows = cmd.ExecuteNonQuery();

            ConexionRetorno.Close();

            return affectedRows > 0;
        }

        public bool ModificarRol(ObjRol NuevoRol)
        {
            ConexionRetorno = conexion.ConexionBD();

            cmd = new NpgsqlCommand("UPDATE rol SET " +
                                    "nombre     =  " + NuevoRol.Nombre + " , " +
                                    "WHERE id   =  " + NuevoRol.Id, ConexionRetorno);

            int affectedRows = cmd.ExecuteNonQuery();

            ConexionRetorno.Close();

            return affectedRows > 0;
        }

        public List<ObjRol> CargarRoles()
        {
            ConexionRetorno = conexion.ConexionBD();

            List<ObjRol> ListaRoles = new List<ObjRol>();

            cmd = new NpgsqlCommand("SELECT * FROM rol ", ConexionRetorno);

            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ObjRol Rol = new ObjRol
                {
                    Id = dr.GetInt32(0),
                    Nombre = dr.GetString(1)
                };
                ListaRoles.Add(Rol);
            }

            ConexionRetorno.Close();

            return ListaRoles;
        }
    }
}
