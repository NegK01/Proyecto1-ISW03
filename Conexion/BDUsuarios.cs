//Using Añadidos
using Npgsql;
using Objetos;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Conexion
{
    public class BDUsuarios
    {
        public NpgsqlConnection ConexionRetorno;
        public NpgsqlCommand cmd;

        ConexionSQL conexion = new ConexionSQL();

        public ObjUsuario InicioSesion(ObjUsuario NuevoUsuario)
        {
            ObjUsuario UsuarioDado = new ObjUsuario();

            ConexionRetorno = conexion.ConexionBD();

            cmd = new NpgsqlCommand("SELECT id, contrasena FROM usuario WHERE cedula = " + NuevoUsuario.Cedula + " " +
                                    "AND contrasena = '" + NuevoUsuario.Contraseña + "' AND id_estado = 1 ", 
                                    ConexionRetorno);

            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                UsuarioDado = new ObjUsuario
                {
                    Id = dr.GetInt32(0),
                    Contraseña = dr.GetString(1),
                };
            }

            ConexionRetorno.Close();

            return UsuarioDado;
        }

        public void InsertarUsuario(ObjUsuario NuevoUsuario)
        {
            ConexionRetorno = conexion.ConexionBD();

            cmd = new NpgsqlCommand("INSERT INTO usuario (id, cedula, nombre, apellido, correo, " +
                "                   telefono, direccion, contrasena, rol, estado) VALUES ('" +
                                    NuevoUsuario.Id         + " ,  " +
                                    NuevoUsuario.Cedula     + " , '" +
                                    NuevoUsuario.Nombre     + "', '" +
                                    NuevoUsuario.Apellido   + "', '" +
                                    NuevoUsuario.Correo     + "', '" +
                                    NuevoUsuario.Telefono   + "', '" +
                                    NuevoUsuario.Direccion  + "', '" +
                                    NuevoUsuario.Contraseña + "',  " +
                                    NuevoUsuario.Rol        + " ,  " +
                                    NuevoUsuario.Estado     + " )", ConexionRetorno);

            cmd.ExecuteNonQuery();

            ConexionRetorno.Close();
        }

        public void ModificarUsuario(ObjUsuario NuevoUsuario)
        {
            ConexionRetorno = conexion.ConexionBD();

            cmd = new NpgsqlCommand("UPDATE usuario SET " +
                                    "cedula     =  " + NuevoUsuario.Cedula     + " , " +    
                                    "nombre     = '" + NuevoUsuario.Nombre     + "', " +
                                    "apellido   = '" + NuevoUsuario.Apellido   + "', " +
                                    "correo     = '" + NuevoUsuario.Correo     + "', " +
                                    "telefono   = '" + NuevoUsuario.Telefono   + "', " +
                                    "direccion  = '" + NuevoUsuario.Direccion  + "', " +
                                    "contrasena = '" + NuevoUsuario.Contraseña + "', " +
                                    "rol        =  " + NuevoUsuario.Rol        + " , " +
                                    "estado     =  " + NuevoUsuario.Estado     + "   " +
                                    "WHERE id   =  " + NuevoUsuario.Id, ConexionRetorno);

            cmd.ExecuteNonQuery();

            ConexionRetorno.Close();
        }

        public List<ObjUsuario> CargarUsuarios()
        {
            ConexionRetorno = conexion.ConexionBD();

            List<ObjUsuario> ListaUsuarios = new List<ObjUsuario>();

            cmd = new NpgsqlCommand("select u.id, u.cedula, u.nombre, u.apellido," +
                                    "u.correo, u.telefono, u.direccion, u contrasena," +
                                    "u.id_rol, u.id_estado from usuario u", 
                                    ConexionRetorno);

            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ObjUsuario Usuario = new ObjUsuario
                {
                    Id = dr.GetInt32(0),
                    Cedula = dr.GetInt32(1),
                    Nombre = dr.GetString(2),
                    Apellido = dr.GetString(3),
                    Correo = dr.GetString(4),
                    Telefono = dr.GetString(5),
                    Direccion = dr.GetString(6),
                    Contraseña = "",
                    Rol = dr.GetInt32(8),
                    Estado = dr.GetInt32(9)
                };
                ListaUsuarios.Add(Usuario);
            }

            ConexionRetorno.Close();

            return ListaUsuarios;
        }
    }
}
