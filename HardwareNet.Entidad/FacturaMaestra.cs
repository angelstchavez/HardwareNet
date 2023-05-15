using System.Collections.Generic;
using System;

namespace HardwareNet.Entidad
{
    public class FacturaMaestra
    {
        public int IdFacturaMaestra { get; set; }
        public List<DetalleFactura> DetalleFacturas { get; set; }
        public Empleado Empleado { get; set; }
        public Cliente Cliente { get; set; }
        public decimal MontoRecibido { get; set; }
        public decimal MontoCambio { get; set; }
        public decimal MontoTotal { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
