using System;
using System.Collections.Generic;
using Objetos;
using Npgsql;

namespace Datos
{
    public class DAOEmpleado
    {
        public NpgsqlCommand cmd;
        public NpgsqlConnection conexionRetorno;
        Datos.ConexionSQL conexion = new Datos.ConexionSQL();

        public void InsertarEmpleadoBD(ObjEmpleado empleado)
        {
            conexionRetorno = conexion.ConexionBD();
            cmd = new NpgsqlCommand("INSERT INTO empleados.empleados (cedula, nombre, apellido, correo, telefono, contrasena, id_rol, estado, usuario) " +
                                    "VALUES (@cedula, @nombre, @apellido, @correo, @telefono, @contrasena, @id_rol, @estado, @usuario)", conexionRetorno);

            cmd.Parameters.AddWithValue("@cedula", empleado.Cedula);
            cmd.Parameters.AddWithValue("@nombre", empleado.Nombre);
            cmd.Parameters.AddWithValue("@apellido", empleado.Apellido);
            cmd.Parameters.AddWithValue("@correo", empleado.Correo);
            cmd.Parameters.AddWithValue("@telefono", empleado.Telefono);
            cmd.Parameters.AddWithValue("@contrasena", empleado.Contrasena);
            cmd.Parameters.AddWithValue("@id_rol", empleado.Id_Rol);
            cmd.Parameters.AddWithValue("@estado", empleado.Estado);
            cmd.Parameters.AddWithValue("@usuario", empleado.Usuario);

            cmd.ExecuteNonQuery();
        }

        public void ModificarEmpleadoBD(ObjEmpleado empleado)
        {
            conexionRetorno = conexion.ConexionBD();
            cmd = new NpgsqlCommand("UPDATE empleados.empleados SET cedula = @cedula, nombre = @nombre, apellido = @apellido, correo = @correo, telefono = @telefono, contrasena = @contrasena, id_rol = @id_rol, estado = @estado, usuario = @usuario " +
                                    "WHERE id = @id", conexionRetorno);

            cmd.Parameters.AddWithValue("@cedula", empleado.Cedula);
            cmd.Parameters.AddWithValue("@nombre", empleado.Nombre);
            cmd.Parameters.AddWithValue("@apellido", empleado.Apellido);
            cmd.Parameters.AddWithValue("@correo", empleado.Correo);
            cmd.Parameters.AddWithValue("@telefono", empleado.Telefono);
            cmd.Parameters.AddWithValue("@contrasena", empleado.Contrasena);
            cmd.Parameters.AddWithValue("@id_rol", empleado.Id_Rol);
            cmd.Parameters.AddWithValue("@estado", empleado.Estado);
            cmd.Parameters.AddWithValue("@usuario", empleado.Usuario);
            cmd.Parameters.AddWithValue("@id", empleado.Id);

            cmd.ExecuteNonQuery();
        }

        public void EliminarEmpleadoBD(int id)
        {
            conexionRetorno = conexion.ConexionBD();
            cmd = new NpgsqlCommand("DELETE FROM empleados.empleados WHERE id = @id", conexionRetorno);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }

        public List<ObjEmpleado> ListaEmpleadosBD()
        {
            List<ObjEmpleado> listaEmpleados = new List<ObjEmpleado>();
            conexionRetorno = conexion.ConexionBD();
            string query = "SELECT id, cedula, nombre, apellido, correo, telefono, contrasena, id_rol, estado, usuario FROM empleados.empleados";
            cmd = new NpgsqlCommand(query, conexionRetorno);

            using (NpgsqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    ObjEmpleado empleado = new ObjEmpleado
                    {
                        Id = Convert.ToInt32(reader["id"]),
                        Cedula = Convert.ToInt32(reader["cedula"]),
                        Nombre = reader["nombre"].ToString(),
                        Apellido = reader["apellido"].ToString(),
                        Correo = reader["correo"].ToString(),
                        Telefono = Convert.ToInt32(reader["telefono"]),
                        Contrasena = reader["contrasena"].ToString(),
                        Id_Rol = Convert.ToInt32(reader["id_rol"]),
                        Estado = Convert.ToBoolean(reader["estado"]),
                        Usuario = reader["usuario"].ToString()
                    };
                    listaEmpleados.Add(empleado);
                }
            }
            return listaEmpleados;
        }
    }
}