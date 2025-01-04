using System.ComponentModel.DataAnnotations;

namespace CafeSAS.Server.Models.Entities
{
    public class Categorias
    {
        [Key]
        public Guid ID_Categoria { get; set; }
        public string Nombre { get; set; }
        public string? Descripcion { get; set; }

        public ICollection<Menu> Menus { get; set; } = new List<Menu>();


    }
}
