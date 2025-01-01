namespace CafeSAS.Server.Models.Entities
{
    public class Producto
    {
        public Guid ID_Producto { get; set; }
        public string Nombre { get; set; }
        public string Cantidad { get; set; }
        public int PrecioCompra { get; set; }
        public int? PrecioCompraUnidad { get; set; }
        public int PrecioVenta { get; set; }
        public string? Descripcion { get; set; }
        public string? UnidadMedida { get; set; }
        public int? CantidadTotal { get; set; }
        public Categorias Categorias { get; set; }
        public Guid? ID_Categoria { get; set; }
        public string Estado { get; set; }
    }
}
