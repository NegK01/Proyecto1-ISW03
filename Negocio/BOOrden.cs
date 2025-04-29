using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Datos;
using Objetos;

namespace Negocio
{
    public class BOOrden
    {
        private DAOOrden daoOrden = new DAOOrden();

        public void RegistrarOrden(ObjOrden orden)
        {
            try
            {
                daoOrden.InsertarOrden(orden);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al registrar la orden: " + ex.Message);
            }
        }

        public void ActualizarOrden(ObjOrden orden)
        {
            try
            {
                daoOrden.ModificarOrden(orden);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar la orden: " + ex.Message);
            }
        }

        public void EliminarOrden(int id)
        {
            try
            {
                daoOrden.EliminarOrden(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar la orden: " + ex.Message);
            }
        }

        public List<ObjOrden> ObtenerOrdenes()
        {
            try
            {
                return daoOrden.ListarOrdenes();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar las órdenes: " + ex.Message);
            }
        }
    }
}
