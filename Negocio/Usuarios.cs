//Using Añadidos
using Conexion;
using Objetos;
using System.Windows.Forms;

namespace Negocio
{
    public class Usuarios
    {
        BDUsuarios bdUsuarios = new BDUsuarios();
        ConexionSQL conexionSQL = new ConexionSQL();

        public string Tabla = "usuario";

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
            conexionSQL.CambiarEstadoCRUD(Id, Tabla);
        }

        public int BuscarSiguienteId()
        {
            int SiguienteId = conexionSQL.BuscarSiguienteId(Tabla);

            return SiguienteId;
        }

        public void CargarUsuarios(DataGridView Tabla)
        {
            bdUsuarios.CargarUsuarios(Tabla);
        }
    }
}
