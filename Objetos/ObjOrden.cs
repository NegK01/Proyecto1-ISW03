using System;

namespace Objetos
{
    public class ObjOrden
    {
        public int Id { get; set; }
        public int Id_Cliente { get; set; }
        public DateTime Fecha_Orden { get; set; }
        public decimal Monto_Total { get; set; }
        public int Id_Empleado { get; set; }
    }
}
