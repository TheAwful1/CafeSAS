namespace CafeSAS.Server.Models.Entities
{
    public class Inventario
    {
        public ICollection<Empleado> Empleados { get; set; } = new List<Empleado>();
        public Guid ID_Empleado { get; set; }
        public bool Permiso { get; set; }

        public Tienda Tienda { get; set; }
        public Guid ID_Tienda { get; set; }
    }
}
