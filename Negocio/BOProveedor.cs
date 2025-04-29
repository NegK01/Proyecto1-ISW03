using System;
using System.Collections.Generic;
using Datos;
using Objetos;

namespace Negocio
{
    public class BOProveedor
    {
        DAOProveedor daoProveedor = new DAOProveedor();

        public void InsertarProveedor(ObjProveedor proveedor)
        {
            try
            {
                daoProveedor.InsertarProveedorBD(proveedor);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar proveedor: " + ex.Message);
            }
        }

        public void ModificarProveedor(ObjProveedor proveedor)
        {
            try
            {
                daoProveedor.ModificarProveedorBD(proveedor);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al modificar proveedor: " + ex.Message);
            }
        }

        public void EliminarProveedor(int id)
        {
            try
            {
                daoProveedor.EliminarProveedorBD(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar proveedor: " + ex.Message);
            }
        }

        public List<ObjProveedor> ObtenerListaProveedores()
        {
            try
            {
                return daoProveedor.ListaProveedoresBD();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener lista de proveedores: " + ex.Message);
                return new List<ObjProveedor>();
            }
        }
    }
}
