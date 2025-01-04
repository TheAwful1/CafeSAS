using System.ComponentModel.DataAnnotations;

namespace CafeSAS.Server.Models.Entities
{
    public class Empleado
    {
        [Key]
        public Guid ID_Empleado { get; set; }
        public string Nombre { get; set; }
        public string Username { get; set; }
        public string Contraseña { get; set; }
        public string Correo { get; set;    }
        public int Telefono { get; set; }
        public DateOnly FechaNacimiento { get; set; }
        public DateTime Hiredate { get; set; }
        public int Salario { get; set; }

        public ICollection<Sesion> Sesions { get; set; } = new List<Sesion>();
        public ICollection<Ventas> Ventas { get; set; } = new List<Ventas>();
    }
}
