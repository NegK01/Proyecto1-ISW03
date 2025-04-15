﻿using Conexion;
using Objetos;
using System;
using System.Collections.Generic;
using System.Data;

namespace Negocio
{
    public class Distribuidores
    {
        BDDistribuidores bdDistribuidor;
        ConexionSQL conexionSQL;

        public Distribuidores()
        {
            bdDistribuidor = new BDDistribuidores();
            conexionSQL = new ConexionSQL();
        }

        public bool InsertarDistribuidor(ObjDistribuidor obj)
        {
            return bdDistribuidor.InsertarDistribuidorBD(obj);
        }

        public bool ActualizarDistribuidor(ObjDistribuidor obj)
        {
            return bdDistribuidor.ActualizarDistribuidorBD(obj);
        }

        public bool EliminarDistribuidor(int id, bool estado)
        {
            if (conexionSQL.ConfirmarDuplicidad("almacenes.productos", "id_proveedor", id.ToString()))
            {
                return false;
            }
            // como el estado debe cambiar, solo enviamos el contrario con !
            return conexionSQL.CambiarEstadoCRUD(id, !estado, "almacenes", "proveedores");
        }

        public DataTable ObtenerDistribuidores()
        {
            return bdDistribuidor.ObtenerDistribuidoresBD();
        }

        public List<ObjDistribuidor> ObtenerNombresDistribuidores()
        {
            return bdDistribuidor.ObtenerNombresDistribuidoresBD();
        }

        public string BuscarNombreXId(int id)
        {
            return conexionSQL.BuscarNombreXIdBD("distribuidor", id);
        }

        public int BuscarIdXNombre(string nombre)
        {
            return conexionSQL.BuscarIdXNombreBD("distribuidor", nombre);
        }

        public int BuscarIdEstado(string Nombre)
        {
            string TablaEstado = "estado";

            return conexionSQL.BuscarIdEstado(TablaEstado, Nombre);
        }

        public string BuscarNombreEstado(int Id)
        {
            string TablaEstado = "estado";

            return conexionSQL.BuscarNombreEstado(TablaEstado, Id);
        }
    }
}
