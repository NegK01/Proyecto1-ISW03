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
        public ObjUsuario InicioSecion(ObjUsuario NuevoUsuario)
        {
            ObjUsuario UsuarioDado = bdUsuarios.InicioSesion(NuevoUsuario);

            if (UsuarioDado.Id != 0 && UsuarioDado.Contraseña != null)
            {
                return UsuarioDado;
            }

            return new ObjUsuario();
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
            return conexionSQL.CambiarEstadoCRUD(Id, "usuario");
        }

        public int BuscarSiguienteId()
        {
            return conexionSQL.BuscarSiguienteId("usuario");
        }

        public int BuscarIdEstado(string Nombre)
        {
            return conexionSQL.BuscarIdEstado("estado", Nombre);
        }

        public string BuscarNombreEstado(int Id)
        {
            return conexionSQL.BuscarNombreEstado("estado", Id);
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
