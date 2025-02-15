//Using Añadidos
using Npgsql;
using Objetos;

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

            cmd = new NpgsqlCommand("INSERT INTO usuario (id, cedula, nombre, apellido, correo, telefono, " +
                                    "direccion, ciudad, contrasena, rol, estado) VALUES ('" +
                                    NuevoUsuario.Id + " ,  " +
                                    NuevoUsuario.Cedula + " , '" +
                                    NuevoUsuario.Nombre + "', '" +
                                    NuevoUsuario.Apellido + "', '" +
                                    NuevoUsuario.Correo + "', '" +
                                    NuevoUsuario.Telefono + "', '" +
                                    NuevoUsuario.Direccion + "', '" +
                                    NuevoUsuario.Ciudad + "', '" +
                                    NuevoUsuario.Contraseña + "',  " +
                                    NuevoUsuario.Rol + " ,  " +
                                    NuevoUsuario.Estado + " )", ConexionRetorno);

            cmd.ExecuteNonQuery();

            ConexionRetorno.Close();
        }

        public void ModificarUsuario(ObjUsuario NuevoUsuario)
        {
            ConexionRetorno = conexion.ConexionBD();

            cmd = new NpgsqlCommand("UPDATE usuario SET " +
                                    "cedula     =  " + NuevoUsuario.Cedula + " , " +
                                    "nombre     = '" + NuevoUsuario.Nombre + "', " +
                                    "apellido   = '" + NuevoUsuario.Apellido + "', " +
                                    "correo     = '" + NuevoUsuario.Correo + "', " +
                                    "telefono   = '" + NuevoUsuario.Telefono + "', " +
                                    "direccion  = '" + NuevoUsuario.Direccion + "', " +
                                    "ciudad     = '" + NuevoUsuario.Ciudad + "', " +
                                    "contrasena = '" + NuevoUsuario.Contraseña + "', " +
                                    "rol        =  " + NuevoUsuario.Rol + " , " +
                                    "estado     =  " + NuevoUsuario.Estado + "   " +
                                    "WHERE id   =  " + NuevoUsuario.Id, ConexionRetorno);

            cmd.ExecuteNonQuery();

            ConexionRetorno.Close();
        }
    }
}
