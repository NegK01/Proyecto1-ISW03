using Negocio;
//Using Añadidos
using Objetos;
using System;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class FrmLogin : Form
    {
        Usuarios Usuarios = new Usuarios();

        public FrmLogin()
        {
            InitializeComponent();
        }

        public void RestringuirTexto(object sender, KeyPressEventArgs Tecla)
        {
            TextBox textBox = sender as TextBox;

            if (textBox.Name == "TxtContraseña")
            {
                if (!char.IsControl(Tecla.KeyChar) && (char.IsWhiteSpace(Tecla.KeyChar) || textBox.Text.Length >= 20))
                {
                    Tecla.Handled = true;
                }
            }
            else if (!char.IsControl(Tecla.KeyChar) && (!char.IsDigit(Tecla.KeyChar) || textBox.Text.Length >= 9))
            {
                Tecla.Handled = true;
            }
        }

        public void InicioSesion()
        {
            ObjUsuario NuevoUsuario = new ObjUsuario
            {
                Cedula = Convert.ToInt32(TxtCedula.Text),
                Contraseña = TxtContraseña.Text
            };

            bool Comprobacion = Usuarios.InicioSecion(NuevoUsuario);

            if (Comprobacion)
            {
                Visible = false;

                FrmPrincipal Principal = new FrmPrincipal();
                Principal.Visible = true;
            }
            else
            {
                MessageBox.Show("No se encontro ningun usuario.....");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs Tecla)
        {
            RestringuirTexto(sender, Tecla);
        }

        private void TxtId_KeyPress(object sender, KeyPressEventArgs Tecla)
        {
            RestringuirTexto(sender, Tecla);
        }

        private void TxtContraseña_KeyPress(object sender, KeyPressEventArgs Tecla)
        {
            RestringuirTexto(sender, Tecla);
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            InicioSesion();
        }

    }
}
