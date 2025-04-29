using System;

namespace Objetos
{
    public class ObjPedidos_Proveedor
    {
        public int Id { get; set; }
        public int Id_Proveedor { get; set; }
        public DateTime Fecha_Pedido { get; set; }
        public int Id_Empleado { get; set; }
        public decimal Monto_Total { get; set; }
    }
}
