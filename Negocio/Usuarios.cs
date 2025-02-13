using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Using Añadidos
using Objetos;
using Conexion;

namespace Negocio
{
    public class Usuarios
    {
        BDUsuarios bdUsuarios = new BDUsuarios();

        public bool InicioSecion(ObjUsuario UsuarioDado) 
        {
            bool Comprobacion = false;

            ObjUsuario NuevoUsuario = bdUsuarios.InicioSesion(UsuarioDado);

            if (NuevoUsuario.Id != 0 && NuevoUsuario.Contraseña != null) 
            {
                Comprobacion = true;
            }

            return Comprobacion;
        }
    }
}
