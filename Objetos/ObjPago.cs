using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    public class ObjPago
    {
        public int Id { get; set; }
        public int Id_Orden { get; set; }
        public string Metodo_Pago { get; set; }
        public DateTime Fecha_Pago { get; set; }

        public ObjPago()
        {
            Id = 0;
            Id_Orden = 0;
            Metodo_Pago = "";
            Fecha_Pago = DateTime.Now;
        }
    }
}
