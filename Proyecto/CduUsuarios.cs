//Using Añadidos
using Negocio;
using Objetos;
using System;
using System.Collections.Generic;
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
            CargarComboRoles();
            CargarRoles();
        }

        public void CargarComboRoles()
        {
            DataGridViewComboBoxColumn CbxRoles = DgvTablaUsuarios.Columns["RolU"] as DataGridViewComboBoxColumn;

            if (CbxRoles != null)
            {
                CbxRoles.Items.Clear();

                List<ObjRol> ListaRoles = Roles.CargarComboRoles();

                foreach (ObjRol rol in ListaRoles)
                {
                    CbxRoles.Items.Add(rol.Nombre);
                }
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

                DgvTablaUsuarios.Rows[Contador].Cells["IdU"].Value = Usuario.Id.ToString();
                DgvTablaUsuarios.Rows[Contador].Cells["CedulaU"].Value = Usuario.Cedula.ToString();
                DgvTablaUsuarios.Rows[Contador].Cells["NombreU"].Value = Usuario.Nombre.ToString();
                DgvTablaUsuarios.Rows[Contador].Cells["ApellidoU"].Value = Usuario.Apellido.ToString();
                DgvTablaUsuarios.Rows[Contador].Cells["CorreoU"].Value = Usuario.Correo.ToString();
                DgvTablaUsuarios.Rows[Contador].Cells["TelefonoU"].Value = Usuario.Telefono.ToString();
                DgvTablaUsuarios.Rows[Contador].Cells["DireccionU"].Value = Usuario.Direccion.ToString();
                DgvTablaUsuarios.Rows[Contador].Cells["ContraseñaU"].Value = Usuario.Contraseña.ToString();

                string Rol = Roles.BuscarNombreRol(Usuario.Rol);

                string Estado = Usuarios.BuscarNombreEstado(Usuario.Estado);

                DgvTablaUsuarios.Rows[Contador].Cells["RolU"].Value = Rol;
                DgvTablaUsuarios.Rows[Contador].Cells["EstadoU"].Value = Estado;

                Contador++;
            }
        }

        public void CargarRoles()
        {
            List<ObjRol> ListaRoles = Roles.CargarRoles(); ;
            DgvTablaRoles.Rows.Clear();

            int Contador = 0;

            foreach (ObjRol Rol in ListaRoles)
            {
                DgvTablaRoles.Rows.Add();

                DgvTablaRoles.Rows[Contador].Cells["IdR"].Value = Rol.Id.ToString();
                DgvTablaRoles.Rows[Contador].Cells["NombreR"].Value = Rol.Nombre.ToString();

                string Estado = Roles.BuscarNombreEstado(Rol.Estado);

                DgvTablaRoles.Rows[Contador].Cells["EstadoR"].Value = Estado;

                Contador++;
            }
        }

        public bool ValidarCamposUsuario(int id)
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

            string cedula = DgvTablaUsuarios.CurrentRow.Cells[1].Value != null ? DgvTablaUsuarios.CurrentRow.Cells[1].Value.ToString() : string.Empty;
            string nombre = DgvTablaUsuarios.CurrentRow.Cells[2].Value != null ? DgvTablaUsuarios.CurrentRow.Cells[2].Value.ToString() : string.Empty;
            string apellido = DgvTablaUsuarios.CurrentRow.Cells[3].Value != null ? DgvTablaUsuarios.CurrentRow.Cells[3].Value.ToString() : string.Empty;
            string correo = DgvTablaUsuarios.CurrentRow.Cells[4].Value != null ? DgvTablaUsuarios.CurrentRow.Cells[4].Value.ToString() : string.Empty;
            string telefono = DgvTablaUsuarios.CurrentRow.Cells[5].Value != null ? DgvTablaUsuarios.CurrentRow.Cells[5].Value.ToString() : string.Empty;
            string direccion = DgvTablaUsuarios.CurrentRow.Cells[6].Value != null ? DgvTablaUsuarios.CurrentRow.Cells[6].Value.ToString() : string.Empty;
            string contraseña = DgvTablaUsuarios.CurrentRow.Cells[7].Value != null ? DgvTablaUsuarios.CurrentRow.Cells[7].Value.ToString() : string.Empty;
            string rol = DgvTablaUsuarios.CurrentRow.Cells[8].Value != null ? DgvTablaUsuarios.CurrentRow.Cells[8].Value.ToString() : string.Empty;

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

        public bool ValidarCamposRol(int id)
        {
            if (DgvTablaRoles.CurrentRow == null)
            {
                MessageBox.Show("No hay ninguna fila seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (id == 0)
            {
                id = DgvTablaRoles.CurrentRow.Cells[0].Value != null ? Convert.ToInt32(DgvTablaRoles.CurrentRow.Cells[0].Value) : 0;
            }

            string nombre = DgvTablaRoles.CurrentRow.Cells[1].Value != null ? DgvTablaRoles.CurrentRow.Cells[1].Value.ToString() : string.Empty;

            Regex regexNombre = new Regex(@"^[A-Za-zÁÉÍÓÚáéíóúÑñ]+$");

            if (id == 0)
            {
                MessageBox.Show("No se ha seleccionado un usuario.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Por favor, completa todos los campos.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!regexNombre.IsMatch(nombre))
            {
                MessageBox.Show("Ingrese un texto que no contenga espacios.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        //-----------------------------------------------------------------------------------

        public void InsertarUsuario()
        {
            DataGridViewRow row = DgvTablaUsuarios.CurrentRow;

            ObjUsuario NuevoUsuario = new ObjUsuario
            {
                Cedula = Convert.ToInt32(row.Cells["CedulaU"].Value),
                Nombre = (string)row.Cells["NombreU"].Value,
                Apellido = (string)row.Cells["ApellidoU"].Value,
                Correo = (string)row.Cells["CorreoU"].Value,
                Telefono = (string)row.Cells["TelefonoU"].Value,
                Direccion = (string)row.Cells["DireccionU"].Value,
                Contraseña = Usuarios.EncriptarMD5((string)row.Cells["ContraseñaU"].Value),
                Rol = Roles.BuscarIdRol((string)row.Cells["RolU"].Value),
            };

            Console.WriteLine(Roles.BuscarIdRol((string)row.Cells["RolU"].Value));


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

        public void ModificarUsuario()
        {
            DataGridViewRow row = DgvTablaUsuarios.CurrentRow;

            ObjUsuario NuevoUsuario = new ObjUsuario
            {
                Id = Convert.ToInt32(row.Cells["IdU"].Value),
                Cedula = Convert.ToInt32(row.Cells["CedulaU"].Value),
                Nombre = (string)row.Cells["NombreU"].Value,
                Apellido = (string)row.Cells["ApellidoU"].Value,
                Correo = (string)row.Cells["CorreoU"].Value,
                Telefono = (string)row.Cells["TelefonoU"].Value,
                Direccion = (string)row.Cells["DireccionU"].Value,
                Contraseña = Usuarios.EncriptarMD5((string)row.Cells["ContraseñaU"].Value),
                Rol = Roles.BuscarIdRol((string)row.Cells["RolU"].Value),
                Estado = Usuarios.BuscarIdEstado((string)row.Cells["EstadoU"].Value)
            };

            if (Usuarios.ModificarUsuario(NuevoUsuario))
            {
                MessageBox.Show("Usuario modificado correctamente.", "Usuario modificado",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarUsuarios();
            }
            else
            {
                MessageBox.Show("Error al modificar el usuario.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);

                CargarUsuarios();
            }
        }

        public void EliminarUsuario()
        {
            DataGridViewRow row = DgvTablaUsuarios.CurrentRow;

            int Id = Convert.ToInt32(row.Cells["IdU"].Value);

            if (DgvTablaUsuarios.CurrentRow == null)
            {
                MessageBox.Show("No se ha seleccionado un usuario.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Usuarios.EliminarUsuario(Id))
            {
                MessageBox.Show("Estado de usuario actualizado correctamente.", "Estado actualizado",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarUsuarios();
            }
            else
            {
                MessageBox.Show("Error al actualizar el estado del usuario.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                CargarUsuarios();
            }
        }

        //-----------------------------------------------------------------------------------

        public void InsertarRol()
        {
            DataGridViewRow row = DgvTablaRoles.CurrentRow;

            ObjRol NuevoRol = new ObjRol
            {
                Nombre = (string)row.Cells["NombreR"].Value,
            };

            if (Roles.InsertarRol(NuevoRol))
            {
                MessageBox.Show("Rol agregado correctamente.", "Rol agregado",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarRoles();
                CargarComboRoles();
            }
            else
            {
                MessageBox.Show("Error al agregar el nuevo rol.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);

                CargarRoles();
                CargarComboRoles();
            }
        }

        public void ModificarRol()
        {
            DataGridViewRow row = DgvTablaRoles.CurrentRow;

            ObjRol NuevoRol = new ObjRol
            {
                Id = Convert.ToInt32(row.Cells["IdR"].Value),
                Nombre = (string)row.Cells["NombreR"].Value,
                Estado = Roles.BuscarIdEstado((string)row.Cells["EstadoR"].Value)
            };

            if (Roles.ModificarRol(NuevoRol))
            {
                MessageBox.Show("Rol modificado correctamente.", "Rol modificado",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarRoles();
                CargarComboRoles();
            }
            else
            {
                MessageBox.Show("Error al modificar el rol.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);

                CargarRoles();
                CargarComboRoles();
            }
        }

        public void EliminarRol()
        {
            DataGridViewRow row = DgvTablaRoles.CurrentRow;

            int Id = Convert.ToInt32(row.Cells["IdR"].Value);

            if (DgvTablaRoles.CurrentRow == null)
            {
                MessageBox.Show("No se ha seleccionado un rol.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Roles.EliminarRol(Id))
            {
                MessageBox.Show("Estado del rol actualizado correctamente.", "Estado actualizado",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarRoles();
                CargarComboRoles();
            }
            else
            {
                MessageBox.Show("Error al actualizar el rol, asegurese de que no haya dependencias.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                CargarRoles();
                CargarComboRoles();
            }
        }

        //-----------------------------------------------------------------------------------

        private void BtnInsertarUsu_Click(object sender, EventArgs e)
        {
            int SiguienteID = Usuarios.BuscarSiguienteId();

            if (ValidarCamposUsuario(SiguienteID))
            {
                InsertarUsuario();
            }
        }

        private void BtnModificarUsu_Click(object sender, EventArgs e)
        {
            int Id = 0;

            if (ValidarCamposUsuario(Id))
            {
                ModificarUsuario();
            }
        }

        private void BtnEliminarUsu_Click(object sender, EventArgs e)
        {
            EliminarUsuario();
        }

        //-----------------------------------------------------------------------------------

        private void BtnInsertarR_Click(object sender, EventArgs e)
        {
            int SiguienteID = Roles.BuscarSiguienteId();

            if (ValidarCamposRol(SiguienteID))
            {
                InsertarRol();
            }
        }

        private void BtnModificarR_Click(object sender, EventArgs e)
        {
            int Id = 0;

            if (ValidarCamposRol(Id))
            {
                ModificarRol();
            }
        }

        private void BtnEliminarR_Click(object sender, EventArgs e)
        {
            EliminarRol();
        }
    }
}
