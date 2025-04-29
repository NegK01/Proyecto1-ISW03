using System;

namespace Objetos
{
    public class ObjProducto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public string Caracteristicas { get; set; }
        public string Descripcion_Producto { get; set; }
        public int Id_Categoria { get; set; }
        public int Id_Proveedor { get; set; }
        public int Id_Descuento { get; set; }
        public bool Estado { get; set; }
        public DateTime Fecha_Expiracion { get; set; }
    }
}
