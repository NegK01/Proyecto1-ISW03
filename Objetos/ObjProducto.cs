using System;

namespace Objetos
{
    public class ObjProducto
    {
        public int Id { get; set; }
        public string NombreProducto { get; set; }
        public decimal Precio { get; set; }
        public string Caracteristicas { get; set; }
        public string DescripcionProducto { get; set; }
        public int Id_Categoria { get; set; }
        public int Id_Distribuidor { get; set; }
        public int Id_Estado { get; set; }
        public DateTime FechaExpiracion { get; set; }

        public ObjProducto()
        {
            Id = 0;
            NombreProducto = "";
            Precio = 0;
            Caracteristicas = "";
            DescripcionProducto = "";
            Id_Categoria = 0;
            Id_Distribuidor = 0;
            Id_Estado = 0;
            FechaExpiracion = DateTime.Now;
        }
    }
}
