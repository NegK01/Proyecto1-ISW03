using Npgsql;
using Objetos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Conexion
{
    public class BDOrdenes
    {
        public NpgsqlConnection ConexionRetorno;
        public NpgsqlCommand cmd;

        ConexionSQL conexion = new ConexionSQL();

        public bool InsertarOrden(ObjOrden Orden)
        {
            ConexionRetorno = conexion.ConexionBD();

            Orden.Id = conexion.BuscarSiguienteId("orden");

            cmd = new NpgsqlCommand("INSERT INTO orden (id, id_cliente, fecha_orden, monto_total) VALUES (" +
                                    Orden.Id + " ,  " +
                                    Orden.Id_Cliente + " , '" +
                                    Orden.Fecha_Orden.ToString("yyyy-MM-dd") + "',  " +
                                    Orden.Precio_Total + ")", ConexionRetorno);

            int affectedRows = cmd.ExecuteNonQuery();

            ConexionRetorno.Close();

            return affectedRows > 0;
        }

        public bool ModificarOrden(ObjOrden Orden)
        {
            ConexionRetorno = conexion.ConexionBD();

            cmd = new NpgsqlCommand("UPDATE orden o SET monto_total = COALESCE((" +
                                    "SELECT SUM((p.precio * d.cantidad)) FROM detalle_orden d " +
                                    "JOIN producto p ON p.id = d.id_producto WHERE d.id_orden = o.id" +
                                    "), 0) WHERE id = " + Orden.Id, ConexionRetorno);

            int affectedRows = cmd.ExecuteNonQuery();

            ConexionRetorno.Close();

            return affectedRows > 0;
        }

        public List<ObjOrden> CargarOrdenCarrito(int Id_Orden)
        {
            ConexionRetorno = conexion.ConexionBD();

            List<ObjOrden> ListaOrden = new List<ObjOrden>();

            cmd = new NpgsqlCommand("SELECT * FROM orden WHERE id = " + Id_Orden + " " +
                                    "AND id_estado = 1", ConexionRetorno);
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ObjOrden Orden = new ObjOrden
                {
                    Id = dr.GetInt32(0),
                    Id_Cliente = dr.GetInt32(1),
                    Fecha_Orden = dr.GetDateTime(2),
                    Precio_Total = dr.GetDecimal(3)
                };

                ListaOrden.Add(Orden);
            }
            ConexionRetorno.Close();

            return ListaOrden;
        }

        //-----------------------------------------------------------------------------------

        public bool InsertarDetalle(ObjDetalle Detalle)
        {
            ConexionRetorno = conexion.ConexionBD();

            Detalle.Id = conexion.BuscarSiguienteId("detalle_orden");

            cmd = new NpgsqlCommand("INSERT INTO detalle_orden (id, id_orden, id_producto, cantidad) VALUES (" +
                                     Detalle.Id + " ,  " +
                                     Detalle.Id_Orden + " , " +
                                     Detalle.Id_Producto + ",  " +
                                     Detalle.Cantidad + ")", ConexionRetorno);

            int affectedRows = cmd.ExecuteNonQuery();

            ConexionRetorno.Close();

            return affectedRows > 0;
        }

        public bool ModificarDetalle(ObjDetalle Detalle)
        {
            ConexionRetorno = conexion.ConexionBD();

            cmd = new NpgsqlCommand("UPDATE detalle_orden SET " +
                                    "cantidad        =  " + Detalle.Cantidad + " " +
                                    "WHERE id        =  " + Detalle.Id, ConexionRetorno);

            int affectedRows = cmd.ExecuteNonQuery();

            ConexionRetorno.Close();

            return affectedRows > 0;
        }

        public bool ModificarCantidadDetalle(ObjDetalle Detalle)
        {
            ConexionRetorno = conexion.ConexionBD();

            cmd = new NpgsqlCommand("UPDATE detalle_orden d SET cantidad = cantidad + " + Detalle.Cantidad + 
                                   " WHERE id_producto = " + Detalle.Id_Producto + " AND id_orden = " + 
                                    Detalle.Id_Orden, ConexionRetorno);

            int affectedRows = cmd.ExecuteNonQuery();

            ConexionRetorno.Close();

            return affectedRows > 0;
        }

        public bool EliminarDetalle(int Id_Detalle)
        {
            ConexionRetorno = conexion.ConexionBD();

            cmd = new NpgsqlCommand("DELETE FROM detalle_orden WHERE id = " + Id_Detalle, ConexionRetorno);

            int affectedRows = cmd.ExecuteNonQuery();

            ConexionRetorno.Close();

            return affectedRows > 0;
        }

        public List<ObjDetalle> CargarDetallesCarrito(int Id_Orden)
        {
            ConexionRetorno = conexion.ConexionBD();

            List<ObjDetalle> ListaDetalle = new List<ObjDetalle>();

            cmd = new NpgsqlCommand("SELECT d.*, p.precio FROM detalle_orden d JOIN producto p ON p.id = " +
                                    "d.id_producto WHERE id_orden = " + Id_Orden, ConexionRetorno);

            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ObjDetalle Detalle = new ObjDetalle
                {
                    Id = dr.GetInt32(0),
                    Id_Orden = dr.GetInt32(1),
                    Id_Producto = dr.GetInt32(2),
                    Cantidad = dr.GetInt32(3),
                    Precio = dr.GetDecimal(4)
                };

                ListaDetalle.Add(Detalle);
            }
            ConexionRetorno.Close();

            return ListaDetalle;
        }

        //-----------------------------------------------------------------------------------

        public bool InsertarPagoBD(ObjPago obj)
        {
            obj.Id = conexion.BuscarSiguienteId("pago");

            using (ConexionRetorno = conexion.ConexionBD())
            {
                cmd = new NpgsqlCommand("INSERT INTO pago (id, id_orden, metodo_pago, fecha_pago) VALUES (" +
                                        obj.Id + " ,  " +
                                        obj.Id_Orden + " , '" +
                                        obj.Metodo_Pago + "','" +
                                        obj.Fecha_Pago.ToString("dd-MM-yyyy") + "')", ConexionRetorno);
                int affectedRows = cmd.ExecuteNonQuery();
                cmd = new NpgsqlCommand("UPDATE orden SET id_estado = 2 WHERE id = " + obj.Id_Orden, ConexionRetorno);
                int affectedRows2 = cmd.ExecuteNonQuery();
                return affectedRows > 0 && affectedRows2 > 0;
            }
        }

        //-----------------------------------------------------------------------------------

        public int BuscarOrdenActiva(int Id_Cliente)
        {
            ConexionRetorno = conexion.ConexionBD();

            cmd = new NpgsqlCommand("SELECT id FROM orden WHERE id_cliente = " + Id_Cliente +
                                    " AND id_Estado = 1", ConexionRetorno);

            var dr = cmd.ExecuteReader();
            int Id_Orden = 0;

            while (dr.Read())
            {
                Id_Orden = dr.GetInt32(0);
            }

            Console.WriteLine(Id_Orden);

            ConexionRetorno.Close();

            return Id_Orden;
        }

        public bool ComprobarProductoExistente(ObjDetalle Detalle)
        {
            ConexionRetorno = conexion.ConexionBD();
            cmd = new NpgsqlCommand("SELECT COUNT(*) FROM detalle_orden WHERE id_producto = " + 
                                    Detalle.Id_Producto + " AND id_orden = " + Detalle.Id_Orden, ConexionRetorno);

            var dr = cmd.ExecuteReader();

            int Cantidad = 0;

            while (dr.Read())
            {
                Cantidad = dr.GetInt32(0);
            }

            ConexionRetorno.Close();

            return Cantidad > 0;
        }

        public void Reporte_1(DataGridView Tabla)
        {
            ConexionRetorno = conexion.ConexionBD();

            DataTable dataTable = new DataTable();
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(

            @"SELECT 
                c.nombre                      AS ""Nombre categoria"",
                COUNT(DISTINCT d.id_producto) AS ""Cantidad de productos"",
                SUM(d.cantidad)               AS ""Cantidad de productos vendidos"",
                SUM(d.cantidad * p.precio)    AS ""Ventas totales""
            FROM 
                detalle_orden d
            JOIN 
                producto p        ON p.id = d.id_producto
            JOIN 
                categoria c       ON c.id = p.id_categoria
            JOIN
                orden o           ON o.id = d.id_orden
            JOIN
                pago pa           ON o.id = pa.id_orden
            GROUP BY 
                ""Nombre categoria""
            ORDER BY 
                ""Ventas totales"" DESC;", ConexionRetorno);

            adapter.Fill(dataTable);
            Tabla.DataSource = dataTable;
        }
    }
}
