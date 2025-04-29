using System;
using System.Collections.Generic;
using Datos;
using Objetos;

namespace Negocio
{
    public class BOEmpleado
    {
        DAOEmpleado daoEmpleado = new DAOEmpleado();

        public void InsertarEmpleado(ObjEmpleado empleado)
        {
            try
            {
                daoEmpleado.InsertarEmpleadoBD(empleado);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar empleado: " + ex.Message);
            }
        }

        public void ModificarEmpleado(ObjEmpleado empleado)
        {
            try
            {
                daoEmpleado.ModificarEmpleadoBD(empleado);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al modificar empleado: " + ex.Message);
            }
        }

        public void EliminarEmpleado(int id)
        {
            try
            {
                daoEmpleado.EliminarEmpleadoBD(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar empleado: " + ex.Message);
            }
        }

        public List<ObjEmpleado> ObtenerListaEmpleados()
        {
            try
            {
                return daoEmpleado.ListaEmpleadosBD();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener lista de empleados: " + ex.Message);
                return new List<ObjEmpleado>();
            }
        }
    }
}
