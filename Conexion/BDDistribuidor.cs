using Npgsql;
using Objetos;
using System.Collections.Generic;

namespace Conexion
{
    public class BDDistribuidor
    {
        public NpgsqlConnection conexionRetorno;
        public NpgsqlCommand cmd;
        ConexionSQL conexion;

        public BDDistribuidor()
        {
            conexion = new ConexionSQL();
        }

        public bool InsertarDistribuidorBD(ObjDistribuidor obj)
        {
            obj.Id = conexion.BuscarSiguienteId("distribuidor");

            using (conexionRetorno = conexion.ConexionBD())
            {
                cmd = new NpgsqlCommand("INSERT INTO distribuidor (id, nombre_distribuidor, info_contacto) VALUES (" +
                                        obj.Id + ", '" +
                                        obj.Nombre + "', '" +
                                        obj.Contacto + "')", conexionRetorno);
                int affectedRows = cmd.ExecuteNonQuery();
                return affectedRows > 0;
            }
        }

        public bool ActualizarDistribuidorBD(ObjDistribuidor obj)
        {
            using (conexionRetorno = conexion.ConexionBD())
            {
                cmd = new NpgsqlCommand("UPDATE distribuidor SET " +
                                        "nombre_distribuidor = '" + obj.Nombre + "', " +
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
            cmd = new NpgsqlCommand("SELECT id, nombre_distribuidor, info_contacto FROM distribuidor where id_estado = 1", conexionRetorno);
            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ObjDistribuidor distribuidor = new ObjDistribuidor
                {
                    Id = dr.GetInt32(0),
                    Nombre = dr.GetString(1),
                    Contacto = dr.GetString(2)
                };
                distribuidores.Add(distribuidor);
            }

            conexionRetorno.Close();
            return distribuidores;
        }
    }
}
