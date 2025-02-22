using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    public static class ObjImagen
    {
        public static Dictionary<string, byte[]> Imagenes { get; set; } = new Dictionary<string, byte[]>();

        static ObjImagen()
        {
            //Imagenes = new Dictionary<string, byte[]>();
        }

        
    }
}
