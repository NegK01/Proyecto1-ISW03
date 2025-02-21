using System.Diagnostics.Contracts;

namespace Objetos
{
    public class ObjUsuario
    {
        public int Id { get; set; }

        public int Cedula { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Correo { get; set; }

        public string Telefono { get; set; }

        public string Direccion { get; set; }

        public string Contraseña { get; set; }

        public int Rol { get; set; }

        public int Estado { get; set; }

        public ObjUsuario()
        {
            Id = 0;
            Contraseña = "";
            Rol = 0;
        }
    }
}
