using Npgsql;
using Objetos;
using System.Collections.Generic;

namespace Conexion
{
    public class BDDistribuidores
    {
        public NpgsqlConnection conexionRetorno;
        public NpgsqlCommand cmd;
        ConexionSQL conexion;

        public BDDistribuidores()
        {
            conexion = new ConexionSQL();
        }

        public bool InsertarDistribuidorBD(ObjDistribuidor obj)
        {
            if (conexion.ConfirmarDuplicidad("distribuidor", "nombre", obj.Nombre))
            {
                return false;
            }

            obj.Id = conexion.BuscarSiguienteId("distribuidor");

            using (conexionRetorno = conexion.ConexionBD())
            {
                cmd = new NpgsqlCommand("INSERT INTO distribuidor (id, nombre, info_contacto) VALUES (" +
                                        obj.Id + ", '" +
                                        obj.Nombre + "', '" +
                                        obj.Contacto + "')", conexionRetorno);
                int affectedRows = cmd.ExecuteNonQuery();
                return affectedRows > 0;
            }
        }

        public bool ActualizarDistribuidorBD(ObjDistribuidor obj)
        {
            if (conexion.ConfirmarDuplicidad("distribuidor", "nombre", obj.Nombre, obj.Id))
            {
                return false;
            }

            using (conexionRetorno = conexion.ConexionBD())
            {
                cmd = new NpgsqlCommand("UPDATE distribuidor SET " +
                                        "nombre = '" + obj.Nombre + "', " +
                                        "info_contacto = '" + obj.Contacto + "' " +
                                        "WHERE id = " + obj.Id, conexionRetorno);
                int affectedRows = cmd.ExecuteNonQuery();
                return affectedRows > 0;
            }
        }

        public List<ObjDistribuidor> ObtenerDistribuidoresBD()
        {
            List<ObjDistribuidor> distribuidores = new List<ObjDistribuidor>();
            conexionRetorno = conexion.ConexionBD();
            cmd = new NpgsqlCommand("SELECT id, nombre, info_contacto, id_estado FROM distribuidor", conexionRetorno);
            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ObjDistribuidor distribuidor = new ObjDistribuidor
                {
                    Id = dr.GetInt32(0),
                    Nombre = dr.GetString(1),
                    Contacto = dr.GetString(2),
                    Id_Estado = dr.GetInt32(3)
                };
                distribuidores.Add(distribuidor);
            }

            conexionRetorno.Close();
            return distribuidores;
        }

        public List<ObjDistribuidor> ObtenerNombresDistribuidoresBD()
        {
            List<ObjDistribuidor> distribuidores = new List<ObjDistribuidor>();
            conexionRetorno = conexion.ConexionBD();
            cmd = new NpgsqlCommand("SELECT nombre FROM distribuidor where id_estado = 1", conexionRetorno);
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ObjDistribuidor distribuidor = new ObjDistribuidor
                {
                    Nombre = dr.GetString(0)
                };
                distribuidores.Add(distribuidor);
            }
            conexionRetorno.Close();
            return distribuidores;
        }

    }
}
