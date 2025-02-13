//Using Añadidos
using Conexion;
using Objetos;

namespace Negocio
{
    public class Usuarios
    {
        BDUsuarios bdUsuarios = new BDUsuarios();

        public bool InicioSecion(ObjUsuario UsuarioDado)
        {
            bool Comprobacion = false;

            ObjUsuario NuevoUsuario = bdUsuarios.InicioSesion(UsuarioDado);

            if (NuevoUsuario.Id != 0 && NuevoUsuario.Contraseña != null)
            {
                Comprobacion = true;
            }

            return Comprobacion;
        }
    }
}
