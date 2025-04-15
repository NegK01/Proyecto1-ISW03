﻿using Npgsql;
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
            obj.Id = conexion.BuscarSiguienteId("almacenes.productos");
            using (conexionRetorno = conexion.ConexionBD())
            {
                cmd = new NpgsqlCommand("INSERT INTO almacenes.productos (id, nombre, precio, caracteristicas, descripcion_producto, id_categoria, id_distribuidor, fecha_expiracion) VALUES (" +
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
                cmd = new NpgsqlCommand("UPDATE almacenes.productos SET " +
                                        "nombre = '" + obj.NombreProducto + "', " +
                                        "precio = " + obj.Precio + ", " +
                                        "caracteristicas = '" + obj.Caracteristicas + "', " +
                                        "descripcion_producto = '" + obj.DescripcionProducto + "', " +
                                        "id_categoria = " + obj.Id_Categoria + ", " +
                                        "id_distribuidor = " + obj.Id_Distribuidor + ", " +
                                        "id_estado = " + obj.Estado + ", " +
                                        "fecha_expiracion = '" + obj.FechaExpiracion.ToString("yyyy-MM-dd") + "' " +
                                        "WHERE id = " + obj.Id, conexionRetorno);

                int affectedRows = cmd.ExecuteNonQuery();
                return affectedRows > 0;
            }
        }

        public List<ObjProducto> ObtenerProductosBD(string Condicion)
        {
            List<ObjProducto> productos = new List<ObjProducto>();
            conexionRetorno = conexion.ConexionBD();
            cmd = new NpgsqlCommand("SELECT * FROM almacenes.productos " + Condicion, conexionRetorno);
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
                    Id_Descuento = dr.GetInt32(7),
                    Estado = dr.GetBoolean(8),
                    FechaExpiracion = dr.GetDateTime(9)
                };
                productos.Add(producto);
            }
            return productos;
        }
    }
}
