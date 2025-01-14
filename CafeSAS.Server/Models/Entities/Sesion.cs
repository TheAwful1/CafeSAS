﻿using System.ComponentModel.DataAnnotations;

namespace CafeSAS.Server.Models.Entities
{
    public class Sesion
    {
        [Key]
        public Guid ID_Sesion { get; set; }
        public DateTime Fecha { get; set; }

        public TimeSpan HoraEntrada { get; set; }

        public TimeSpan HoraBreak{ get; set; }
        public TimeSpan HoraSalidaBreak { get; set; }

        public TimeSpan HoraSalida { get; set; }

        public int HorasTotales { get; set; }

        public Guid ID_Empleado { get; set; }
        public ICollection<Empleado> Empleados { get; set; } = new List<Empleado>();
    }
}
