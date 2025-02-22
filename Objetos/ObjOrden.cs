using System;

namespace Objetos
{
    public class ObjOrden
    {
        public int Id { get; set; }

        public int Id_Cliente { get; set; }

        public DateTime Fecha_Orden { get; set; }

        public decimal Precio_Total { get; set; }

        public int Id_Estado { get; set; }
    }
}
