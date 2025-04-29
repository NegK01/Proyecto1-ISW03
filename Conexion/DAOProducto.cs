using System;
using System.Collections.Generic;
using Objetos;
using Npgsql;

namespace Datos
{
    public class DAOProducto
    {
        public NpgsqlCommand cmd;
        public NpgsqlConnection conexionRetorno;
        Datos.ConexionSQL conexion = new Datos.ConexionSQL();

        public void InsertarProductoBD(ObjProducto producto)
        {
            conexionRetorno = conexion.ConexionBD();
            cmd = new NpgsqlCommand("INSERT INTO almacenes.productos (nombre, precio, caracteristicas, descripcion_producto, id_categoria, id_proveedor, id_descuento, estado, fecha_expiracion) " +
                                    "VALUES (@nombre, @precio, @caracteristicas, @descripcion_producto, @id_categoria, @id_proveedor, @id_descuento, @estado, @fecha_expiracion)", conexionRetorno);

            cmd.Parameters.AddWithValue("@nombre", producto.Nombre);
            cmd.Parameters.AddWithValue("@precio", producto.Precio);
            cmd.Parameters.AddWithValue("@caracteristicas", producto.Caracteristicas);
            cmd.Parameters.AddWithValue("@descripcion_producto", producto.Descripcion_Producto);
            cmd.Parameters.AddWithValue("@id_categoria", producto.Id_Categoria);
            cmd.Parameters.AddWithValue("@id_proveedor", producto.Id_Proveedor);
            cmd.Parameters.AddWithValue("@id_descuento", producto.Id_Descuento);
            cmd.Parameters.AddWithValue("@estado", producto.Estado);
            cmd.Parameters.AddWithValue("@fecha_expiracion", producto.Fecha_Expiracion);

            cmd.ExecuteNonQuery();
        }

        public void ModificarProductoBD(ObjProducto producto)
        {
            conexionRetorno = conexion.ConexionBD();
            cmd = new NpgsqlCommand("UPDATE almacenes.productos SET nombre = @nombre, precio = @precio, caracteristicas = @caracteristicas, descripcion_producto = @descripcion_producto, id_categoria = @id_categoria, id_proveedor = @id_proveedor, id_descuento = @id_descuento, estado = @estado, fecha_expiracion = @fecha_expiracion " +
                                    "WHERE id = @id", conexionRetorno);

            cmd.Parameters.AddWithValue("@nombre", producto.Nombre);
            cmd.Parameters.AddWithValue("@precio", producto.Precio);
            cmd.Parameters.AddWithValue("@caracteristicas", producto.Caracteristicas);
            cmd.Parameters.AddWithValue("@descripcion_producto", producto.Descripcion_Producto);
            cmd.Parameters.AddWithValue("@id_categoria", producto.Id_Categoria);
            cmd.Parameters.AddWithValue("@id_proveedor", producto.Id_Proveedor);
            cmd.Parameters.AddWithValue("@id_descuento", producto.Id_Descuento);
            cmd.Parameters.AddWithValue("@estado", producto.Estado);
            cmd.Parameters.AddWithValue("@fecha_expiracion", producto.Fecha_Expiracion);
            cmd.Parameters.AddWithValue("@id", producto.Id);

            cmd.ExecuteNonQuery();
        }

        public void EliminarProductoBD(int id)
        {
            conexionRetorno = conexion.ConexionBD();
            cmd = new NpgsqlCommand("DELETE FROM almacenes.productos WHERE id = @id", conexionRetorno);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }

        public List<ObjProducto> ListaProductosBD()
        {
            List<ObjProducto> listaProductos = new List<ObjProducto>();
            conexionRetorno = conexion.ConexionBD();
            string query = "SELECT id, nombre, precio, caracteristicas, descripcion_producto, id_categoria, id_proveedor, id_descuento, estado, fecha_expiracion FROM almacenes.productos";
            cmd = new NpgsqlCommand(query, conexionRetorno);

            using (NpgsqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    ObjProducto producto = new ObjProducto
                    {
                        Id = Convert.ToInt32(reader["id"]),
                        Nombre = reader["nombre"].ToString(),
                        Precio = Convert.ToDecimal(reader["precio"]),
                        Caracteristicas = reader["caracteristicas"].ToString(),
                        Descripcion_Producto = reader["descripcion_producto"].ToString(),
                        Id_Categoria = Convert.ToInt32(reader["id_categoria"]),
                        Id_Proveedor = Convert.ToInt32(reader["id_proveedor"]),
                        Id_Descuento = Convert.ToInt32(reader["id_descuento"]),
                        Estado = Convert.ToBoolean(reader["estado"]),
                        Fecha_Expiracion = Convert.ToDateTime(reader["fecha_expiracion"])
                    };
                    listaProductos.Add(producto);
                }
            }
            return listaProductos;
        }
    }
}