using Conexion;
using Objetos;
using System;
using System.Collections.Generic;

namespace Negocio
{
    public class Ordenes
    {
        BDOrdenes bdOrdenes = new BDOrdenes();
        ConexionSQL conexionSQL = new ConexionSQL();

        public bool InsertarOrden(ObjOrden Orden)
        {
            return bdOrdenes.InsertarOrden(Orden);
        }

        public bool ModificarOrden(ObjOrden Orden)
        {
            return bdOrdenes.ModificarOrden(Orden);
        }

        public bool EliminarOrden(int id)
        {
            if (conexionSQL.ConfirmarDuplicidad("pago", "id_orden", id.ToString()))
            {
                return false;
            }

            return conexionSQL.CambiarEstadoCRUD(id, "orden");
        }

        public List<ObjOrden> CargarOrdenCarrito(int Id_Cliente)
        {
            return bdOrdenes.CargarOrdenCarrito(Id_Cliente);
        }

        //-----------------------------------------------------------------------------------

        public bool InsertarDetalle(ObjDetalle Detalle)
        {
            if (bdOrdenes.ComprobarProductoExistente(Detalle))
            {
                return bdOrdenes.ModificarCantidadDetalle(Detalle);
            }

            return bdOrdenes.InsertarDetalle(Detalle);
        }

        public bool ModificarDetalle(ObjDetalle Detalle)
        {
            return bdOrdenes.ModificarDetalle(Detalle);
        }

        public bool EliminarDetalle(int Id_Detalle)
        {
            return bdOrdenes.EliminarDetalle(Id_Detalle);
        }

        public List<ObjDetalle> CargarDetallesCarrito(int Id_Cliente)
        {
            return bdOrdenes.CargarDetallesCarrito(Id_Cliente);
        }

        //-----------------------------------------------------------------------------------

        public bool InsertarPago(ObjPago obj)
        {
            return bdOrdenes.InsertarPagoBD(obj);
        }

        //-----------------------------------------------------------------------------------

        public int BuscarOrdenActiva(int Id_Cliente)
        {
            return bdOrdenes.BuscarOrdenActiva(Id_Cliente);
        }

        public string BuscarNombreCliente(int id)
        {
            return conexionSQL.BuscarNombreXIdBD("usuario", id);
        }

        public string BuscarNombreProducto(int id)
        {
            return conexionSQL.BuscarNombreXIdBD("Producto", id);
        }

        public int BuscarIdEstado(string Nombre)
        {
            return conexionSQL.BuscarIdEstado("estado", Nombre);
        }

        public string BuscarNombreEstado(int Id)
        {
            return conexionSQL.BuscarNombreEstado("estado", Id);
        }
    }
}
