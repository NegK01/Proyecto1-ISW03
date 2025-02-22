using System.Windows.Forms;
using Conexion; 

namespace Negocio
{
    public class Reportes
    {
        BDOrdenes bdOrdenes = new BDOrdenes();

        public void Reporte_1(DataGridView Tabla)
        {
            bdOrdenes.Reporte1(Tabla);
        }
        public void Reporte_2()
        {

        }
        public void Reporte_3()
        {

        }
    }
}
