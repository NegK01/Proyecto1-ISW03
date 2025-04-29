using System;
using System.Collections.Generic;
using Objetos;
using Npgsql;

namespace Datos
{
    public class DAOCategoria
    {
        public NpgsqlCommand cmd;
        public NpgsqlConnection conexionRetorno;
        Datos.ConexionSQL conexion = new Datos.ConexionSQL();

        public void InsertarCategoriaBD(ObjCategoria categoria)
        {
            conexionRetorno = conexion.ConexionBD();
            cmd = new NpgsqlCommand("INSERT INTO almacenes.categorias (nombre, descripcion, estado) " +
                                    "VALUES (@nombre, @descripcion, @estado)", conexionRetorno);

            cmd.Parameters.AddWithValue("@nombre", categoria.Nombre);
            cmd.Parameters.AddWithValue("@descripcion", categoria.Descripcion);
            cmd.Parameters.AddWithValue("@estado", categoria.Estado);

            cmd.ExecuteNonQuery();
        }

        public void ModificarCategoriaBD(ObjCategoria categoria)
        {
            conexionRetorno = conexion.ConexionBD();
            cmd = new NpgsqlCommand("UPDATE almacenes.categorias SET nombre = @nombre, descripcion = @descripcion, estado = @estado " +
                                    "WHERE id = @id", conexionRetorno);

            cmd.Parameters.AddWithValue("@nombre", categoria.Nombre);
            cmd.Parameters.AddWithValue("@descripcion", categoria.Descripcion);
            cmd.Parameters.AddWithValue("@estado", categoria.Estado);
            cmd.Parameters.AddWithValue("@id", categoria.Id);

            cmd.ExecuteNonQuery();
        }

        public void EliminarCategoriaBD(int id)
        {
            conexionRetorno = conexion.ConexionBD();
            cmd = new NpgsqlCommand("DELETE FROM almacenes.categorias WHERE id = @id", conexionRetorno);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }

        public List<ObjCategoria> ListaCategoriasBD()
        {
            List<ObjCategoria> listaCategorias = new List<ObjCategoria>();
            conexionRetorno = conexion.ConexionBD();
            string query = "SELECT id, nombre, descripcion, estado FROM almacenes.categorias";
            cmd = new NpgsqlCommand(query, conexionRetorno);

            using (NpgsqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    ObjCategoria categoria = new ObjCategoria
                    {
                        Id = Convert.ToInt32(reader["id"]),
                        Nombre = reader["nombre"].ToString(),
                        Descripcion = reader["descripcion"].ToString(),
                        Estado = Convert.ToBoolean(reader["estado"])
                    };
                    listaCategorias.Add(categoria);
                }
            }
            return listaCategorias;
        }
    }
}