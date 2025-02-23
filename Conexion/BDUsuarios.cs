//Using Añadidos
using Npgsql;
using Objetos;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

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

            cmd = new NpgsqlCommand("SELECT id, contrasena, id_rol FROM usuario WHERE cedula = " + NuevoUsuario.Cedula + " " +
                                    "AND contrasena = '" + NuevoUsuario.Contraseña + "' AND id_estado = 1 ",
                                    ConexionRetorno);

            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                UsuarioDado = new ObjUsuario
                {
                    Id = dr.GetInt32(0),
                    Contraseña = dr.GetString(1),
                    Rol = dr.GetInt32(2)
                };
            }

            ConexionRetorno.Close();

            return UsuarioDado;
        }

        public bool InsertarUsuario(ObjUsuario NuevoUsuario)
        {
            ConexionRetorno = conexion.ConexionBD();

            NuevoUsuario.Id = conexion.BuscarSiguienteId("usuario");

            cmd = new NpgsqlCommand("INSERT INTO usuario (id, cedula, nombre, apellido, correo, " +
                                    "telefono, direccion, contrasena, id_rol) VALUES (" +
                                    NuevoUsuario.Id + " ,  " +
                                    NuevoUsuario.Cedula + " , '" +
                                    NuevoUsuario.Nombre + "', '" +
                                    NuevoUsuario.Apellido + "', '" +
                                    NuevoUsuario.Correo + "', '" +
                                    NuevoUsuario.Telefono + "', '" +
                                    NuevoUsuario.Direccion + "', '" +
                                    NuevoUsuario.Contraseña + "',  " +
                                    NuevoUsuario.Rol + ")", ConexionRetorno);

            int affectedRows = cmd.ExecuteNonQuery();

            ConexionRetorno.Close();

            return affectedRows > 0;
        }

        public bool ModificarUsuario(ObjUsuario NuevoUsuario)
        {
            ConexionRetorno = conexion.ConexionBD();

            cmd = new NpgsqlCommand("UPDATE usuario SET " +
                                    "cedula     =  " + NuevoUsuario.Cedula + " , " +
                                    "nombre     = '" + NuevoUsuario.Nombre + "', " +
                                    "apellido   = '" + NuevoUsuario.Apellido + "', " +
                                    "correo     = '" + NuevoUsuario.Correo + "', " +
                                    "telefono   = '" + NuevoUsuario.Telefono + "', " +
                                    "direccion  = '" + NuevoUsuario.Direccion + "', " +
                                    "contrasena = '" + NuevoUsuario.Contraseña + "', " +
                                    "id_rol     =  " + NuevoUsuario.Rol + " " +
                                    "WHERE id   =  " + NuevoUsuario.Id, ConexionRetorno);

            int affectedRows = cmd.ExecuteNonQuery();

            ConexionRetorno.Close();

            return affectedRows > 0;
        }

        public List<ObjUsuario> CargarUsuarios()
        {
            ConexionRetorno = conexion.ConexionBD();

            List<ObjUsuario> ListaUsuarios = new List<ObjUsuario>();

            cmd = new NpgsqlCommand("select u.id, u.cedula, u.nombre, u.apellido," +
                                    "u.correo, u.telefono, u.direccion, u contrasena," +
                                    "u.id_rol, u.id_estado from usuario u",
                                    ConexionRetorno);

            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ObjUsuario Usuario = new ObjUsuario
                {
                    Id = dr.GetInt32(0),
                    Cedula = dr.GetInt32(1),
                    Nombre = dr.GetString(2),
                    Apellido = dr.GetString(3),
                    Correo = dr.GetString(4),
                    Telefono = dr.GetString(5),
                    Direccion = dr.GetString(6),
                    Contraseña = "",
                    Rol = dr.GetInt32(8),
                    Estado = dr.GetInt32(9)
                };
                ListaUsuarios.Add(Usuario);
            }

            ConexionRetorno.Close();

            return ListaUsuarios;
        }

        public void Reporte_2(DataGridView Tabla)
        {
            ConexionRetorno = conexion.ConexionBD();

            DataTable dataTable = new DataTable();
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(

            @"SELECT 
                CONCAT(u.nombre, ' ', u.apellido) AS ""Nombre del cliente"",
                COUNT(DISTINCT d.id_producto)     AS ""Diferentes productos comprados"",
                SUM(d.cantidad)                   AS ""Cantidad de productos vendidos"",
	            p.metodo_pago                     AS ""Metodo de pago"",
                o.monto_total                     AS ""Monto total""
            FROM 
                usuario u
            JOIN 
                orden o           ON u.id = o.id_cliente
            JOIN 
                detalle_orden d   ON o.id = d.id_orden
            JOIN
                pago p            ON o.id = p.id_orden
            JOIN
                estado e          ON e.id = o.id_estado
            WHERE
	            o.id_estado = 2
            GROUP BY 
                u.nombre, 
                u.apellido, 
                p.metodo_pago, 
                o.monto_total
            ORDER BY 
                ""Nombre del cliente"" ASC,
                ""Monto total"" DESC;", ConexionRetorno);

            adapter.Fill(dataTable);
            Tabla.DataSource = dataTable;
        }
    }
}
