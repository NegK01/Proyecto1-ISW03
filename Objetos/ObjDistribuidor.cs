namespace Objetos
{
    public class ObjDistribuidor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Contacto { get; set; }
        public int Id_Estado { get; set; }

        public ObjDistribuidor()
        {
            Id = 0;
            Nombre = "";
            Contacto = "";
            Id_Estado = 0;
        }
    }
}
