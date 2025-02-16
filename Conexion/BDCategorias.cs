using Npgsql;
using Objetos;
using System.Collections.Generic;

namespace Conexion
{
    public class BDCategorias
    {
        public NpgsqlConnection conexionRetorno;
        public NpgsqlCommand cmd;
        ConexionSQL conexion;

        public BDCategorias()
        {
            conexion = new ConexionSQL();
        }

        public bool InsertarCategoriaBD(ObjCategoria obj)
        {
            if (conexion.ConfirmarDuplicidad("categoria", "nombre", obj.NombreCategoria))
            {
                return false;
            }

            obj.Id = conexion.BuscarSiguienteId("categoria");

            using (conexionRetorno = conexion.ConexionBD())
            {
                cmd = new NpgsqlCommand("INSERT INTO categoria (id, nombre) VALUES (" + obj.Id + ", '" + obj.NombreCategoria + "')", conexionRetorno);
                int affectedRows = cmd.ExecuteNonQuery();
                return affectedRows > 0;
            }
        }

        public bool ActualizarCategoriaBD(ObjCategoria obj)
        {
            if (conexion.ConfirmarDuplicidad("categoria", "nombre", obj.NombreCategoria, obj.Id))
            {
                return false;
            }

            using (conexionRetorno = conexion.ConexionBD())
            {
                cmd = new NpgsqlCommand("UPDATE categoria SET " +
                                        "nombre = '" + obj.NombreCategoria + "' " +
                                        "WHERE id = " + obj.Id, conexionRetorno);
                int affectedRows = cmd.ExecuteNonQuery();
                return affectedRows > 0;
            }
        }

        public bool CategoriaRelacionadaConProductos(int idCategoria)
        {
            using (conexionRetorno = conexion.ConexionBD())
            {
                cmd = new NpgsqlCommand("SELECT COUNT(*) FROM producto WHERE id_categoria = " + idCategoria, conexionRetorno);
                var count = (long)cmd.ExecuteScalar();
                return count > 0;
            }   
        }

        public List<ObjCategoria> ObtenerCategoriasBD()
        {
            List<ObjCategoria> distribuidores = new List<ObjCategoria>();

            using (conexionRetorno = conexion.ConexionBD())
            {
                cmd = new NpgsqlCommand("SELECT id, nombre, id_estado FROM categoria", conexionRetorno);
                NpgsqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    ObjCategoria distribuidor = new ObjCategoria
                    {
                        Id = dr.GetInt32(0),
                        NombreCategoria = dr.GetString(1),
                        Id_Estado = dr.GetInt32(2)
                    };
                    distribuidores.Add(distribuidor);
                }
                return distribuidores;
            }
        }

        public List<ObjCategoria> ObtenerNombresCategoriasBD()
        {
            List<ObjCategoria> distribuidores = new List<ObjCategoria>();

            using (conexionRetorno = conexion.ConexionBD())
            {
                cmd = new NpgsqlCommand("SELECT nombre FROM categoria WHERE id_estado = 1", conexionRetorno);
                NpgsqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    ObjCategoria distribuidor = new ObjCategoria
                    {
                        NombreCategoria = dr.GetString(0).Trim(),
                    };
                    distribuidores.Add(distribuidor);
                }
                return distribuidores;
            }
        }
    }
}
