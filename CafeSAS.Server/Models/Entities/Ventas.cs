namespace CafeSAS.Server.Models.Entities
{
    public class Ventas
    {
        public Guid ID_Ventas { get; set; }
        public int Monto { get; set; }
        public DateOnly Fecha { get; set; }
        public TimeOnly Hora { get; set; }


        public Empleado Empleado { get; set; }
        public Guid ID_Empleado { get; set; }

        public ICollection<Detalle_Venta> Detalle_Ventas { get; set; } = new List<Detalle_Venta>();
    }
}
