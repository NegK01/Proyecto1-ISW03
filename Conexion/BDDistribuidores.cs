using Npgsql;
using Objetos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Conexion
{
    public class BDDistribuidores
    {
        public NpgsqlConnection conexionRetorno;
        public NpgsqlCommand cmd;
        ConexionSQL conexion;

        public BDDistribuidores()
        {
            conexion = new ConexionSQL();
        }

        public bool InsertarDistribuidorBD(ObjDistribuidor obj)
        {
            if (conexion.ConfirmarDuplicidad("almacenes.proveedores", "nombre", obj.Nombre))
            {
                return false;
            }

            obj.Id = conexion.BuscarSiguienteId("almacenes.proveedores");

            using (conexionRetorno = conexion.ConexionBD())
            {
                try
                {
                    cmd = new NpgsqlCommand(
                        $"SELECT almacenes.insertar_proveedores({obj.Id}, '{obj.Nombre}', '{obj.Correo}', {obj.Numero}, true)",
                        conexionRetorno);
                    cmd.ExecuteNonQuery();
                    conexion.Transaccion.Commit();
                    return true;
                }
                catch
                {
                    conexion.Transaccion.Rollback();
                    return false;
                }
            }
        }

        public bool ActualizarDistribuidorBD(ObjDistribuidor obj)
        {
            if (conexion.ConfirmarDuplicidad("almacenes.proveedores", "nombre", obj.Nombre, obj.Id))
            {
                return false;
            }

            using (conexionRetorno = conexion.ConexionBD())
            {
                try
                {
                    cmd = new NpgsqlCommand(
                        $"SELECT almacenes.modificar_proveedores({obj.Id}, '{obj.Nombre}', '{obj.Correo}', {obj.Numero})",
                        conexionRetorno);
                    cmd.ExecuteNonQuery();
                    conexion.Transaccion.Commit();
                    return true;
                }
                catch
                {
                    conexion.Transaccion.Rollback();
                    return false;
                }
            }
        }

        public DataTable ObtenerDistribuidoresBD()
        {
            DataTable dt = new DataTable();

            try
            {
                using (var conexionRetorno = conexion.ConexionBD())
                {
                    string query = "SELECT id, nombre, correo_contacto, numero_contacto, estado FROM almacenes.proveedores";

                    using (var cmd = new NpgsqlCommand(query, conexionRetorno))
                    {
                        using (var da = new NpgsqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar los datos: " + ex.Message);
            }

            return dt;
        }

        public List<ObjDistribuidor> ObtenerNombresDistribuidoresBD()
        {
            List<ObjDistribuidor> distribuidores = new List<ObjDistribuidor>();
            conexionRetorno = conexion.ConexionBD();
            cmd = new NpgsqlCommand("SELECT nombre FROM almacenes.proveedores where estado = true", conexionRetorno);
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ObjDistribuidor distribuidor = new ObjDistribuidor
                {
                    Nombre = dr.GetString(0)
                };
                distribuidores.Add(distribuidor);
            }
            conexionRetorno.Close();
            return distribuidores;
        }

        public void Reporte_3(DataGridView Tabla)
        {
            conexionRetorno = conexion.ConexionBD();

            DataTable dataTable = new DataTable();
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(

            @"SELECT 
                di.nombre                      AS ""Nombre de distribuidor"",
                p.nombre                       AS ""Nombre del producto mas vendido"",
                SUM(dt.cantidad)               AS ""Cantidad de productos vendidos"" 
            FROM distribuidor di
            JOIN
                producto p        ON di.id = p.id_distribuidor
            JOIN 
                detalle_orden dt   ON p.id = dt.id_producto
            JOIN 
                orden o           ON dt.id_orden = o.id
            JOIN
                pago pa           ON o.id = pa.id_orden
            GROUP BY 
                p.nombre, 
	            di.nombre
            ORDER BY 
                ""Cantidad de productos vendidos""  DESC;", conexionRetorno);

            adapter.Fill(dataTable);
            Tabla.DataSource = dataTable;
        }
    }
}
