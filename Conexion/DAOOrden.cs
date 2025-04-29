using System;
using System.Collections.Generic;
using Npgsql;
using Objetos;

namespace Datos
{
    public class DAOOrden
    {
        private NpgsqlConnection conexionRetorno;
        private NpgsqlCommand cmd;
        private Datos.ConexionSQL conexion = new Datos.ConexionSQL();

        public void InsertarOrden(ObjOrden orden)
        {
            conexionRetorno = conexion.ConexionBD();
            cmd = new NpgsqlCommand("INSERT INTO pagos.ordenes (id_cliente, fecha_orden, monto_total, id_empleado) " +
                                    "VALUES (@id_cliente, @fecha_orden, @monto_total, @id_empleado)", conexionRetorno);

            cmd.Parameters.AddWithValue("@id_cliente", orden.Id_Cliente);
            cmd.Parameters.AddWithValue("@fecha_orden", orden.Fecha_Orden);
            cmd.Parameters.AddWithValue("@monto_total", orden.Monto_Total);
            cmd.Parameters.AddWithValue("@id_empleado", orden.Id_Empleado);

            cmd.ExecuteNonQuery();
        }

        public void ModificarOrden(ObjOrden orden)
        {
            conexionRetorno = conexion.ConexionBD();
            cmd = new NpgsqlCommand("UPDATE pagos.ordenes SET id_cliente = @id_cliente, fecha_orden = @fecha_orden, monto_total = @monto_total, id_empleado = @id_empleado " +
                                    "WHERE id = @id", conexionRetorno);

            cmd.Parameters.AddWithValue("@id", orden.Id);
            cmd.Parameters.AddWithValue("@id_cliente", orden.Id_Cliente);
            cmd.Parameters.AddWithValue("@fecha_orden", orden.Fecha_Orden);
            cmd.Parameters.AddWithValue("@monto_total", orden.Monto_Total);
            cmd.Parameters.AddWithValue("@id_empleado", orden.Id_Empleado);

            cmd.ExecuteNonQuery();
        }

        public void EliminarOrden(int id)
        {
            conexionRetorno = conexion.ConexionBD();
            cmd = new NpgsqlCommand("DELETE FROM pagos.ordenes WHERE id = @id", conexionRetorno);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }

        public List<ObjOrden> ListarOrdenes()
        {
            List<ObjOrden> lista = new List<ObjOrden>();
            conexionRetorno = conexion.ConexionBD();
            cmd = new NpgsqlCommand("SELECT id, id_cliente, fecha_orden, monto_total, id_empleado FROM pagos.ordenes", conexionRetorno);

            using (NpgsqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    ObjOrden orden = new ObjOrden
                    {
                        Id = Convert.ToInt32(reader["id"]),
                        Id_Cliente = Convert.ToInt32(reader["id_cliente"]),
                        Fecha_Orden = Convert.ToDateTime(reader["fecha_orden"]),
                        Monto_Total = Convert.ToDecimal(reader["monto_total"]),
                        Id_Empleado = Convert.ToInt32(reader["id_empleado"])
                    };
                    lista.Add(orden);
                }
            }
            return lista;
        }
    }
}
