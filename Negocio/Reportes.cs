using System.Windows.Forms;
using Conexion; 

namespace Negocio
{
    public class Reportes
    {
        BDOrdenes bdOrdenes = new BDOrdenes();
        BDUsuarios bdUsuarios = new BDUsuarios();
        BDDistribuidores bdDistribuidores = new BDDistribuidores();

        public void Reporte_1(DataGridView Tabla)
        {
            bdOrdenes.Reporte_1(Tabla);
        }
        public void Reporte_2(DataGridView Tabla)
        {
            bdUsuarios.Reporte_2(Tabla);
        }
        public void Reporte_3(DataGridView Tabla)
        {
            bdDistribuidores.Reporte_3(Tabla);
        }
    }
}
