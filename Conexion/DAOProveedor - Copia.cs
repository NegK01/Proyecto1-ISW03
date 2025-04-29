using System;
using System.Collections.Generic;
using Objetos;
using Npgsql;

namespace Datos
{
    public class DAOProveedor
    {
        public NpgsqlCommand cmd;
        public NpgsqlConnection conexionRetorno;
        Datos.ConexionSQL conexion = new Datos.ConexionSQL();

        public void InsertarProveedorBD(ObjProveedor proveedor)
        {
            conexionRetorno = conexion.ConexionBD();
            cmd = new NpgsqlCommand("INSERT INTO almacenes.proveedores (nombre, correo_contacto, estado, numero_contacto) " +
                                    "VALUES (@nombre, @correo_contacto, @estado, @numero_contacto)", conexionRetorno);

            cmd.Parameters.AddWithValue("@nombre", proveedor.Nombre);
            cmd.Parameters.AddWithValue("@correo_contacto", proveedor.Correo_Contacto);
            cmd.Parameters.AddWithValue("@estado", proveedor.Estado);
            cmd.Parameters.AddWithValue("@numero_contacto", proveedor.Numero_Contacto);

            cmd.ExecuteNonQuery();
        }

        public void ModificarProveedorBD(ObjProveedor proveedor)
        {
            conexionRetorno = conexion.ConexionBD();
            cmd = new NpgsqlCommand("UPDATE almacenes.proveedores SET nombre = @nombre, correo_contacto = @correo_contacto, estado = @estado, numero_contacto = @numero_contacto " +
                                    "WHERE id = @id", conexionRetorno);

            cmd.Parameters.AddWithValue("@nombre", proveedor.Nombre);
            cmd.Parameters.AddWithValue("@correo_contacto", proveedor.Correo_Contacto);
            cmd.Parameters.AddWithValue("@estado", proveedor.Estado);
            cmd.Parameters.AddWithValue("@numero_contacto", proveedor.Numero_Contacto);
            cmd.Parameters.AddWithValue("@id", proveedor.Id);

            cmd.ExecuteNonQuery();
        }

        public void EliminarProveedorBD(int id)
        {
            conexionRetorno = conexion.ConexionBD();
            cmd = new NpgsqlCommand("DELETE FROM almacenes.proveedores WHERE id = @id", conexionRetorno);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }

        public List<ObjProveedor> ListaProveedoresBD()
        {
            List<ObjProveedor> listaProveedores = new List<ObjProveedor>();
            conexionRetorno = conexion.ConexionBD();
            string query = "SELECT id, nombre, correo_contacto, estado, numero_contacto FROM almacenes.proveedores";
            cmd = new NpgsqlCommand(query, conexionRetorno);

            using (NpgsqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    ObjProveedor proveedor = new ObjProveedor
                    {
                        Id = Convert.ToInt32(reader["id"]),
                        Nombre = reader["nombre"].ToString(),
                        Correo_Contacto = reader["correo_contacto"].ToString(),
                        Estado = Convert.ToBoolean(reader["estado"]),
                        Numero_Contacto = Convert.ToInt32(reader["numero_contacto"])
                    };
                    listaProveedores.Add(proveedor);
                }
            }
            return listaProveedores;
        }
    }
}
