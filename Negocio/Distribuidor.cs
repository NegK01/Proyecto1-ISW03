using Conexion;
using Objetos;
using System.Collections.Generic;

namespace Negocio
{
    public class Distribuidor
    {
        BDDistribuidor bdDistribuidor;
        ConexionSQL conexionSQL;

        public Distribuidor()
        {
            bdDistribuidor = new BDDistribuidor();
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

        public bool EliminarDistribuidor(int Id)
        {
            string Tabla = "distribuidor";
            return conexionSQL.CambiarEstadoCRUD(Id, Tabla);
        }

        public List<ObjDistribuidor> ObtenerDistribuidores()
        {
            return bdDistribuidor.ObtenerDistribuidoresBD();
        }
    }
}
