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
            return bdProductos.ObtenerProductosBD("");
        }

        public ObjProducto ObtenerUnProducto(int Id)
        {
            string Condicion = "WHERE id = " + Id;

            List<ObjProducto> Lista = bdProductos.ObtenerProductosBD(Condicion);

            ObjProducto Producto = Lista[0];

            return Producto;
        }

        public int BuscarIdEstado(string Nombre)
        {
            string TablaEstado = "estado";

            return conexionSQL.BuscarIdEstado(TablaEstado, Nombre);
        }

        public string BuscarNombreEstado(int Id)
        {
            string TablaEstado = "estado";

            return conexionSQL.BuscarNombreEstado(TablaEstado, Id);
        }
    }
}
