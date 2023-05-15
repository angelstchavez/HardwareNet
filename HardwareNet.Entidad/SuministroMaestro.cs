using System;
using System.Collections.Generic;

namespace HardwareNet.Entidad
{
    public class SuministroMaestro
    {
        public int IdSuministroMaestro { get; set; }
        public List<DetalleSuministro> DetalleSuministros { get; set; }
        public Empleado Empleado { get; set; }
        public Proveedor Proveedor { get; set; }
        public decimal MontoTotal { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
