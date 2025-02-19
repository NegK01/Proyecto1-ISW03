using Conexion;
using Objetos;
using System.Collections.Generic;

namespace Negocio
{
    public class Productos
    {
        BDProductos bdProductos;
        ConexionSQL conexionSQL;

        public Productos()
        {
            bdProductos = new BDProductos();
            conexionSQL = new ConexionSQL();
        }

        public bool InsertarProducto(ObjProducto obj)
        {
            return bdProductos.InsertarProductoBD(obj);
        }

        public bool ActualizarProducto(ObjProducto obj)
        {
            return bdProductos.ActualizarProductoBD(obj);
        }

        public bool EliminarProducto(int Id)
        {
            string Tabla = "producto";
            return conexionSQL.CambiarEstadoCRUD(Id, Tabla);
        }

        public List<ObjProducto> ObtenerProductos()
        {
            return bdProductos.ObtenerProductosBD();
        }
    }
}
