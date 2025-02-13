using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Using Añadidos
using Objetos;
using Npgsql;

namespace Conexion
{
    public class ConexionSQL
    {
        public NpgsqlConnection ConexionRetorno;
        public NpgsqlConnection Conexion;
        public NpgsqlCommand cmd;

        public NpgsqlConnection ConexionBD()
        {

            string Servidor = "localhost";
            int Puerto = 5432;
            string Usuario = "postgres";
            string Clave = "Mortadela010203";
            string BaseDatos = "tienda";

            string CadenaConexion = "Server=" + Servidor + ";" + "Port=" + Puerto + ";" +
                                    "User Id=" + Usuario + ";" + "Password=" + Clave + ";" +
                                    "Database=" + BaseDatos;

            Conexion = new NpgsqlConnection(CadenaConexion);
            Conexion.Open();

            return Conexion;
        }
    }
}
