using Negocio;
using Objetos;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class CduProductos : UserControl
    {
        ObjProducto objProducto;
        ObjCategoria objCategoria;
        Productos productos;
        Categorias categorias;
        Distribuidores distribuidores;

        public CduProductos()
        {
            InitializeComponent();
            InicializarClases();
            CargarTablaProductos();
            CargarTablaCategorias();
        }

        private void InicializarClases()
        {
            objProducto = new ObjProducto();
            objCategoria = new ObjCategoria();
            productos = new Productos();
            categorias = new Categorias();
            distribuidores = new Distribuidores();
        }

        private void btnAgregarPro_Click(object sender, System.EventArgs e)
        {
            if (ValidarCampos())
            {
                RecogerDatosDgvPro();
                if (productos.InsertarProducto(objProducto))
                {
                    MessageBox.Show("Producto agregado correctamente.", "Producto agregado",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarTablaProductos();
                }
                else
                {
                    MessageBox.Show("Error al agregar el producto.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnActualizarPro_Click(object sender, System.EventArgs e)
        {
            if (ValidarCampos())
            {
                RecogerDatosDgvPro();
                if (productos.ActualizarProducto(objProducto))
                {
                    MessageBox.Show("Producto actualizado correctamente.", "Producto actualizado",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarTablaProductos();
                }
                else
                {
                    MessageBox.Show("Error al actualizar el producto.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEliminarPro_Click(object sender, System.EventArgs e)
        {
            if (ValidarCampos())
            {
                RecogerDatosDgvPro();
                if (productos.EliminarProducto(objProducto.Id))
                {
                    MessageBox.Show("Producto eliminado correctamente.", "Producto eliminado",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarTablaProductos();
                }
                else
                {
                    MessageBox.Show("Error al eliminar el producto.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAgregarCat_Click(object sender, EventArgs e)
        {
            if (ValidarCamposCat())
            {
                RecogerDatosDgvCat();
                if (categorias.InsertarCategoria(objCategoria))
                {
                    MessageBox.Show("Categoria agregada correctamente.", "Categoria agregada",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarTablaCategorias();
                    CargarTablaProductos();
                }
                else
                {
                    MessageBox.Show("Error al agregar la categoria, posible duplicación del nombre de la categoría.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnActualizarCat_Click(object sender, EventArgs e)
        {
            if (ValidarCamposCat())
            {
                RecogerDatosDgvCat();
                if (categorias.ActualizarCategoria(objCategoria))
                {
                    MessageBox.Show("Categoria actualizada correctamente.", "Categoria actualizada",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarTablaCategorias();
                    CargarTablaProductos();
                }
                else
                {
                    MessageBox.Show("Error al actualizar la categoria, posible duplicación del nombre de la categoría.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEliminarCat_Click(object sender, EventArgs e)
        {
            if (ValidarCamposCat())
            {
                RecogerDatosDgvCat();
                if (categorias.EliminarCategoria(objCategoria.Id))
                {
                    MessageBox.Show("Categoria eliminada correctamente.", "Categoria eliminada",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarNombresCategorias();
                    CargarTablaCategorias();
                }
                else
                {
                    MessageBox.Show("Error al eliminar la categoria, asegurese de que no haya dependencias.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void RecogerDatosDgvPro()
        {
            objProducto.Id = Convert.ToInt32(dgvTablaProductos.CurrentRow.Cells[0].Value);
            objProducto.NombreProducto = dgvTablaProductos.CurrentRow.Cells["dgvNombreProducto"].Value.ToString();
            objProducto.Precio = decimal.Parse(dgvTablaProductos.CurrentRow.Cells["dgvPrecio"].Value.ToString());
            objProducto.Caracteristicas = dgvTablaProductos.CurrentRow.Cells["dgvCaracteristicas"].Value.ToString();
            objProducto.DescripcionProducto = dgvTablaProductos.CurrentRow.Cells["dgvDescProducto"].Value.ToString();

            objProducto.Id_Categoria = categorias.BuscarIdXNombre(dgvTablaProductos.CurrentRow.Cells["dgvIdCategoria"].Value.ToString());
            objProducto.Id_Distribuidor = distribuidores.BuscarIdXNombre(dgvTablaProductos.CurrentRow.Cells["dgvIdDistribuidor"].Value.ToString());

            objProducto.Id_Estado = Convert.ToInt32(dgvTablaProductos.CurrentRow.Cells["dgvIdEstado"].Value);

            objProducto.FechaExpiracion = DateTime.Parse(dgvTablaProductos.CurrentRow.Cells["dgvFechaExpiracion"].Value.ToString());
        }

        private void RecogerDatosDgvCat()
        {

            objCategoria.Id = Convert.ToInt32(dgvTablaCategorias.CurrentRow.Cells[0].Value);
            objCategoria.NombreCategoria = dgvTablaCategorias.CurrentRow.Cells[1].Value.ToString();
            objCategoria.Id_Estado = Convert.ToInt32(dgvTablaCategorias.CurrentRow.Cells[2].Value);
        }

        private bool ValidarCampos()
        {
            if (dgvTablaProductos.CurrentRow == null)
            {
                MessageBox.Show("No hay ninguna fila seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            DataGridViewCellCollection cells = dgvTablaProductos.CurrentRow.Cells;

            string nombreProducto = cells["dgvNombreProducto"].Value != null ? cells["dgvNombreProducto"].Value.ToString() : string.Empty;
            string precioStr = cells["dgvPrecio"].Value != null ? cells["dgvPrecio"].Value.ToString() : string.Empty;
            string caracteristicas = cells["dgvCaracteristicas"].Value != null ? cells["dgvCaracteristicas"].Value.ToString() : string.Empty;
            string descProducto = cells["dgvDescProducto"].Value != null ? cells["dgvDescProducto"].Value.ToString() : string.Empty;
            string idCategoriaStr = cells["dgvIdCategoria"].Value != null ? cells["dgvIdCategoria"].Value.ToString() : string.Empty;
            string idDistribuidorStr = cells["dgvIdDistribuidor"].Value != null ? cells["dgvIdDistribuidor"].Value.ToString() : string.Empty;
            string fechaExpiracionStr = cells["dgvFechaExpiracion"].Value != null ? cells["dgvFechaExpiracion"].Value.ToString() : string.Empty;

            if (string.IsNullOrEmpty(nombreProducto) || string.IsNullOrEmpty(precioStr) ||
                string.IsNullOrEmpty(caracteristicas) || string.IsNullOrEmpty(descProducto) ||
                string.IsNullOrEmpty(idCategoriaStr) || string.IsNullOrEmpty(idDistribuidorStr) ||
                string.IsNullOrEmpty(fechaExpiracionStr))
            {
                MessageBox.Show("Por favor, completa todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(precioStr, out decimal precio) || precio <= 0)
            {
                MessageBox.Show("El precio no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!DateTime.TryParse(fechaExpiracionStr, out DateTime fechaExpiracion))
            {
                MessageBox.Show("La fecha de expiración no es válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private bool ValidarCamposCat()
        {
            if (dgvTablaCategorias.CurrentRow == null)
            {
                MessageBox.Show("No hay ninguna fila seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            DataGridViewCellCollection cells = dgvTablaCategorias.CurrentRow.Cells;
            string nombreCategoria = cells[1].Value != null ? cells[1].Value.ToString() : string.Empty;
            Regex regexNombre = new Regex(@"^(?! )[A-Za-zÁÉÍÓÚáéíóúÑñ\s]+(?<! )$");

            if (string.IsNullOrEmpty(nombreCategoria))
            {
                MessageBox.Show("Por favor, completa el nombre de la categoría.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!regexNombre.IsMatch(nombreCategoria))
            {
                MessageBox.Show("El nombre solo puede contener letras y no debe iniciar ni terminar con espacio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void CargarTablaProductos()
        {
            CargarDistribuidores();
            CargarNombresCategorias();
            CargarProductos();
        }

        private void CargarDistribuidores()
        {
            DataGridViewComboBoxColumn cbxDistribuidores = dgvTablaProductos.Columns[6] as DataGridViewComboBoxColumn;
            
            if (cbxDistribuidores != null)
            {
                cbxDistribuidores.Items.Clear();
                List<ObjDistribuidor> listaDistribuidores = distribuidores.ObtenerNombresDistribuidores();

                foreach (ObjDistribuidor obj in listaDistribuidores)
                {
                    cbxDistribuidores.Items.Add(obj.Nombre);
                }
            }
        }

        private void CargarNombresCategorias()
        {
            DataGridViewComboBoxColumn cbxCategoria = dgvTablaProductos.Columns["dgvIdCategoria"] as DataGridViewComboBoxColumn;
            if (cbxCategoria != null)
            {
                cbxCategoria.Items.Clear();
                List<ObjCategoria> listaCategorias = categorias.ObtenerNombresCategorias();

                foreach (ObjCategoria obj in listaCategorias)
                {
                    cbxCategoria.Items.Add(obj.NombreCategoria);
                }
            }
        }


        private void CargarProductos()
        {
            List<ObjProducto> listaObjProductos = productos.ObtenerProductos();

            dgvTablaProductos.Rows.Clear();
            for (int i = 0; i < listaObjProductos.Count; i++)
            {
                ObjProducto obj = listaObjProductos[i];
                dgvTablaProductos.Rows.Add();

                dgvTablaProductos.Rows[i].Cells["dgvIdPro"].Value = obj.Id;
                dgvTablaProductos.Rows[i].Cells["dgvNombreProducto"].Value = obj.NombreProducto;
                dgvTablaProductos.Rows[i].Cells["dgvPrecio"].Value = obj.Precio;
                dgvTablaProductos.Rows[i].Cells["dgvCaracteristicas"].Value = obj.Caracteristicas;
                dgvTablaProductos.Rows[i].Cells["dgvDescProducto"].Value = obj.DescripcionProducto;
                dgvTablaProductos.Rows[i].Cells["dgvIdCategoria"].Value = categorias.BuscarNombreXId(obj.Id_Categoria);
                dgvTablaProductos.Rows[i].Cells["dgvIdDistribuidor"].Value = distribuidores.BuscarNombreXId(obj.Id_Distribuidor);
                dgvTablaProductos.Rows[i].Cells["dgvIdEstado"].Value = obj.Id_Estado;
                dgvTablaProductos.Rows[i].Cells["dgvFechaExpiracion"].Value = obj.FechaExpiracion;
            }
            dgvTablaProductos.Sort(dgvTablaProductos.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
        }

        private void CargarTablaCategorias()
        {
            List<ObjCategoria> listaObjCategorias = categorias.ObtenerCategorias();
            dgvTablaCategorias.Rows.Clear();
            for (int i = 0; i < listaObjCategorias.Count; i++)
            {
                ObjCategoria obj = listaObjCategorias[i];
                dgvTablaCategorias.Rows.Add();

                dgvTablaCategorias.Rows[i].Cells["dgvIdCat"].Value = obj.Id;
                dgvTablaCategorias.Rows[i].Cells["dgvNombreCat"].Value = obj.NombreCategoria;
                dgvTablaCategorias.Rows[i].Cells["dgvIdEstadoCat"].Value = obj.Id_Estado;
            }
            dgvTablaCategorias.Sort(dgvTablaCategorias.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
        }
    }
}
