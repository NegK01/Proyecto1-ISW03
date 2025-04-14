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
        ObjDistribuidor objDistribuidor;
        Distribuidores distribuidor;
        List<ObjDistribuidor> listaObjDistribuidors;

        public CduDistribuidores()
        {
            InitializeComponent();
            objDistribuidor = new ObjDistribuidor();
            distribuidor = new Distribuidores();
            CargarTablaDistribuidores();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                RecogerDatosDgv();
                if (distribuidor.InsertarDistribuidor(objDistribuidor))
                {
                    MessageBox.Show("Distribuidor agregado correctamente.", "Distribuidor agregado",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarTablaDistribuidores();
                }
                else
                {
                    MessageBox.Show("Error al agregar el distribuidor.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                RecogerDatosDgv();
                if (distribuidor.ActualizarDistribuidor(objDistribuidor))
                {
                    MessageBox.Show("Distribuidor actualizado correctamente.", "Distribuidor actualizado",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarTablaDistribuidores();
                }
                else
                {
                    MessageBox.Show("Error al actualizar el distribuidor.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                RecogerDatosDgv();
                if (distribuidor.EliminarDistribuidor(objDistribuidor.Id))
                {
                    MessageBox.Show("Distribuidor eliminado correctamente.", "Distribuidor eliminado",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarTablaDistribuidores();
                }
                else
                {
                    MessageBox.Show("Error al eliminar el distribuidor, asegurese de que no haya dependencias.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void CargarTablaDistribuidores()
        {
            DataTable dt = distribuidor.ObtenerDistribuidores();
            DgvTablaDistribuidores.Rows.Clear();

            foreach (DataRow row in dt.Rows)
            {
                DgvTablaDistribuidores.Rows.Add(row["id"].ToString(), row["nombre"].ToString(), row["correo_contacto"].ToString(), row["numero_contacto"].ToString(), row["estado"].ToString());
            }
            DgvTablaDistribuidores.Sort(DgvTablaDistribuidores.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
        }

        private void RecogerDatosDgv()
        {
            objDistribuidor.Id = Convert.ToInt32(DgvTablaDistribuidores.CurrentRow.Cells[0].Value);
            objDistribuidor.Nombre = DgvTablaDistribuidores.CurrentRow.Cells[1].Value.ToString();
            objDistribuidor.Correo = DgvTablaDistribuidores.CurrentRow.Cells[2].Value.ToString();
            objDistribuidor.Numero = Convert.ToInt32(DgvTablaDistribuidores.CurrentRow.Cells[3].Value.ToString());
            objDistribuidor.Estado = DgvTablaDistribuidores.CurrentRow != null && DgvTablaDistribuidores.CurrentRow.Cells[4].Value != null && (bool)DgvTablaDistribuidores.CurrentRow.Cells[4].FormattedValue;
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
