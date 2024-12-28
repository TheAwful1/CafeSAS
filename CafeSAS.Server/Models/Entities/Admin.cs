namespace CafeSAS.Server.Models.Entities
{
    public class Admin
    {
        public int Id_Admin { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Email { get; set; }
        public string Contraseña { get; set; }
        public int Telefono { get; set; }
        public bool Status { get; set; }
    }
}
