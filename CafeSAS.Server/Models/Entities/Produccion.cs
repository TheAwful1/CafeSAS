namespace CafeSAS.Server.Models.Entities
{
    public class Produccion
    {
        public ICollection<Empleado> Empleados { get; set; } = new List<Empleado>();
        public Guid ID_Empleado { get; set; }
        public bool Permiso { get; set; }
        
    }
}
