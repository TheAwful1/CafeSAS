namespace CafeSAS.Server.Models.Entities
{
    public class Sesion
    {
        public int ID_Empleado { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan HoraEntrada { get; set; }
        public TimeSpan HoraSalida { get; set; }
        public int HorasTotales { get; set; }
        public Empleado Empleado { get; set; }
    }
}
