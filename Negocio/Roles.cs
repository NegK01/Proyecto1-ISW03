//Using Añadidos
using Conexion;
using Objetos;
using System.Collections.Generic;

namespace Negocio
{
    public class Roles
    {
        BDRoles bdRoles = new BDRoles();
        ConexionSQL conexionSQL = new ConexionSQL();

        public string Tabla = "rol";

        public bool InsertarUsuario(ObjRol NuevoRol)
        {
            return bdRoles.InsertarRol(NuevoRol);
        }

        public bool ModificarUsuario(ObjRol NuevoRol)
        {
            return bdRoles.ModificarRol(NuevoRol);
        }

        public bool EliminarRol(int Id)
        {
            return conexionSQL.CambiarEstadoCRUD(Id, Tabla);
        }

        public int BuscarSiguienteId()
        {
            int SiguienteId = conexionSQL.BuscarSiguienteId(Tabla);

            return SiguienteId;
        }

        public List<ObjRol> CargarRoles()
        {
            return new BDRoles().CargarRoles();
        }
    }
}
