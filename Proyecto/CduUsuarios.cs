using Negocio;
//Using Añadidos
using Objetos;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class CduUsuarios : UserControl
    {
        Usuarios Usuarios = new Usuarios();

        public CduUsuarios()
        {
            InitializeComponent();
            CargarUsuarios();
        }

        public void RestringuirTexto(object sender, KeyPressEventArgs Tecla)
        {

        }

        public void CargarUsuarios()
        {
            List<ObjUsuario> ListaUsuarios = new List<ObjUsuario>();

            ListaUsuarios = Usuarios.CargarUsuarios();

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

        public void CargarRoles()
        {

        }

        public void InsertarUsuario()
        {
            int SiguienteId = Usuarios.BuscarSiguienteId();

            //ObjUsuario Usuario = new ObjUsuario
            //{
            //    Id = SiguienteId,
            //    Cedula = Convert.ToInt32(TxtCedulaUsu.Text),
            //    Nombre = TxtNombreUsu.Text,
            //    Apellido = TxtApellidoUsu.Text,
            //    Correo = TxtCorreoUsu.Text,
            //    Telefono = TxtTelefonoUsu.Text,
            //    Direccion = TxtDireccionUsu.Text,
            //    Contraseña = TxtContraseñaUsu.Text, //Cambiar por una variable encriptada
            //    Rol = 0,                     //Cambiar por valuemember del combobox
            //    Estado = 1
            //};

            //Usuarios.InsertarUsuario(Usuario);

            MessageBox.Show("Se agrego la el usuario correctamente...");

            CargarUsuarios();
        }

        public void ModificarUsuario()
        {

        }

        public void EliminarUsuario()
        {

        }

        private void TxtNombreUsu_KeyPress(object sender, KeyPressEventArgs Tecla)
        {
            RestringuirTexto(sender, Tecla);
        }

        private void TxtCedulaUsu_KeyPress(object sender, KeyPressEventArgs Tecla)
        {
            RestringuirTexto(sender, Tecla);
        }

        private void TxtApellidoUsu_KeyPress(object sender, KeyPressEventArgs Tecla)
        {
            RestringuirTexto(sender, Tecla);
        }

        private void TxtTelefonoUsu_KeyPress(object sender, KeyPressEventArgs Tecla)
        {
            RestringuirTexto(sender, Tecla);
        }

        private void TxtContraseñaUsu_KeyPress(object sender, KeyPressEventArgs Tecla)
        {
            RestringuirTexto(sender, Tecla);
        }

        private void TxtCorreoUsu_KeyPress(object sender, KeyPressEventArgs Tecla)
        {
            RestringuirTexto(sender, Tecla);
        }

        private void TxtDireccionUsu_KeyPress(object sender, KeyPressEventArgs Tecla)
        {
            RestringuirTexto(sender, Tecla);
        }
    }
}
