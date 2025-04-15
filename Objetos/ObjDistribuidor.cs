namespace Objetos
{
    public class ObjDistribuidor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public int Numero { get; set; }
        public bool Estado { get; set; }

        public ObjDistribuidor()
        {
            Id = 0;
            Nombre = "";
            Correo = "";
            Estado = false;
        }
    }
}
