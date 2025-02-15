//Using Añadidos
using Conexion;
using Objetos;

namespace Negocio
{
    public class Usuarios
    {
        BDUsuarios bdUsuarios = new BDUsuarios();
        ConexionSQL conexionSQL = new ConexionSQL();

        public bool InicioSecion(ObjUsuario NuevoUsuario)
        {
            bool Comprobacion = false;

            ObjUsuario UsuarioDado = bdUsuarios.InicioSesion(NuevoUsuario);

            if (UsuarioDado.Id != 0 && UsuarioDado.Contraseña != null)
            {
                Comprobacion = true;
            }

            return Comprobacion;
        }

        public void InsertarUsuario(ObjUsuario NuevoUsuario)
        {
            bdUsuarios.InsertarUsuario(NuevoUsuario);
        }

        public void ModificarUsuario(ObjUsuario NuevoUsuario)
        {
            bdUsuarios.ModificarUsuario(NuevoUsuario);
        }

        public void EliminarUsuario(int Id)
        {
            string Tabla = "usuario";

            conexionSQL.CambiarEstadoCRUD(Id, Tabla);
        }

        public int BuscarSiguienteId()
        {
            string Tabla = "usuario";

            int SiguienteId = conexionSQL.BuscarSiguienteId(Tabla);

            return SiguienteId;
        }
    }
}
