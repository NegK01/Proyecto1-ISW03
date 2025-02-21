﻿using Objetos;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class FrmPrincipal : Form
    {
        private AnimarPanel animador;
        private CduUsuarios cduUsuarios;
        private CduProductos cduProductos;
        private CduOrdenes cduOrdenes;
        private CduDistribuidores cduDistribuidores;

        public static ObjUsuario Usuario;

        public FrmPrincipal(ObjUsuario UsuarioDado)
        {
            InitializeComponent();
            Usuario = UsuarioDado;
            InicializarControles();
            RestringuirAcceso();
            InicializarClases();
        }

        private void InicializarControles()
        {
            cduUsuarios = new CduUsuarios();
            cduProductos = new CduProductos();
            cduOrdenes = new CduOrdenes();
            cduDistribuidores = new CduDistribuidores();
        }

        private void InicializarClases()
        {
            animador = new AnimarPanel(panel1, panel2, panel3, btnExpandirMenu, btnDashboard, btnUsuarios, btnProductos, btnOrdenes, btnDistribuidores, btnReportes, btnCerrarSesion);
        }

        public void RestringuirAcceso()
        {
            if (Usuario.Rol != 1)
            {
                //btnDashboard.SetBounds(13, 190, 146, 28);
                //btnOrdenes.SetBounds(12, 239, 146, 28);
                btnOrdenes.SetBounds(13, 141, 146, 28);
                panel1.Controls.Remove(btnUsuarios);
                panel1.Controls.Remove(btnProductos);
                panel1.Controls.Remove(btnDistribuidores);
                panel1.Controls.Remove(btnReportes);
            }
        }

        private void btnExpandirMenu_Click(object sender, System.EventArgs e)
        {

            animador.AlternarAnimacion();
            panel1.SendToBack();
        }

        public void CargarCdu(UserControl cdu)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(cdu);
            cdu.Dock = DockStyle.Fill;
        }

        private void btnUsuarios_Click(object sender, System.EventArgs e)
        {
            CargarCdu(cduUsuarios);
        }

        private void btnProductos_Click(object sender, System.EventArgs e)
        {
            CargarCdu(new CduProductos());
        }

        private void btnOrdenes_Click(object sender, System.EventArgs e)
        {
            CargarCdu(cduOrdenes);
        }

        private void btnDistribuidores_Click(object sender, System.EventArgs e)
        {
            CargarCdu(cduDistribuidores);
        }

        private void btnDashboard_Click(object sender, System.EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(pictureBox3);
        }

        private void btnReportes_Click(object sender, System.EventArgs e)
        {
            CargarCdu(new CduReportes());
        }

        private void btnCerrarSesion_Click(object sender, System.EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Visible = true;
            Visible = false;
        }
    }
}
