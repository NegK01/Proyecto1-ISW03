using System;
using System.Collections.Generic;
using Datos;
using Objetos;

namespace Negocio
{
    public class BOProducto
    {
        DAOProducto daoProducto = new DAOProducto();

        public void InsertarProducto(ObjProducto producto)
        {
            try
            {
                daoProducto.InsertarProductoBD(producto);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar producto: " + ex.Message);
            }
        }

        public void ModificarProducto(ObjProducto producto)
        {
            try
            {
                daoProducto.ModificarProductoBD(producto);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al modificar producto: " + ex.Message);
            }
        }

        public void EliminarProducto(int id)
        {
            try
            {
                daoProducto.EliminarProductoBD(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar producto: " + ex.Message);
            }
        }

        public List<ObjProducto> ObtenerListaProductos()
        {
            try
            {
                return daoProducto.ListaProductosBD();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener lista de productos: " + ex.Message);
                return new List<ObjProducto>();
            }
        }
    }
}
