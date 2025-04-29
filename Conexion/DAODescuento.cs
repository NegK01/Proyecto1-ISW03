using System;
using System.Collections.Generic;
using Npgsql;
using Objetos;

namespace Datos
{
    public class DAODescuento
    {
        public NpgsqlCommand cmd;
        public NpgsqlConnection conexionRetorno;
        Datos.ConexionSQL conexion = new Datos.ConexionSQL();

        public void InsertarDescuentoBD(ObjDescuento descuento)
        {
            conexionRetorno = conexion.ConexionBD();
            cmd = new NpgsqlCommand("INSERT INTO pagos.descuentos (nombre, descripcion, porcentaje_de_descuento, fecha, estado) " +
                                    "VALUES (@nombre, @descripcion, @porcentaje_de_descuento, @fecha, @estado)", conexionRetorno);

            cmd.Parameters.AddWithValue("@nombre", descuento.Nombre);
            cmd.Parameters.AddWithValue("@descripcion", descuento.Descripcion);
            cmd.Parameters.AddWithValue("@porcentaje_de_descuento", descuento.Porcentaje_De_Descuento);
            cmd.Parameters.AddWithValue("@fecha", descuento.Fecha);
            cmd.Parameters.AddWithValue("@estado", descuento.Estado);

            cmd.ExecuteNonQuery();
        }

        public void ModificarDescuentoBD(ObjDescuento descuento)
        {
            conexionRetorno = conexion.ConexionBD();
            cmd = new NpgsqlCommand("UPDATE pagos.descuentos SET nombre = @nombre, descripcion = @descripcion, porcentaje_de_descuento = @porcentaje_de_descuento, fecha = @fecha, estado = @estado " +
                                    "WHERE id = @id", conexionRetorno);

            cmd.Parameters.AddWithValue("@nombre", descuento.Nombre);
            cmd.Parameters.AddWithValue("@descripcion", descuento.Descripcion);
            cmd.Parameters.AddWithValue("@porcentaje_de_descuento", descuento.Porcentaje_De_Descuento);
            cmd.Parameters.AddWithValue("@fecha", descuento.Fecha);
            cmd.Parameters.AddWithValue("@estado", descuento.Estado);
            cmd.Parameters.AddWithValue("@id", descuento.Id);

            cmd.ExecuteNonQuery();
        }

        public void EliminarDescuentoBD(int id)
        {
            conexionRetorno = conexion.ConexionBD();
            cmd = new NpgsqlCommand("DELETE FROM pagos.descuentos WHERE id = @id", conexionRetorno);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }

        public List<ObjDescuento> ListaDescuentosBD()
        {
            List<ObjDescuento> listaDescuentos = new List<ObjDescuento>();
            conexionRetorno = conexion.ConexionBD();
            string query = "SELECT id, nombre, descripcion, porcentaje_de_descuento, fecha, estado FROM pagos.descuentos";
            cmd = new NpgsqlCommand(query, conexionRetorno);

            using (NpgsqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    ObjDescuento descuento = new ObjDescuento
                    {
                        Id = Convert.ToInt32(reader["id"]),
                        Nombre = reader["nombre"].ToString(),
                        Descripcion = reader["descripcion"].ToString(),
                        Porcentaje_De_Descuento = Convert.ToInt32(reader["porcentaje_de_descuento"]),
                        Fecha = Convert.ToDateTime(reader["fecha"]),
                        Estado = Convert.ToBoolean(reader["estado"])
                    };
                    listaDescuentos.Add(descuento);
                }
            }
            return listaDescuentos;
        }
    }
}
