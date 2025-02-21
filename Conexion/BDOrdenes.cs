using Npgsql;
using Objetos;
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

            cmd = new NpgsqlCommand("INSERT INTO orden (id, id_cliente, fecha_orden, " +
                                    "monto_total, id_estado) VALUES (" +
                                    Orden.Id + " ,  " +
                                    Orden.Id_Cliente + " , '" +
                                    Orden.Fecha_Orden + "',  " +
                                    Orden.Precio_Total + " ,  " +
                                    Orden.Id_Estado + " )", ConexionRetorno);

            int affectedRows = cmd.ExecuteNonQuery();

            ConexionRetorno.Close();

            return affectedRows > 0;
        }

        public bool ModificarOrden(ObjOrden Orden)
        {
            ConexionRetorno = conexion.ConexionBD();

            cmd = new NpgsqlCommand("UPDATE orden SET " +
                                    "id_cliente  =  " + Orden.Id_Cliente + " , " +
                                    "fecha_orden = '" + Orden.Fecha_Orden + "', " +
                                    "monto_total =  " + Orden.Precio_Total + " , " +
                                    "id_estado   =  " + Orden.Id_Estado + ", " +
                                    "WHERE id    =  " + Orden.Id, ConexionRetorno);

            int affectedRows = cmd.ExecuteNonQuery();

            ConexionRetorno.Close();

            return affectedRows > 0;
        }

        public List<ObjOrden> CargarOrdenes()
        {
            ConexionRetorno = conexion.ConexionBD();

            List<ObjOrden> ListaOrdenes = new List<ObjOrden>();

            cmd = new NpgsqlCommand("SELECT * FROM orden", ConexionRetorno);

            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ObjOrden Orden = new ObjOrden
                {
                    Id = dr.GetInt32(0),
                    Id_Cliente = dr.GetInt32(1),
                    Fecha_Orden = dr.GetString(2),
                    Precio_Total = dr.GetDecimal(3),
                    Id_Estado = dr.GetInt32(4)
                };
                ListaOrdenes.Add(Orden);
            }

            ConexionRetorno.Close();

            return ListaOrdenes;
        }

        //-----------------------------------------------------------------------------------

        public bool InsertarDetalle(ObjDetalle Detalle)
        {
            ConexionRetorno = conexion.ConexionBD();

            cmd = new NpgsqlCommand("INSERT INTO detalle_orden (id, id_orden, id_producto, " +
                                    "cantidad, precio_unitario) VALUES (" +
                                     Detalle.Id + " ,  " +
                                     Detalle.Id_Orden + " , '" +
                                     Detalle.Id_Producto + " ,  " +
                                     Detalle.Cantidad + " ,  " +
                                     Detalle.Precio + " )", ConexionRetorno);

            int affectedRows = cmd.ExecuteNonQuery();

            ConexionRetorno.Close();

            return affectedRows > 0;
        }

        public bool ModificarDetalle(ObjDetalle Detalle)
        {
            ConexionRetorno = conexion.ConexionBD();

            cmd = new NpgsqlCommand("UPDATE detalle_orden SET " +
                                    "id_orden        =  " + Detalle.Id_Orden + " , " +
                                    "id_producto     =  " + Detalle.Id_Producto + " , " +
                                    "cantidad        =  " + Detalle.Cantidad + " , " +
                                    "precio_unitario =  " + Detalle.Precio + " , " +
                                    "WHERE id        =  " + Detalle.Id, ConexionRetorno);

            int affectedRows = cmd.ExecuteNonQuery();

            ConexionRetorno.Close();

            return affectedRows > 0;
        }

        public List<ObjDetalle> CargarDetalles()
        {
            ConexionRetorno = conexion.ConexionBD();

            List<ObjDetalle> ListaDetalles = new List<ObjDetalle>();

            cmd = new NpgsqlCommand("SELECT * FROM orden", ConexionRetorno);

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
                ListaDetalles.Add(Detalle);
            }

            ConexionRetorno.Close();

            return ListaDetalles;
        }
    }
}
