using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace CafeSAS.Server.Models.Entities
{
    [Keyless]
    public class Caja
    {
        

        public ICollection<Empleado> Empleados { get; set; } = new List<Empleado>();
        public Guid ID_Empleado { get; set; }
        public bool Permiso { get; set; }
        public ICollection<Ventas> Ventas { get; set; } = new List<Ventas>();
        
        public Tienda Tienda { get; set; }
        public Guid ID_Tienda { get; set; }
    }
}
