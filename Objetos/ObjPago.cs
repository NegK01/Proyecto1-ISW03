using System;

namespace Objetos
{
    public class ObjPago
    {
        public int Id { get; set; }
        public int Id_Orden { get; set; }
        public int Id_Metodo_Pago { get; set; }
        public DateTime Fecha_Pago { get; set; }
        public int Id_Estado_Pago { get; set; }
    }
}
