using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using Datos;
using Objetos;

namespace Negocio
{
    public class BOCliente
    {
        DAOCliente daoCliente = new DAOCliente();

        public void InsertarCliente(ObjCliente cliente)
        {
            try
            {
                daoCliente.InsertarClienteBD(cliente);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar el cliente: " + ex.Message);
            }
        }

        public void ModificarCliente(ObjCliente cliente)
        {
            try
            {
                daoCliente.ModificarClienteBD(cliente);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar el cliente: " + ex.Message);
            }
        }

        public void EliminarCliente(int id)
        {
            try
            {
                daoCliente.EliminarClienteBD(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el cliente: " + ex.Message);
            }
        }

        public List<ObjCliente> ObtenerListaClientes()
        {
            try
            {
                return daoCliente.ListaClientesBD();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la lista de clientes: " + ex.Message);
            }
        }

        public ObjCliente BuscarClientePorId(int id)
        {
            try
            {
                return daoCliente.BuscarClientePorId(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar cliente por ID: " + ex.Message);
            }
        }

        public ObjCliente BuscarClientePorCedula(int cedula)
        {
            try
            {
                return daoCliente.BuscarClientePorCedula(cedula);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar cliente por cédula: " + ex.Message);
            }
        }

        public ObjCliente InicioSesion(ObjCliente NuevoUsuario)
        {
            object usuarioEncontrado = daoCliente.InicioSesion(NuevoUsuario.Id.ToString(), NuevoUsuario.Contrasena);
            if (usuarioEncontrado is ObjCliente cliente && cliente.Id != 0 && !string.IsNullOrEmpty(cliente.Contrasena))
            {
                return cliente;
            }

            ObjCliente usuarioVacio = new ObjCliente
            {
                Id = 1
            };
            return usuarioVacio;
        }

        public string EncriptarMD5(string Contraseña)
        {
            MD5 md5 = MD5.Create();

            byte[] inputBytes = Encoding.UTF8.GetBytes(Contraseña);
            byte[] hashBytes = md5.ComputeHash(inputBytes);

            StringBuilder ContraEncryptada = new StringBuilder();

            for (int i = 0; i < hashBytes.Length; i++)
            {
                ContraEncryptada.Append(hashBytes[i].ToString("x2"));
            }

            return ContraEncryptada.ToString();
        }
    }
}
