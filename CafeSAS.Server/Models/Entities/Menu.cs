﻿using System.ComponentModel.DataAnnotations;

namespace CafeSAS.Server.Models.Entities
{
    public class Menu
    {
        [Key]
        public Guid ID_Menu { get; set; }
        public string Nombre { get; set; }
        public string? Descripcion { get; set; }
        public Categorias Categorias { get; set; }
        public Guid ID_Categoria { get; set; }
    }
}
