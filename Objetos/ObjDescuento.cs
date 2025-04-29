using System;

namespace Objetos
{
    public class ObjDescuento
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion{ get; set; }
        public int Porcentaje_De_Descuento { get; set; }
        public DateTime Fecha { get; set; }
        public bool Estado { get; set; }
    }
}
