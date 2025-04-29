using System;
using System.Collections.Generic;
using Objetos;
using Npgsql;

namespace Datos
{
    public class DAOCliente
    {
        public NpgsqlCommand cmd;
        public NpgsqlConnection conexionRetorno;
        Datos.ConexionSQL conexion = new Datos.ConexionSQL();

        public void InsertarClienteBD(ObjCliente cliente)
        {
            if (conexion.ConfirmarDuplicidad("clientes.clientes", "cedula", cliente.Cedula.ToString()))
            {
                throw new Exception("El cliente con la cédula proporcionada ya existe en la base de datos.");
            }

            using (conexionRetorno = conexion.ConexionBD())
            using (var transaccion = conexionRetorno.BeginTransaction())
            {
                try
                {
                    cmd = new NpgsqlCommand("CALL clientes.Insertar_Clientes(@nombre, @apellido, @correo, @telefono, @contrasena, @estado, @cedula)", conexionRetorno);
                    cmd.Transaction = transaccion;
                    cmd.Parameters.AddWithValue("@nombre", cliente.Nombre);
                    cmd.Parameters.AddWithValue("@apellido", cliente.Apellido);
                    cmd.Parameters.AddWithValue("@correo", cliente.Correo);
                    cmd.Parameters.AddWithValue("@telefono", cliente.Telefono);
                    cmd.Parameters.AddWithValue("@contrasena", cliente.Contrasena);
                    cmd.Parameters.AddWithValue("@estado", cliente.Estado);
                    cmd.Parameters.AddWithValue("@cedula", cliente.Cedula);

                    cmd.ExecuteNonQuery();
                    transaccion.Commit();
                }
                catch (Exception ex)
                {
                    transaccion.Rollback();
                    throw new Exception("Error al insertar el cliente: " + ex.Message, ex); // Incluye excepción original
                }
            }
        }

        public void ModificarClienteBD(ObjCliente cliente)
        {
            if (conexion.ConfirmarDuplicidad("clientes.clientes", "cedula", cliente.Cedula.ToString(), cliente.Id))
            {
                throw new Exception("Otro cliente ya tiene la misma cédula proporcionada.");
            }

            using (conexionRetorno = conexion.ConexionBD())
            using (var transaccion = conexionRetorno.BeginTransaction())
            {
                try
                {
                    cmd = new NpgsqlCommand("CALL clientes.Actualizar_Clientes(@id, @nombre, @apellido, @correo, @telefono, @contrasena, @estado, @cedula)", conexionRetorno);
                    cmd.Transaction = transaccion;

                    cmd.Parameters.AddWithValue("@id", cliente.Id);
                    cmd.Parameters.AddWithValue("@nombre", cliente.Nombre);
                    cmd.Parameters.AddWithValue("@apellido", cliente.Apellido);
                    cmd.Parameters.AddWithValue("@correo", cliente.Correo);
                    cmd.Parameters.AddWithValue("@telefono", cliente.Telefono);
                    cmd.Parameters.AddWithValue("@contrasena", cliente.Contrasena);
                    cmd.Parameters.AddWithValue("@estado", cliente.Estado);
                    cmd.Parameters.AddWithValue("@cedula", cliente.Cedula);

                    cmd.ExecuteNonQuery();
                    transaccion.Commit();
                }
                catch (Exception ex)
                {
                    transaccion.Rollback();
                    throw new Exception("Error al modificar el cliente: " + ex.Message, ex);
                }
            }
        }

        public void EliminarClienteBD(int id)
        {
            using (conexionRetorno = conexion.ConexionBD())
            using (var transaccion = conexionRetorno.BeginTransaction())
            {
                try
                {
                    cmd = new NpgsqlCommand("CALL clientes.Eliminar_Clientes(@id)", conexionRetorno);
                    cmd.Transaction = transaccion;

                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();
                    transaccion.Commit();
                }
                catch (Exception ex)
                {
                    transaccion.Rollback();
                    throw new Exception("Error al eliminar el cliente: " + ex.Message, ex);
                }
            }
        }

        public List<ObjCliente> ListaClientesBD()
        {
            List<ObjCliente> listaClientes = new List<ObjCliente>();
            conexionRetorno = conexion.ConexionBD();
            string query = "SELECT id, nombre, apellido, correo, telefono, contrasena, estado, cedula FROM clientes.clientes";
            cmd = new NpgsqlCommand(query, conexionRetorno);

            using (NpgsqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    ObjCliente cliente = new ObjCliente
                    {
                        Id = Convert.ToInt32(reader["id"]),
                        Nombre = reader["nombre"].ToString(),
                        Apellido = reader["apellido"].ToString(),
                        Correo = reader["correo"].ToString(),
                        Telefono = reader["telefono"].ToString(),
                        Contrasena = reader["contrasena"].ToString(),
                        Estado = Convert.ToBoolean(reader["estado"]),
                        Cedula = Convert.ToInt32(reader["cedula"])
                    };
                    listaClientes.Add(cliente);
                }
            }
            return listaClientes;
        }

        public ObjCliente BuscarClientePorId(int id)
        {
            conexionRetorno = conexion.ConexionBD();
            cmd = new NpgsqlCommand("SELECT id, nombre, apellido, correo, telefono, contrasena, estado, cedula FROM clientes.clientes WHERE id = @id", conexionRetorno);
            cmd.Parameters.AddWithValue("@id", id);

            using (NpgsqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    ObjCliente cliente = new ObjCliente
                    {
                        Id = Convert.ToInt32(reader["id"]),
                        Nombre = reader["nombre"].ToString(),
                        Apellido = reader["apellido"].ToString(),
                        Correo = reader["correo"].ToString(),
                        Telefono = reader["telefono"].ToString(),
                        Contrasena = reader["contrasena"].ToString(),
                        Estado = Convert.ToBoolean(reader["estado"]),
                        Cedula = Convert.ToInt32(reader["cedula"])
                    };
                    return cliente;
                }
            }
            return null;
        }

        public ObjCliente BuscarClientePorCedula(int cedula)
        {
            conexionRetorno = conexion.ConexionBD();
            cmd = new NpgsqlCommand("SELECT id, nombre, apellido, correo, telefono, contrasena, estado, cedula FROM clientes.clientes WHERE cedula = @cedula", conexionRetorno);
            cmd.Parameters.AddWithValue("@cedula", cedula);

            using (NpgsqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    ObjCliente cliente = new ObjCliente
                    {
                        Id = Convert.ToInt32(reader["id"]),
                        Nombre = reader["nombre"].ToString(),
                        Apellido = reader["apellido"].ToString(),
                        Correo = reader["correo"].ToString(),
                        Telefono = reader["telefono"].ToString(),
                        Contrasena = reader["contrasena"].ToString(),
                        Estado = Convert.ToBoolean(reader["estado"]),
                        Cedula = Convert.ToInt32(reader["cedula"])
                    };
                    return cliente;
                }
            }
            return null;
        }

        public object InicioSesion(string identificador, string contrasena)
        {
            object usuario = null;

            bool esCliente = char.IsDigit(identificador[0]);
            string consultaSQL;

            if (esCliente)
            {
                consultaSQL = $"SELECT id_cliente, nombre, apellido, correo, telefono, contrasena, estado, cedula FROM clientes.clientes " +
                              $"WHERE cedula = {identificador}";
            }
            else
            {
                consultaSQL = $"SELECT id_empleado, cedula, nombre, apellido, correo, telefono, contrasena, id_rol, estado, usuario FROM empleados.empleados " +
                              $"WHERE usuario = '{identificador}'";
            }

            using (NpgsqlConnection conexionActual = new ConexionSQL().ConexionBD())
            using (NpgsqlCommand cmd = new NpgsqlCommand(consultaSQL, conexionActual))
            {
                using (var dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        if (esCliente)
                        {
                            var cliente = new ObjCliente
                            {
                                Id = dr.GetInt32(0),
                                Nombre = dr.GetString(1),
                                Apellido = dr.GetString(2),
                                Correo = dr.GetString(3),
                                Telefono = dr.GetString(4),
                                Contrasena = dr.GetString(5),
                                Estado = dr.GetBoolean(6),
                                Cedula = dr.GetInt32(7)
                            };

                            usuario = cliente;
                        }
                        else
                        {
                            var empleado = new ObjEmpleado
                            {
                                Id = dr.GetInt32(0),
                                Cedula = dr.GetInt32(1),
                                Nombre = dr.GetString(2),
                                Apellido = dr.GetString(3),
                                Correo = dr.GetString(4),
                                Telefono = dr.GetInt32(5),
                                Contrasena = dr.GetString(6),
                                Id_Rol = dr.GetInt32(7),
                                Estado = dr.GetBoolean(8),
                                Usuario = dr.GetString(9)
                            };

                            usuario = empleado;
                        }
                    }
                }
            }

            return usuario;
        }
    }
}
