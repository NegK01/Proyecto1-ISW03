using Npgsql;
using Objetos;
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
                cmd = new NpgsqlCommand("INSERT INTO almacenes.proveedores (id, nombre, info_contacto) VALUES (" +
                                        obj.Id + ", '" +
                                        obj.Nombre + "', '" +
                                        obj.Contacto + "')", conexionRetorno);
                int affectedRows = cmd.ExecuteNonQuery();
                return affectedRows > 0;
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
                cmd = new NpgsqlCommand("UPDATE almacenes.proveedores SET " +
                                        "nombre = '" + obj.Nombre + "', " +
                                        "info_contacto = '" + obj.Contacto + "' " +
                                        "WHERE id = " + obj.Id, conexionRetorno);
                int affectedRows = cmd.ExecuteNonQuery();
                return affectedRows > 0;
            }
        }

        public List<ObjDistribuidor> ObtenerDistribuidoresBD()
        {
            List<ObjDistribuidor> distribuidores = new List<ObjDistribuidor>();
            conexionRetorno = conexion.ConexionBD();
            cmd = new NpgsqlCommand("SELECT id, nombre, correo_contacto, numero_contacto, estado FROM almacenes.proveedores", conexionRetorno);
            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ObjDistribuidor distribuidor = new ObjDistribuidor
                {
                    Id = dr.GetInt32(0),
                    Nombre = dr.GetString(1),
                    Contacto = dr.GetString(2),
                    Numero = dr.GetInt32(3),
                    Estado = dr.GetBoolean(4)
                };
                distribuidores.Add(distribuidor);
            }

            conexionRetorno.Close();
            return distribuidores;
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
