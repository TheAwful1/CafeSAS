using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace CafeSAS.Server.Models.Entities
{
    public class Admin
    {
        [Key]
        public Guid ID_Admin { get; set; }

        public string Nombre { get; set; }
        public DateOnly FechaNacimiento { get; set; }
        public string Email { get; set; }
        public string Contraseña { get; set; }
        public int? Telefono { get; set; } //Acepta Nulls
        public bool Status { get; set; }


    }
}
        