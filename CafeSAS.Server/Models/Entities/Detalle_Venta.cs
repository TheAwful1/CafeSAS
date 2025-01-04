using System.ComponentModel.DataAnnotations;

namespace CafeSAS.Server.Models.Entities
{
    public class Detalle_Venta
    {


        [Key]
        public Guid ID_DetalleVenta { get; set; }        
        public int Cantidad { get; set; }
        public int SubTotal { get; set; }

        public Ventas Ventas { get; set; }
        public Guid ID_Venta { get; set; }

        public Producto Producto { get; set; }
        public Guid ID_Producto { get; set; }
    }
}
