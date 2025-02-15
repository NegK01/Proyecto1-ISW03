using System;
using System.Windows.Forms;

//Using Añadidos
using Objetos;
using Negocio;

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
            Usuarios.CargarUsuarios(DgvTablaUsuarios);
        }

        public void CargarRoles() 
        {

        }

        public void InsertarUsuario()
        {
            int SiguienteId = Usuarios.BuscarSiguienteId();

            ObjUsuario Usuario = new ObjUsuario
            {
                Id         = SiguienteId,
                Cedula     = Convert.ToInt32(TxtCedulaUsu.Text),
                Nombre     = TxtNombreUsu.Text,
                Apellido   = TxtApellidoUsu.Text,
                Correo     = TxtCorreoUsu.Text,
                Telefono   = TxtTelefonoUsu.Text,
                Direccion  = TxtDireccionUsu.Text,
                Contraseña = TxtContraseñaUsu.Text, //Cambiar por una variable encriptada
                Rol        = 0,                     //Cambiar por valuemember del combobox
                Estado     = 1
            };

            Usuarios.InsertarUsuario(Usuario);

            MessageBox.Show("Se agrego la el usuario correctamente...");

            //CargarUuarios();
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
