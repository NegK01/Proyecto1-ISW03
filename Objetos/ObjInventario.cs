using System;

namespace Objetos
{
    public class ObjInventario
    {
        public int Id { get; set; }
        public int Id_Producto { get; set; }
        public int Cantidad_Stock { get; set; }
        public DateTime Fecha_Ultima_Actualizacion { get; set; }
        public string Ubicacion { get; set; }
    }
}
