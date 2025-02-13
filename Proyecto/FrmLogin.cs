using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Using Añadidos
using Objetos;
using Negocio;

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
            if (char.IsSeparator(Tecla.KeyChar) || ((TextBox)sender).Text.Length == 20)
            {
                Tecla.Handled = true;
            }
        }

        public void InicioSesion() 
        {

            ObjUsuario UsuarioDado = new ObjUsuario
            {
                Id = Convert.ToInt32(TxtId.Text),
                Contraseña = TxtContraseña.Text
            };

            bool Comprobacion = Usuarios.InicioSecion(UsuarioDado);

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
