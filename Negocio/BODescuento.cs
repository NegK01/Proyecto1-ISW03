using System;
using System.Collections.Generic;
using Datos;
using Objetos;

namespace Negocios
{
    public class BODescuento
    {
        DAODescuento daoDescuento = new DAODescuento();

        public void InsertarDescuento(ObjDescuento descuento)
        {
            try
            {
                daoDescuento.InsertarDescuentoBD(descuento);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar descuento: " + ex.Message);
            }
        }

        public void ModificarDescuento(ObjDescuento descuento)
        {
            try
            {
                daoDescuento.ModificarDescuentoBD(descuento);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al modificar descuento: " + ex.Message);
            }
        }

        public void EliminarDescuento(int id)
        {
            try
            {
                daoDescuento.EliminarDescuentoBD(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar descuento: " + ex.Message);
            }
        }

        public List<ObjDescuento> ListarDescuentos()
        {
            try
            {
                return daoDescuento.ListaDescuentosBD();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al listar descuentos: " + ex.Message);
                return new List<ObjDescuento>();
            }
        }
    }
}
