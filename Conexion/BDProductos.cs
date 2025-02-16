using Npgsql;
using Objetos;
using System.Collections.Generic;

namespace Conexion
{
    public class BDProductos
    {
        public NpgsqlConnection conexionRetorno;
        public NpgsqlCommand cmd;
        ConexionSQL conexion;

        public BDProductos()
        {
            conexion = new ConexionSQL();
        }

        public bool InsertarProductoBD(ObjProducto obj)
        {
            obj.Id = conexion.BuscarSiguienteId("producto");
            using (conexionRetorno = conexion.ConexionBD())
            {
                cmd = new NpgsqlCommand("INSERT INTO producto (id, nombre, precio, caracteristicas, descripcion_producto, id_categoria, id_distribuidor, fecha_expiracion) VALUES (" +
                                        obj.Id + ", '" +
                                        obj.NombreProducto + "', " +
                                        obj.Precio + ", '" +
                                        obj.Caracteristicas + "', '" +
                                        obj.DescripcionProducto + "', " +
                                        obj.Id_Categoria + ", " +
                                        obj.Id_Distribuidor + ", '" +
                                        obj.FechaExpiracion.ToString("yyyy-MM-dd") + "')", conexionRetorno);


                int affectedRows = cmd.ExecuteNonQuery();
                return affectedRows > 0;
            }
        }

        public bool ActualizarProductoBD(ObjProducto obj)
        {
            using (conexionRetorno = conexion.ConexionBD())
            {
                cmd = new NpgsqlCommand("UPDATE producto SET " +
                                        "nombre = '" + obj.NombreProducto + "', " +
                                        "precio = " + obj.Precio + ", " +
                                        "caracteristicas = '" + obj.Caracteristicas + "', " +
                                        "descripcion_producto = '" + obj.DescripcionProducto + "', " +
                                        "id_categoria = " + obj.Id_Categoria + ", " +
                                        "id_distribuidor = " + obj.Id_Distribuidor + ", " +
                                        "id_estado = " + obj.Id_Estado + ", " +
                                        "fecha_expiracion = '" + obj.FechaExpiracion.ToString("yyyy-MM-dd") + "' " +
                                        "WHERE id = " + obj.Id, conexionRetorno);

                int affectedRows = cmd.ExecuteNonQuery();
                return affectedRows > 0;
            }
        }

        public List<ObjProducto> ObtenerProductosBD()
        {
            List<ObjProducto> productos = new List<ObjProducto>();
            conexionRetorno = conexion.ConexionBD();
            cmd = new NpgsqlCommand("SELECT * FROM producto", conexionRetorno);
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ObjProducto producto = new ObjProducto
                {
                    Id = dr.GetInt32(0),
                    NombreProducto = dr.GetString(1),
                    Precio = dr.GetDecimal(2),
                    Caracteristicas = !dr.IsDBNull(3) ? dr.GetString(3) : "Sin Caracteristicas.",
                    DescripcionProducto = !dr.IsDBNull(4) ? dr.GetString(4) : "Sin Descripción.",
                    Id_Categoria = dr.GetInt32(5),
                    Id_Distribuidor = dr.GetInt32(6),
                    Id_Estado = dr.GetInt32(7),
                    FechaExpiracion = dr.GetDateTime(8)
                };
                productos.Add(producto);
            }
            return productos;
        }
    }
}
