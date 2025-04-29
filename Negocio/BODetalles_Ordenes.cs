using System;
using System.Collections.Generic;
using Datos;
using Objetos;

namespace Negocios
{
    public class BODetalles_Ordenes
    {
        DAODetalles_Ordenes daoDetalles = new DAODetalles_Ordenes();

        public void InsertarDetalleOrden(ObjDetalles_Ordenes detalle)
        {
            try
            {
                daoDetalles.InsertarDetalleOrdenBD(detalle);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar detalle de orden: " + ex.Message);
            }
        }

        public void ModificarDetalleOrden(ObjDetalles_Ordenes detalle)
        {
            try
            {
                daoDetalles.ModificarDetalleOrdenBD(detalle);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al modificar detalle de orden: " + ex.Message);
            }
        }

        public void EliminarDetalleOrden(int id)
        {
            try
            {
                daoDetalles.EliminarDetalleOrdenBD(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar detalle de orden: " + ex.Message);
            }
        }

        public List<ObjDetalles_Ordenes> ListarDetallesOrdenes()
        {
            try
            {
                return daoDetalles.ListaDetallesOrdenesBD();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al listar detalles de órdenes: " + ex.Message);
                return new List<ObjDetalles_Ordenes>();
            }
        }
    }
}
