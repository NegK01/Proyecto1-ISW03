using Objetos;
using System;
using System.Windows.Forms;

namespace Proyecto
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ObjUsuario a = new ObjUsuario()
            {
                Rol = 1
            };

            //Application.Run(new FrmPrincipal(a));
            Application.Run(new FrmLogin());
            //Application.Run(new Form { Controls = { new CduUsuarios() } });
        }
    }
}
