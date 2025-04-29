using System;
using System.Collections.Generic;
using Npgsql;
using Objetos;

namespace Datos
{
    public class DAODetalles_Ordenes
    {
        public NpgsqlCommand cmd;
        public NpgsqlConnection conexionRetorno;
        Datos.ConexionSQL conexion = new Datos.ConexionSQL();

        public void InsertarDetalleOrdenBD(ObjDetalles_Ordenes detalle)
        {
            conexionRetorno = conexion.ConexionBD();
            cmd = new NpgsqlCommand("INSERT INTO pagos.detalles_ordenes (id_orden, id_producto, cantidad, precio_unitario, descuento, subtotal) " +
                                    "VALUES (@id_orden, @id_producto, @cantidad, @precio_unitario, @descuento, @subtotal)", conexionRetorno);

            cmd.Parameters.AddWithValue("@id_orden", detalle.Id_Orden);
            cmd.Parameters.AddWithValue("@id_producto", detalle.Id_Producto);
            cmd.Parameters.AddWithValue("@cantidad", detalle.Cantidad);
            cmd.Parameters.AddWithValue("@precio_unitario", detalle.Precio_Unitario);
            cmd.Parameters.AddWithValue("@descuento", detalle.Descuento);
            cmd.Parameters.AddWithValue("@subtotal", detalle.Subtotal);

            cmd.ExecuteNonQuery();
        }

        public void ModificarDetalleOrdenBD(ObjDetalles_Ordenes detalle)
        {
            conexionRetorno = conexion.ConexionBD();
            cmd = new NpgsqlCommand("UPDATE pagos.detalles_ordenes SET id_orden = @id_orden, id_producto = @id_producto, cantidad = @cantidad, precio_unitario = @precio_unitario, descuento = @descuento, subtotal = @subtotal " +
                                    "WHERE id = @id", conexionRetorno);

            cmd.Parameters.AddWithValue("@id_orden", detalle.Id_Orden);
            cmd.Parameters.AddWithValue("@id_producto", detalle.Id_Producto);
            cmd.Parameters.AddWithValue("@cantidad", detalle.Cantidad);
            cmd.Parameters.AddWithValue("@precio_unitario", detalle.Precio_Unitario);
            cmd.Parameters.AddWithValue("@descuento", detalle.Descuento);
            cmd.Parameters.AddWithValue("@subtotal", detalle.Subtotal);
            cmd.Parameters.AddWithValue("@id", detalle.Id);

            cmd.ExecuteNonQuery();
        }

        public void EliminarDetalleOrdenBD(int id)
        {
            conexionRetorno = conexion.ConexionBD();
            cmd = new NpgsqlCommand("DELETE FROM pagos.detalles_ordenes WHERE id = @id", conexionRetorno);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }

        public List<ObjDetalles_Ordenes> ListaDetallesOrdenesBD()
        {
            List<ObjDetalles_Ordenes> listaDetalles = new List<ObjDetalles_Ordenes>();
            conexionRetorno = conexion.ConexionBD();
            string query = "SELECT id, id_orden, id_producto, cantidad, precio_unitario, descuento, subtotal FROM pagos.detalles_ordenes";
            cmd = new NpgsqlCommand(query, conexionRetorno);

            using (NpgsqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    ObjDetalles_Ordenes detalle = new ObjDetalles_Ordenes
                    {
                        Id = Convert.ToInt32(reader["id"]),
                        Id_Orden = Convert.ToInt32(reader["id_orden"]),
                        Id_Producto = Convert.ToInt32(reader["id_producto"]),
                        Cantidad = Convert.ToInt32(reader["cantidad"]),
                        Precio_Unitario = Convert.ToDecimal(reader["precio_unitario"]),
                        Descuento = Convert.ToDecimal(reader["descuento"]),
                        Subtotal = Convert.ToDecimal(reader["subtotal"])
                    };
                    listaDetalles.Add(detalle);
                }
            }
            return listaDetalles;
        }
    }
}
