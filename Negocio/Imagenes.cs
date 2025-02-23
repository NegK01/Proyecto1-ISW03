using Conexion;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Negocio
{
    public static class Imagenes
    {
        static Usuarios Usuarios = new Usuarios();
        static ConexionSQL conexionSQL = new ConexionSQL();

        static Dictionary<string, byte[]> imagenes = CargarImagenes(); // Cargar las imagenes de la base de datos en el objeto imagenes


        public static byte[] ObtenerImagen(string nombre)
        {
            return imagenes.ContainsKey(nombre) ? imagenes[nombre] : null;
        }

        

        public static void AsignarImagenes(params Control[] controles)
        {
            foreach (var control in controles)
            {
                string nombreImagen = control is Button btn ? btn.Name :
                                      control is PictureBox pic ? pic.Tag?.ToString() : null;

                if (!string.IsNullOrEmpty(nombreImagen))
                {
                    byte[] imgBytes = ObtenerImagen(nombreImagen);

                    if (imgBytes != null)
                    {
                        using (MemoryStream ms = new MemoryStream(imgBytes))
                        {
                            Image imagen = Image.FromStream(ms);

                            if (control is Button boton)
                            {
                                boton.Image = imagen;
                                //posiciones y demas preferencias se colocan dentro del diseñador de cada uno
                            }
                            else if (control is PictureBox picture)
                            {
                                picture.Image = imagen;
                            }
                        }
                    }
                }
            }
        }

        public static Dictionary<string, byte[]> CargarImagenes()
        {
            return conexionSQL.CargarImagenesBD();
        }
    }
}
