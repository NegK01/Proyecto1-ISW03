﻿using System;
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
            Application.Run(new FrmPrincipal());
            //Application.Run(new Form { Controls = { new CduUsuarios() } });
        }
    }
}
