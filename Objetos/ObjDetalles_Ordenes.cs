namespace Objetos
{
    public class ObjDetalles_Ordenes
    {
        public int Id { get; set; }
        public int Id_Orden { get; set; }
        public int Id_Producto { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio_Unitario { get; set; }
        public decimal Descuento { get; set; }
        public decimal Subtotal { get; set; }
    }
}
