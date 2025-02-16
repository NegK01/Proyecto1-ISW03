using Negocio;
//Using Añadidos
using Objetos;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class CduUsuarios : UserControl
    {
        Roles Roles = new Roles();
        Usuarios Usuarios = new Usuarios();

        public CduUsuarios()
        {
            InitializeComponent();
            CargarUsuarios();
            CargarRoles();
        }

        private void CargarRoles()
        {
            DataGridViewComboBoxColumn CbxRoles = DgvTablaUsuarios.Columns["Rol"] as DataGridViewComboBoxColumn;

            List<ObjRol> ListaRoles = Roles.CargarRoles();

            foreach (ObjRol rol in ListaRoles)
            {
                CbxRoles.Items.Add(rol.Nombre);
            }
        }

        public void CargarUsuarios()
        {
            List<ObjUsuario> ListaUsuarios = Usuarios.CargarUsuarios();
            DgvTablaUsuarios.Rows.Clear();

            int Contador = 0;

            foreach (ObjUsuario Usuario in ListaUsuarios)
            {
                DgvTablaUsuarios.Rows.Add();

                DgvTablaUsuarios.Rows[Contador].Cells["ID"].Value = Usuario.Id.ToString();
                DgvTablaUsuarios.Rows[Contador].Cells["Cedula"].Value = Usuario.Cedula.ToString();
                DgvTablaUsuarios.Rows[Contador].Cells["Nombre"].Value = Usuario.Nombre.ToString();
                DgvTablaUsuarios.Rows[Contador].Cells["Apellido"].Value = Usuario.Apellido.ToString();
                DgvTablaUsuarios.Rows[Contador].Cells["Correo"].Value = Usuario.Correo.ToString();
                DgvTablaUsuarios.Rows[Contador].Cells["Telefono"].Value = Usuario.Telefono.ToString();
                DgvTablaUsuarios.Rows[Contador].Cells["Direccion"].Value = Usuario.Direccion.ToString();
                DgvTablaUsuarios.Rows[Contador].Cells["Contraseña"].Value = Usuario.Contraseña.ToString();

                string Rol = Roles.BuscarNombreRol(Usuario.Rol);

                string Estado = Usuarios.BuscarNombreEstado(Usuario.Estado);

                DgvTablaUsuarios.Rows[Contador].Cells["Rol"].Value = Rol;
                DgvTablaUsuarios.Rows[Contador].Cells["Estado"].Value = Estado;

                Contador++;
            }
        }

        private bool ValidarCampos(int id)
        {
            if (DgvTablaUsuarios.CurrentRow == null)
            {
                MessageBox.Show("No hay ninguna fila seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (id == 0) 
            {
                id = DgvTablaUsuarios.CurrentRow.Cells[0].Value != null ? Convert.ToInt32(DgvTablaUsuarios.CurrentRow.Cells[0].Value) : 0;
            }

            string cedula     = DgvTablaUsuarios.CurrentRow.Cells[1].Value != null ? DgvTablaUsuarios.CurrentRow.Cells[1].Value.ToString() : string.Empty;
            string nombre     = DgvTablaUsuarios.CurrentRow.Cells[2].Value != null ? DgvTablaUsuarios.CurrentRow.Cells[2].Value.ToString() : string.Empty;
            string apellido   = DgvTablaUsuarios.CurrentRow.Cells[3].Value != null ? DgvTablaUsuarios.CurrentRow.Cells[3].Value.ToString() : string.Empty;
            string correo     = DgvTablaUsuarios.CurrentRow.Cells[4].Value != null ? DgvTablaUsuarios.CurrentRow.Cells[4].Value.ToString() : string.Empty;
            string telefono   = DgvTablaUsuarios.CurrentRow.Cells[5].Value != null ? DgvTablaUsuarios.CurrentRow.Cells[5].Value.ToString() : string.Empty;
            string direccion  = DgvTablaUsuarios.CurrentRow.Cells[6].Value != null ? DgvTablaUsuarios.CurrentRow.Cells[6].Value.ToString() : string.Empty;
            string contraseña = DgvTablaUsuarios.CurrentRow.Cells[7].Value != null ? DgvTablaUsuarios.CurrentRow.Cells[7].Value.ToString() : string.Empty;
            string rol        = DgvTablaUsuarios.CurrentRow.Cells[8].Value != null ? DgvTablaUsuarios.CurrentRow.Cells[8].Value.ToString() : string.Empty;

            Regex regexNombre = new Regex(@"^[A-Za-zÁÉÍÓÚáéíóúÑñ]+$");
            Regex regexEspacios = new Regex(@"^[^\s]+$");
            Regex regexTelefono = new Regex(@"^\d{8}$");
            Regex regexCedula = new Regex(@"^\d{9}$");

            if (id == 0)
            {
                MessageBox.Show("No se ha seleccionado un usuario.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(cedula) || string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido))
            {
                MessageBox.Show("Por favor, completa todos los campos.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(telefono) || string.IsNullOrEmpty(direccion))
            {
                MessageBox.Show("Por favor, completa todos los campos.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(contraseña) || string.IsNullOrEmpty(rol))
            {
                MessageBox.Show("Por favor, completa todos los campos.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!regexNombre.IsMatch(nombre) || !regexNombre.IsMatch(apellido) || !regexEspacios.IsMatch(contraseña))
            {
                MessageBox.Show("Ingrese un texto que no contenga espacios.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!regexEspacios.IsMatch(correo) || !correo.Contains("@gmail.com"))
            {
                MessageBox.Show("El el correo no el valido, verifique el texto dado.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!regexTelefono.IsMatch(telefono) || !regexCedula.IsMatch(cedula))
            {
                MessageBox.Show("Ingrese un texto que no contenga espacios, cedula o telefono no validos", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        public void InsertarUsuario()
        {
            DataGridViewRow row = DgvTablaUsuarios.CurrentRow;

            ObjUsuario NuevoUsuario = new ObjUsuario
            {
                Id         = Usuarios.BuscarSiguienteId(),
                Cedula     = Convert.ToInt32(row.Cells["Cedula"].Value),
                Nombre     = (string)row.Cells["Nombre"].Value,
                Apellido   = (string)row.Cells["Apellido"].Value,
                Correo     = (string)row.Cells["Correo"].Value,
                Telefono   = (string)row.Cells["Telefono"].Value,
                Direccion  = (string)row.Cells["Direccion"].Value,
                Contraseña = (string)row.Cells["Contraseña"].Value,
                Rol        = Roles.BuscarIdRol((string)row.Cells["Rol"].Value),
                Estado     = 1
            };

            if (Usuarios.InsertarUsuario(NuevoUsuario))
            {
                MessageBox.Show("Usuario agregado correctamente.", "Usuario agregado",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarUsuarios();
            }
            else
            {
                MessageBox.Show("Error al agregar el usuario.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);

                CargarUsuarios();
            }
        }

        private void BtnInsertarUsu_Click(object sender, EventArgs e)
        {
            int SiguienteID = Usuarios.BuscarSiguienteId();

            if (ValidarCampos(SiguienteID)) 
            {
                InsertarUsuario();
            }
        }

        private void BtnModificarUsu_Click(object sender, EventArgs e)
        {
            int SiguienteID = 0;
        }

        private void BtnEliminarUsu_Click(object sender, EventArgs e)
        {
            int SiguienteID = 0;
        }
    }
}
