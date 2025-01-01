namespace CafeSAS.Server.Models.Entities
{
    public class Tienda
    {
        public Guid ID_Tienda { get; set; }

        public Admin Admin { get; set; }
        public Guid ID_Admin { get; set; }
        
        public ICollection<Empleado> Empleados { get; set; } = new List<Empleado>();
        public Guid ID_Empleado { get; set; }
    }
}
