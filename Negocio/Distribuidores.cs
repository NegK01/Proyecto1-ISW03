using Conexion;
using Objetos;
using System.Collections.Generic;

namespace Negocio
{
    public class Distribuidores
    {
        BDDistribuidores bdDistribuidor;
        ConexionSQL conexionSQL;

        public Distribuidores()
        {
            bdDistribuidor = new BDDistribuidores();
            conexionSQL = new ConexionSQL();
        }

        public bool InsertarDistribuidor(ObjDistribuidor obj)
        {
            return bdDistribuidor.InsertarDistribuidorBD(obj);
        }

        public bool ActualizarDistribuidor(ObjDistribuidor obj)
        {
            return bdDistribuidor.ActualizarDistribuidorBD(obj);
        }

        public bool EliminarDistribuidor(int id)
        {
            if (conexionSQL.ConfirmarDuplicidad("producto", "id_distribuidor", id.ToString()))
            {
                return false;
            }

            return conexionSQL.CambiarEstadoCRUD(id, "distribuidor");
        }

        public List<ObjDistribuidor> ObtenerDistribuidores()
        {
            return bdDistribuidor.ObtenerDistribuidoresBD();
        }

        public List<ObjDistribuidor> ObtenerNombresDistribuidores()
        {
            return bdDistribuidor.ObtenerNombresDistribuidoresBD();
        }

        public string BuscarNombreXId(int id)
        {
            return conexionSQL.BuscarNombreXIdBD("distribuidor", id);
        }

        public int BuscarIdXNombre(string nombre)
        {
            return conexionSQL.BuscarIdXNombreBD("distribuidor", nombre);
        }
    }
}
