using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;


//Using Añadidos
using Objetos;

namespace Conexion
{
    public class BDUsuarios
    {
        public NpgsqlConnection ConexionRetorno;
        public NpgsqlCommand cmd;

        ConexionSQL conexion = new ConexionSQL();

        public ObjUsuario InicioSesion(ObjUsuario UsuarioDado) 
        {
            ObjUsuario NuevoUsuario = new ObjUsuario();

            ConexionRetorno = conexion.ConexionBD();

            cmd = new NpgsqlCommand("SELECT id, contrasena FROM usuario WHERE id = " + UsuarioDado.Id + 
                                    "AND contrasena = '" + UsuarioDado.Contraseña + "'", ConexionRetorno);

            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                NuevoUsuario = new ObjUsuario
                {
                    Id = Convert.ToInt32(dr.GetString(0)),
                    Contraseña = dr.GetString(1),
                };
            }

            ConexionRetorno.Close();

            return NuevoUsuario;
        }
    }
}
