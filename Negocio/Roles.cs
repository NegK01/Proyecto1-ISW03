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

        public bool InsertarRol(ObjRol NuevoRol)
        {
            return bdRoles.InsertarRol(NuevoRol);
        }

        public bool ModificarRol(ObjRol NuevoRol)
        {
            return bdRoles.ModificarRol(NuevoRol);
        }

        public bool EliminarRol(int Id)
        {
            if (conexionSQL.ConfirmarDuplicidad("usuario", "id_rol", Id.ToString()))
            {
                return false;
            }

            return conexionSQL.CambiarEstadoCRUD(Id, Tabla);
        }

        public int BuscarSiguienteId()
        {
            return conexionSQL.BuscarSiguienteId(Tabla);
        }

        public int BuscarIdRol(string Nombre)
        {
            return bdRoles.BuscarIdRol(Nombre);
        }

        public string BuscarNombreRol(int Id)
        {
            return bdRoles.BuscarNombreRol(Id);
        }

        public int BuscarIdEstado(string Nombre)
        {
            string TablaEstado = "estado";

            return conexionSQL.BuscarIdEstado(TablaEstado, Nombre);
        }

        public string BuscarNombreEstado(int Id)
        {
            string TablaEstado = "estado";

            return conexionSQL.BuscarNombreEstado(TablaEstado, Id);
        }

        public List<ObjRol> CargarRoles()
        {
            string Codicion = "";

            return new BDRoles().CargarRoles(Codicion);
        }

        public List<ObjRol> CargarComboRoles()
        {
            string Codicion = "WHERE id_estado = 1";

            return new BDRoles().CargarRoles(Codicion);
        }
    }
}
