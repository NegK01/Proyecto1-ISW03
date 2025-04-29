using Negocio;
using Objetos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class CduDistribuidores : UserControl
    {
        ObjProveedor objDistribuidor;
        BOProveedor distribuidor;
        List<ObjProveedor> listaObjDistribuidors;

        public CduDistribuidores()
        {
            InitializeComponent();
            objDistribuidor = new ObjProveedor();
            distribuidor = new BOProveedor();
            CargarTablaDistribuidores();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                RecogerDatosDgv();
                try
                {
                    distribuidor.InsertarProveedor(objDistribuidor);
                    MessageBox.Show("Distribuidor agregado correctamente.", "Distribuidor agregado",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarTablaDistribuidores();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                RecogerDatosDgv();
                try
                {
                    distribuidor.ModificarProveedor(objDistribuidor);
                    MessageBox.Show("Distribuidor actualizado correctamente.", "Distribuidor actualizado",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarTablaDistribuidores();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                RecogerDatosDgv();
                try
                {
                    distribuidor.EliminarProveedor(objDistribuidor.Id);
                    MessageBox.Show("Distribuidor eliminado correctamente.", "Distribuidor eliminado",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarTablaDistribuidores();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void CargarTablaDistribuidores()
        {
            DgvTablaDistribuidores.Rows.Clear();
            List<ObjProveedor> listaProveedores = distribuidor.ObtenerListaProveedores();

            foreach (ObjProveedor proveedor in listaProveedores)
            {
                DgvTablaDistribuidores.Rows.Add(proveedor.Id.ToString(),
                                                proveedor.Nombre.ToString(),
                                                proveedor.Correo_Contacto.ToString(),
                                                proveedor.Estado ? "Activo" : "Inactivo");
                                                proveedor.Numero_Contacto.ToString();
            }
            DgvTablaDistribuidores.Sort(DgvTablaDistribuidores.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
        }

        private void RecogerDatosDgv()
        {
            objDistribuidor.Id = Convert.ToInt32(DgvTablaDistribuidores.CurrentRow.Cells[0].Value);
            objDistribuidor.Nombre = DgvTablaDistribuidores.CurrentRow.Cells[1].Value.ToString();
            objDistribuidor.Correo_Contacto = DgvTablaDistribuidores.CurrentRow.Cells[2].Value.ToString();
            objDistribuidor.Estado = DgvTablaDistribuidores.CurrentRow != null && DgvTablaDistribuidores.CurrentRow.Cells[3].Value != null && (bool)DgvTablaDistribuidores.CurrentRow.Cells[4].FormattedValue;
            objDistribuidor.Numero_Contacto = Convert.ToInt32(DgvTablaDistribuidores.CurrentRow.Cells[4].Value.ToString());
        }

        private bool ValidarCampos()
        {
            if (DgvTablaDistribuidores.CurrentRow == null)
            {
                MessageBox.Show("No hay ninguna fila seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string nombre = DgvTablaDistribuidores.CurrentRow.Cells[1].Value != null ? DgvTablaDistribuidores.CurrentRow.Cells[1].Value.ToString() : string.Empty;
            string contacto = DgvTablaDistribuidores.CurrentRow.Cells[2].Value != null ? DgvTablaDistribuidores.CurrentRow.Cells[2].Value.ToString() : string.Empty;
            Regex regexNombre = new Regex(@"^(?! )[A-Za-zÁÉÍÓÚáéíóúÑñ\s]+(?<! )$");
            Regex regexContacto = new Regex(@"^\d{8}$");

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(contacto))
            {
                MessageBox.Show("Por favor, completa todos los campos.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!regexNombre.IsMatch(nombre))
            {
                MessageBox.Show("El nombre solo puede contener letras y no debe iniciar ni terminar con espacio.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!regexContacto.IsMatch(contacto))
            {
                MessageBox.Show("Ingresa un número de contacto válido sin espacios al inicio o final.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}
