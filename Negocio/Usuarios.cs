//Using Añadidos
using Conexion;
using Objetos;
using System.Collections.Generic;

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

        public bool InsertarUsuario(ObjUsuario NuevoUsuario)
        {
            return bdUsuarios.InsertarUsuario(NuevoUsuario);
        }

        public bool ModificarUsuario(ObjUsuario NuevoUsuario)
        {
            return bdUsuarios.ModificarUsuario(NuevoUsuario);
        }

        public bool EliminarUsuario(int Id)
        {
            return conexionSQL.CambiarEstadoCRUD(Id, Tabla);
        }

        public int BuscarSiguienteId()
        {
            int SiguienteId = conexionSQL.BuscarSiguienteId(Tabla);

            return SiguienteId;
        }

        public List<ObjUsuario> CargarUsuarios()
        {
            return new BDUsuarios().CargarUsuarios();
        }
    }
}
