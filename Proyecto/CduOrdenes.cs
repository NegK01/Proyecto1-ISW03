﻿//Using Añadidos
using Negocio;
using Objetos;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class CduOrdenes : UserControl
    {
        BOProducto productos;
        BOOrden ordenes;

        public int Id_Orden = 0;

        public CduOrdenes()
        {
            InitializeComponent();

            InicializarClases();
            ObtenerIdOrden();
            CargarProductos();

            AlternarPestañas("");
        }

        private void InicializarClases()
        {
            productos = new BOProducto();
            ordenes = new BOOrden();
        }

        public void ObtenerIdOrden()
        {
            Id_Orden = ordenes.BuscarOrdenActiva(FrmPrincipal.Usuario.Id);
        }

        public void CargarProductos()
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
            DgvTablaOrdenes.Sort(DgvTablaOrdenes.Columns[2], System.ComponentModel.ListSortDirection.Ascending);
        }

        public void CargarOrdenCarrito()
        {
            List<ObjOrden> listaOrden = ordenes.CargarOrdenCarrito(Id_Orden);

            DgvOrdenCarrito.Rows.Clear();

            for (int i = 0; i < listaOrden.Count; i++)
            {
                ObjOrden obj = listaOrden[i];
                DgvOrdenCarrito.Rows.Add();
                DgvOrdenCarrito.Rows[i].Cells["IdOC"].Value = obj.Id;
                DgvOrdenCarrito.Rows[i].Cells["NombreOC"].Value = ordenes.BuscarNombreCliente(obj.Id_Cliente);
                DgvOrdenCarrito.Rows[i].Cells["FechaOC"].Value = obj.Fecha_Orden;
                DgvOrdenCarrito.Rows[i].Cells["MontoOC"].Value = obj.Precio_Total;
            }
        }

        public void CargarDetallesCarrito()
        {
            List<ObjDetalles_Ordenes> listaDetalles = ordenes.CargarDetallesCarrito(Id_Orden);

            DgvDetalleCarrito.Rows.Clear();

            for (int i = 0; i < listaDetalles.Count; i++)
            {
                ObjDetalles_Ordenes obj = listaDetalles[i];
                DgvDetalleCarrito.Rows.Add();
                DgvDetalleCarrito.Rows[i].Cells["IdDC"].Value = obj.Id;
                DgvDetalleCarrito.Rows[i].Cells["NombreDC"].Value = ordenes.BuscarNombreProducto(obj.Id_Producto);
                DgvDetalleCarrito.Rows[i].Cells["PrecioUniDC"].Value = obj.Precio;
                DgvDetalleCarrito.Rows[i].Cells["CantidadDC"].Value = obj.Cantidad;

                decimal Total = obj.Cantidad * obj.Precio;

                DgvDetalleCarrito.Rows[i].Cells["TotalDC"].Value = Total;
            }
        }

        //-----------------------------------------------------------------------------------

        public void InsertarOrden()
        {
            if (Id_Orden != 0)
            {
                return;
            }

            ObjOrden Orden = new ObjOrden()
            {
                Id_Cliente = FrmPrincipal.Usuario.Id,
                Fecha_Orden = DateTime.Now,
                Precio_Total = 0,
            };

            bool Insertado = ordenes.InsertarOrden(Orden);

            ObtenerIdOrden();
        }

        public void ModificarOrden()
        {
            ObjOrden Orden = new ObjOrden()
            {
                Id = Id_Orden
            };

            bool Modificado = ordenes.ModificarOrden(Orden);
        }

        //-----------------------------------------------------------------------------------

        public void InsertarDetalle()
        {
            ObjDetalles_Ordenes Detalle = new ObjDetalles_Ordenes()
            {
                Id_Orden = Id_Orden,
                Id_Producto = Convert.ToInt32(TxtCodigo.Text),
                Cantidad = Convert.ToInt32(SpCantidad.Text),
            };

            if (ordenes.InsertarDetalle(Detalle))
            {
                MessageBox.Show("Producto añadido al carrito correctamente.", "Producto agregado",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);

                ModificarOrden();
            }
            else
            {
                MessageBox.Show("Error al añadir el producto.", "Error",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ModificarDetalle()
        {
            foreach (DataGridViewRow Fila in DgvDetalleCarrito.Rows)
            {
                if (Convert.ToInt32(Fila.Cells["CantidadDC"].Value) == 0)
                {
                    int Id_Detalle = Convert.ToInt32(Fila.Cells["IdDC"].Value);

                    ordenes.EliminarDetalle(Id_Detalle);
                }
                else
                {
                    ObjDetalles_Ordenes Detalle = new ObjDetalles_Ordenes()
                    {
                        Id = Convert.ToInt32(Fila.Cells["IdDC"].Value),
                        Cantidad = Convert.ToInt32(Fila.Cells["CantidadDC"].Value),
                    };

                    ordenes.ModificarDetalle(Detalle);
                }
            }
        }

        public void EliminarDetalle(DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = DgvDetalleCarrito.CurrentRow;

            if (row == null)
            {
                return;
            }

            bool Condicion1 = DgvDetalleCarrito.Columns[e.ColumnIndex].Name == "EliminarDC";
            bool Condicion2 = row.Cells[1].Value != null && row.Cells[1].Value.ToString() != null;

            if (Condicion1 && Condicion2)
            {
                int Id_Detalle = Convert.ToInt32(DgvDetalleCarrito.CurrentRow.Cells["IdDC"].Value);

                if (ordenes.EliminarDetalle(Id_Detalle))
                {
                    MessageBox.Show("Producto eliminado del carrito correctamente.", "Producto eliminado",
                                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ModificarOrden();
                    CargarDetallesCarrito();
                    CargarOrdenCarrito();
                }
                else
                {
                    MessageBox.Show("Error al eliminar el producto.", "Error",
                                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor seleccione un producto.", "Error",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //-----------------------------------------------------------------------------------

        public void MostrarDetalles()
        {
            int Id = Convert.ToInt32(DgvTablaOrdenes.CurrentRow.Cells["IdO"].Value);

            ObjProducto obj = productos.ObtenerUnProducto(Id);

            TxtCodigo.Text = obj.Id.ToString();
            TxtNombre.Text = obj.NombreProducto;

            TxtCaracteristicas.Text = obj.Caracteristicas;
            TxtDescripcion.Text = obj.DescripcionProducto;
            TxtFecha.Text = obj.FechaExpiracion.ToString();
            TxtPrecioUnidad.Text = obj.Precio.ToString();

            TxtPrecioTotal.Text = "0";
            SpCantidad.Value = 1;

            CalcularTotal();
        }

        public void CalcularTotal()
        {
            int Cantidad = Convert.ToInt32(SpCantidad.Text);

            decimal Precio = Convert.ToDecimal(TxtPrecioUnidad.Text);
            decimal Total = Cantidad * Precio;

            TxtPrecioTotal.Text = Total.ToString();
        }

        public void CambiarTotalCarrito()
        {
            DataGridViewRow row = DgvDetalleCarrito.CurrentRow;

            if (row != null)
            {
                decimal Id = Convert.ToInt32(row.Cells["IdDC"].Value);
                decimal Cantidad = Convert.ToInt32(row.Cells["CantidadDC"].Value);
                decimal Total = Convert.ToDecimal(row.Cells["PrecioUniDC"].Value) * Cantidad;
                row.Cells["TotalDC"].Value = Total;

                decimal MontoTotal = 0;

                foreach (DataGridViewRow Fila in DgvDetalleCarrito.Rows)
                {
                    if (Fila.Cells["TotalDC"].Value != null)
                    {
                        MontoTotal += Convert.ToDecimal(Fila.Cells["TotalDC"].Value);
                    }
                }

                DgvOrdenCarrito.Rows[0].Cells["MontoOC"].Value = MontoTotal.ToString();

            }
        }

        private void AlternarPestañas(string Pestaña)
        {
            TabControlOrdenes.TabPages.Remove(TabDetalles);
            TabControlOrdenes.TabPages.Remove(TabCarrito);
            TabControlOrdenes.TabPages.Remove(TabPago);

            switch (Pestaña)
            {
                case "Ordenes":

                    TabControlOrdenes.TabPages.Remove(TabDetalles);
                    TabControlOrdenes.TabPages.Remove(TabCarrito);
                    TabControlOrdenes.TabPages.Remove(TabPago);
                    TabControlOrdenes.TabPages.Add(TabOrdenes);

                    TabControlOrdenes.SelectedTab = TabOrdenes;
                    break;

                case "Detalles":

                    TabControlOrdenes.TabPages.Remove(TabOrdenes);
                    TabControlOrdenes.TabPages.Remove(TabCarrito);
                    TabControlOrdenes.TabPages.Remove(TabPago);
                    TabControlOrdenes.TabPages.Add(TabDetalles);

                    TabControlOrdenes.SelectedTab = TabDetalles;
                    break;

                case "Carrito":

                    TabControlOrdenes.TabPages.Remove(TabOrdenes);
                    TabControlOrdenes.TabPages.Remove(TabDetalles);
                    TabControlOrdenes.TabPages.Remove(TabPago);
                    TabControlOrdenes.TabPages.Add(TabCarrito);

                    TabControlOrdenes.SelectedTab = TabCarrito;

                    CargarOrdenCarrito();
                    CargarDetallesCarrito();
                    break;
                case "Pago":

                    TabControlOrdenes.TabPages.Remove(TabOrdenes);
                    TabControlOrdenes.TabPages.Remove(TabDetalles);
                    TabControlOrdenes.TabPages.Remove(TabCarrito);
                    TabControlOrdenes.TabPages.Add(TabPago);

                    TabControlOrdenes.SelectedTab = TabPago;
                    break;
            }
        }

        private void DgvTablaOrdenes_CellContentClick(object sender, DataGridViewCellEventArgs Celda)
        {
            if (Celda.RowIndex < 0 || Celda.RowIndex >= DgvTablaOrdenes.Rows.Count)
            {
                return;
            }

            bool TocoAgregar = DgvTablaOrdenes.Columns[Celda.ColumnIndex].Name == "AgregarO";
            bool TocoDescartar = DgvTablaOrdenes.Columns[Celda.ColumnIndex].Name == "DesacartarO";
            bool HayCodigo = DgvTablaOrdenes.Rows[Celda.RowIndex].Cells["IdO"].Value == null;

            if (HayCodigo)
            {
                return;
            }

            if (TocoAgregar)
            {
                MostrarDetalles();
                AlternarPestañas("Detalles");
            }
            else if (TocoDescartar)
            {

            }
        }

        private void BtnCarrito_Click(object sender, EventArgs e)
        {
            AlternarPestañas("Carrito");
        }

        private void BtnCancelar_Click(object sender, System.EventArgs e)
        {
            AlternarPestañas("Ordenes");
        }

        private void BtnRetroceder_Click(object sender, EventArgs e)
        {
            ModificarDetalle();
            ModificarOrden();

            AlternarPestañas("Ordenes");
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            InsertarOrden();

            //ASSDASDASD

            InsertarDetalle();

            AlternarPestañas("Ordenes");
        }

        private void SpCantidad_Click(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void DgvDetalleCarrito_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            CambiarTotalCarrito();
        }

        private void DgvDetalleCarrito_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EliminarDetalle(e);
        }

        private void btnFinalizarPago_Click(object sender, EventArgs e)
        {
            if (chkTerminosYCondiciones.Checked)
            {
                ObjPago objPago = new ObjPago()
                {
                    Id_Orden = Id_Orden,
                    Metodo_Pago = rdbtnTransferencia.Checked ? rdbtnTransferencia.Text : rdbtnTarjetaCredDebit.Text,
                    Fecha_Pago = DateTime.Now
                };

                ModificarDetalle();
                ModificarOrden();

                if (objPago.Id_Orden != 0 && ordenes.InsertarPago(objPago))
                {
                    MessageBox.Show("Compra exitosa.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ObtenerIdOrden();
                    CargarOrdenCarrito();
                    CargarDetallesCarrito();
                    AlternarPestañas("Ordenes");
                }
                else
                {
                    MessageBox.Show("Error al realizar la compra.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, acepte los términos y condiciones antes de finalizar el pago.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelarPago_Click(object sender, EventArgs e)
        {
            AlternarPestañas("Carrito");
        }

        private void btnPagarCarrito_Click(object sender, EventArgs e)
        {
            AlternarPestañas("Pago");
            txtIdOrdenPago.Text = Id_Orden.ToString();
            txtFechaHoraPago.Text = DateTime.Now.ToString("g");
        }
    }
}
