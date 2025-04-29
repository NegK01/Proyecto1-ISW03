//Using Añadidos
using Negocio;
using Objetos;
using System;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class FrmLogin : Form
    {
        BOCliente Usuarios = new BOCliente();

        public FrmLogin()
        {
            InitializeComponent();
            //InicializarImagenes();
        }

        public void RestringirTexto(object sender, KeyPressEventArgs Tecla)
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
            ObjCliente UsuarioDado;

            if (!string.IsNullOrEmpty(TxtCedula.Text) || !string.IsNullOrEmpty(TxtContraseña.Text))
            {
                ObjCliente NuevoUsuario = new ObjCliente
                {
                    Cedula = Convert.ToInt32(TxtCedula.Text),
                    //Cedula = Convert.ToInt32(TxtCedula.Text),
                    Contrasena = TxtContraseña.Text
                };

                //string Contraseña = TxtContraseña.Text;
                UsuarioDado = Usuarios.InicioSesion(NuevoUsuario);
            }
            else
            {
                MessageBox.Show("Por favor, rellene todos los espacios.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            if (UsuarioDado != null && UsuarioDado.Id.ToString() != "0" && UsuarioDado.Id.ToString() != null)
            {
                if (UsuarioDado.Contrasena != TxtContraseña.Text)
                {

                    Console.WriteLine(UsuarioDado.Contrasena);
                    Console.WriteLine(TxtContraseña.Text);
                    MessageBox.Show("La contraseña es incorrecta.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Visible = false;

                FrmPrincipal Principal = new FrmPrincipal(UsuarioDado);
                Principal.Visible = true;
            }
            else
            {
                MessageBox.Show("No se encontro ningun usuario.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs Tecla)
        {
            //RestringirTexto(sender, Tecla);
        }

        private void TxtId_KeyPress(object sender, KeyPressEventArgs Tecla)
        {
            //RestringirTexto(sender, Tecla);
        }

        private void TxtContraseña_KeyPress(object sender, KeyPressEventArgs Tecla)
        {
            //RestringirTexto(sender, Tecla);
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            InicioSesion();
        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
