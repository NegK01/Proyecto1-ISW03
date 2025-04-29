using System;
using Negocio;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class CduReportes : UserControl
    {
        //Reportes reportes = new Reportes();

        public CduReportes()
        {
            InitializeComponent();
        }

        public void Reporte_1()
        {
            //reportes.Reporte_1(DgvTablaReportes);
        }

        public void Reporte_2()
        {
            //reportes.Reporte_2(DgvTablaReportes);
        }

        public void Reporte_3()
        {
            //reportes.Reporte_3(DgvTablaReportes);
        }

        private void CbxTipoReportes_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (CbxTipoReportes.SelectedIndex)
            {
                case 0:
                    Reporte_1();
                    break;
                case 1:
                    Reporte_2();
                    break;
                case 2:
                    Reporte_3();
                    break;
            }
        }
    }
}
