using System;
using System.Collections.Generic;
using Datos;
using Objetos;

namespace Negocio
{
    public class BOCategoria
    {
        DAOCategoria daoCategoria = new DAOCategoria();

        public void InsertarCategoria(ObjCategoria categoria)
        {
            try
            {
                daoCategoria.InsertarCategoriaBD(categoria);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar la categoría: " + ex.Message);
            }
        }

        public void ModificarCategoria(ObjCategoria categoria)
        {
            try
            {
                daoCategoria.ModificarCategoriaBD(categoria);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar la categoría: " + ex.Message);
            }
        }

        public void EliminarCategoria(int id)
        {
            try
            {
                daoCategoria.EliminarCategoriaBD(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar la categoría: " + ex.Message);
            }
        }

        public List<ObjCategoria> ObtenerListaCategorias()
        {
            try
            {
                return daoCategoria.ListaCategoriasBD();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la lista de categorías: " + ex.Message);
            }
        }
    }
}
