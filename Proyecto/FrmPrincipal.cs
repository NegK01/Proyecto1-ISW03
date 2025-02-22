using Negocio;
using Objetos;
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
            InicializarImagenes();
            RestringirAcceso();
            InicializarClases();
        }

        private void InicializarControles()
        {
            cduUsuarios = new CduUsuarios();
            cduProductos = new CduProductos();
            cduOrdenes = new CduOrdenes();
            cduDistribuidores = new CduDistribuidores();
        }

        public void InicializarImagenes()
        {
            Imagenes.AsignarImagenes(pictureBox1, pictureBox2, pictureBox3, btnExpandirMenu, btnDashboard, btnUsuarios, btnProductos, btnOrdenes, btnDistribuidores, btnReportes, btnCerrarSesion);
        }

        public void RestringirAcceso()
        {
            if (Usuario.Rol != 1)
            {
                btnOrdenes.SetBounds(13, 141, 146, 28);
                panel1.Controls.Remove(btnUsuarios);
                panel1.Controls.Remove(btnProductos);
                panel1.Controls.Remove(btnDistribuidores);
                panel1.Controls.Remove(btnReportes);
            }
        }

        private void InicializarClases()
        {
            animador = new AnimarPanel(panel1, panel2, panel3, btnExpandirMenu, btnDashboard, btnUsuarios, btnProductos, btnOrdenes, btnDistribuidores, btnReportes, btnCerrarSesion);
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

        private void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
