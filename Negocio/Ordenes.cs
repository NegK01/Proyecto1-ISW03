using Conexion;
using Objetos;

namespace Negocio
{
    public class Ordenes
    {
        BDOrdenes bdOrdenes;
        ConexionSQL conexionSQL;

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

        //-----------------------------------------------------------------------------------

        public bool InsertarDetalle(ObjDetalle Detalle)
        {
            return bdOrdenes.InsertarDetalle(Detalle);
        }

        public bool ModificarDetalle(ObjDetalle Detalle)
        {
            return bdOrdenes.ModificarDetalle(Detalle);
        }

        public bool EliminarDetalle(int id)
        {
            return conexionSQL.CambiarEstadoCRUD(id, "detalle_orden");
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
