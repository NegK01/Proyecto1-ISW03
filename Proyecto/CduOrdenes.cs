using Negocio;
using Objetos;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class CduOrdenes : UserControl
    {
        Productos productos;
        Ordenes ordenes;

        public CduOrdenes()
        {
            InitializeComponent();

            InicializarClases();
            CargarProductos();

            TabControlOrdenes.TabPages.Remove(TabDetalles);
        }

        private void InicializarClases()
        {
            productos = new Productos();
            ordenes = new Ordenes();
        }

        private void CargarProductos()
        {
            List<ObjProducto> listaObjProductos = productos.ObtenerProductos();

            DgvTablaOrdenes.Rows.Clear();
            for (int i = 0; i < listaObjProductos.Count; i++)
            {
                ObjProducto obj = listaObjProductos[i];
                DgvTablaOrdenes.Rows.Add();

                DgvTablaOrdenes.Rows[i].Cells["IdO"].Value = obj.Id;
                DgvTablaOrdenes.Rows[i].Cells["NombreO"].Value = obj.NombreProducto;
                DgvTablaOrdenes.Rows[i].Cells["PrecioO"].Value = obj.Precio;
                DgvTablaOrdenes.Rows[i].Cells["FechaO"].Value = obj.FechaExpiracion;
            }
            DgvTablaOrdenes.Sort(DgvTablaOrdenes.Columns[1], System.ComponentModel.ListSortDirection.Ascending);
        }

        private void DgvTablaOrdenes_CellContentClick(object sender, DataGridViewCellEventArgs Celda)
        {
            bool TocoBoton = DgvTablaOrdenes.Columns[Celda.ColumnIndex].Name == "BotonO";
            bool HayCodigo = DgvTablaOrdenes.Rows[Celda.RowIndex].Cells["IdO"].Value != null;
            if (TocoBoton && HayCodigo)
            {
                AlternarPestañas();
            }
        }

        private void AlternarPestañas()
        {
            if (TabControlOrdenes.SelectedTab == TabOrdenes)
            {
                TabControlOrdenes.TabPages.Remove(TabOrdenes);
                TabControlOrdenes.TabPages.Add(TabDetalles);

                TabControlOrdenes.SelectedTab = TabDetalles;
            }
            else
            {
                TabControlOrdenes.TabPages.Remove(TabDetalles);
                TabControlOrdenes.TabPages.Add(TabOrdenes);

                TabControlOrdenes.SelectedTab = TabOrdenes;
            }
        }

        private void BtnCancelar_Click(object sender, System.EventArgs e)
        {
            AlternarPestañas();
        }
    }
}
