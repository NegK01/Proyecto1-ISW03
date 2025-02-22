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

        public bool InsertarRol(ObjRol NuevoRol)
        {
            if (bdRoles.ComprobarNombreRol(NuevoRol.Nombre))
            {
                return false;
            }

            return bdRoles.InsertarRol(NuevoRol);
        }

        public bool ModificarRol(ObjRol NuevoRol)
        {
            if (bdRoles.ComprobarNombreRol(NuevoRol.Nombre))
            {
                return false;
            }

            return bdRoles.ModificarRol(NuevoRol);
        }

        public bool EliminarRol(int Id)
        {
            if (conexionSQL.ConfirmarDuplicidad("usuario", "id_rol", Id.ToString()))
            {
                return false;
            }

            return conexionSQL.CambiarEstadoCRUD(Id, "rol");
        }

        public int BuscarSiguienteId()
        {
            return conexionSQL.BuscarSiguienteId("rol");
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
            return conexionSQL.BuscarIdEstado("estado", Nombre);
        }

        public string BuscarNombreEstado(int Id)
        {
            return conexionSQL.BuscarNombreEstado("estado", Id);
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
