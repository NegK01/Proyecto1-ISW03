namespace Objetos
{
    public class ObjCategoria
    {
        public int Id { get; set; }
        public string NombreCategoria { get; set; }
        public int Id_Estado { get; set; }

        public ObjCategoria()
        {
            Id = 0;
            NombreCategoria = string.Empty;
            Id_Estado = 0;
        }
    }
}
