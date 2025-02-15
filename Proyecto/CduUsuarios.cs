using Negocio;
//Using Añadidos
using Objetos;
using System;
using System.Collections.Generic;
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

                string Rol = Usuario.Rol == 1 ? "Administrador" : "Usuario";
                string Estado = Usuario.Rol == 1 ? "Activo" : "Inactivo";

                DgvTablaUsuarios.Rows[Contador].Cells["Rol"].Value = Rol;
                DgvTablaUsuarios.Rows[Contador].Cells["Estado"].Value = Estado;

                Contador++;
            }
        }

        public void InsertarUsuario(DataGridViewCellEventArgs Celda)
        {
            DataGridViewRow row = DgvTablaUsuarios.Rows[Celda.RowIndex];

            ObjUsuario NuevoUsuario = new ObjUsuario
            {
                Id         = Usuarios.BuscarSiguienteId(),
                Cedula     = (int)row.Cells["Cedula"].Value,
                Nombre     = (string)row.Cells["Nombre"].Value,
                Apellido   = (string)row.Cells["Apellido"].Value,
                Correo     = (string)row.Cells["Correo"].Value,
                Telefono   = (string)row.Cells["Telefono"].Value,
                Direccion  = (string)row.Cells["Direccion"].Value,
                Contraseña = (string)row.Cells["Contraseña"].Value,
                Rol        = CbxRol.SelectedIndex + 1,
                Estado     = CbxEstado.SelectedIndex + 1
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
    }
}
