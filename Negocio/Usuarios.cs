//Using Añadidos
using Conexion;
using Objetos;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

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
            return conexionSQL.BuscarSiguienteId(Tabla);
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

        public List<ObjUsuario> CargarUsuarios()
        {
            return new BDUsuarios().CargarUsuarios();
        }

        public string EncriptarMD5(string Contraseña)
        {
            MD5 md5 = MD5.Create();

            byte[] inputBytes = Encoding.UTF8.GetBytes(Contraseña);
            byte[] hashBytes = md5.ComputeHash(inputBytes);

            StringBuilder ContraEncryptada = new StringBuilder();

            for (int i = 0; i < hashBytes.Length; i++)
            {
                ContraEncryptada.Append(hashBytes[i].ToString("x2"));
            }

            return ContraEncryptada.ToString();
        }
    }
}
