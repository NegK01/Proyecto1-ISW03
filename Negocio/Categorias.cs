using Conexion;
using Objetos;
using System.Collections.Generic;

namespace Negocio
{
    public class Categorias
    {
        BDCategorias bdCategorias;
        ConexionSQL conexionSQL;

        public Categorias()
        {
            bdCategorias = new BDCategorias();
            conexionSQL = new ConexionSQL();
        }

        public bool InsertarCategoria(ObjCategoria obj)
        {
            return bdCategorias.InsertarCategoriaBD(obj);
        }

        public bool ActualizarCategoria(ObjCategoria obj)
        {
            return bdCategorias.ActualizarCategoriaBD(obj);
        }

        public bool EliminarCategoria(int id)
        {
            if (conexionSQL.ConfirmarDuplicidad("producto", "id_categoria", id.ToString()))
            {
                return false;
            }

            return conexionSQL.CambiarEstadoCRUD(id, "categoria");
        }



        public List<ObjCategoria> ObtenerCategorias()
        {
            return bdCategorias.ObtenerCategoriasBD();
        }

        public List<ObjCategoria> ObtenerNombresCategorias()
        {
            return bdCategorias.ObtenerNombresCategoriasBD();
        }

        public string BuscarNombreXId(int id)
        {
            return conexionSQL.BuscarNombreXIdBD("categoria", id);
        }

        public int BuscarIdXNombre(string nombre)
        {
            return conexionSQL.BuscarIdXNombreBD("categoria", nombre);
        }
    }
}
