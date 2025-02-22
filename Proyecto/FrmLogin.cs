//Using Añadidos
using Negocio;
using Objetos;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class FrmLogin : Form
    {
        Usuarios Usuarios = new Usuarios();

        public FrmLogin()
        {
            InitializeComponent();
            InicializarImagenes();
        }

        public void InicializarImagenes()
        {
            Imagenes.AsignarImagenes(pictureBox1, btnIngresar);
        }

        public void RestringirTexto(object sender, KeyPressEventArgs Tecla)
        {
            System.Windows.Forms.TextBox textBox = sender as System.Windows.Forms.TextBox;

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
            ObjUsuario UsuarioDado;

            if (!string.IsNullOrEmpty(TxtCedula.Text) || !string.IsNullOrEmpty(TxtContraseña.Text))
            {
                ObjUsuario NuevoUsuario = new ObjUsuario
                {
                    Cedula = Convert.ToInt32(TxtCedula.Text),
                    Contraseña = Usuarios.EncriptarMD5(TxtContraseña.Text)

                };
                string Contraseña = Usuarios.EncriptarMD5(TxtContraseña.Text);
                Console.WriteLine(Contraseña);

                UsuarioDado = Usuarios.InicioSecion(NuevoUsuario);
            }
            else
            {
                MessageBox.Show("Por favor, rellene todos los espacios.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            if (UsuarioDado.Id != 0)
            {
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
            RestringirTexto(sender, Tecla);
        }

        private void TxtId_KeyPress(object sender, KeyPressEventArgs Tecla)
        {
            RestringirTexto(sender, Tecla);
        }

        private void TxtContraseña_KeyPress(object sender, KeyPressEventArgs Tecla)
        {
            RestringirTexto(sender, Tecla);
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
