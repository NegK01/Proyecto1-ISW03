using Npgsql;
using Objetos;
using System;
using System.Collections.Generic;

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

            cmd = new NpgsqlCommand("UPDATE orden o SET monto_total = (" +
                                    "SELECT SUM((p.precio * d.cantidad)) FROM detalle_orden d " +
                                    "JOIN producto p ON p.id = d.id_producto WHERE d.id_orden = o.id" +
                                    ") WHERE id = " + Orden.Id, ConexionRetorno);

            int affectedRows = cmd.ExecuteNonQuery();

            ConexionRetorno.Close();

            return affectedRows > 0;
        }

        public List<ObjOrden> CargarOrdenCarrito(int Id_Orden)
        {
            ConexionRetorno = conexion.ConexionBD();

            List<ObjOrden> ListaOrden = new List<ObjOrden>();

            cmd = new NpgsqlCommand("SELECT * FROM orden WHERE id = " + Id_Orden, ConexionRetorno);
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
    }
}
