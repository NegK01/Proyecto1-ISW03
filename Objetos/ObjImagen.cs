using System.Collections.Generic;

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
