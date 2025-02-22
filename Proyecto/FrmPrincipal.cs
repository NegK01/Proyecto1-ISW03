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
            InicializarClases();

            RestringuirAcceso();
        }

        private void InicializarControles()
        {
            cduUsuarios = new CduUsuarios();
            cduProductos = new CduProductos();
            cduOrdenes = new CduOrdenes();
            cduDistribuidores = new CduDistribuidores();
            //CargarCdu(cduUsuarios); // Tal vez colocar como primera vista un dashboard, el pago del producto o la creacion de un usuario
        }

        private void InicializarClases()
        {
            animador = new AnimarPanel(panel1, panel2, btnExpandirMenu, btnUsuarios, btnProductos, btnOrdenes, btnDistribuidores);
        }

        public void RestringuirAcceso()
        {
            if (Usuario.Rol != 1)
            {
                btnUsuarios.Visible = false;
                btnProductos.Visible = false;
                btnDistribuidores.Visible = false;
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
    }
}
