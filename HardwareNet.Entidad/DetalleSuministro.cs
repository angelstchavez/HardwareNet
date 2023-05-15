using System;

namespace HardwareNet.Entidad
{
    public class DetalleSuministro
    {
        public int IdDetalleSuministro { get; set; }
        public Producto Producto { get; set; }
        public decimal PrecioCosto { get; set;  }
        public decimal PrecioVenta { get; set; }
        public int Cantidad { get; set; }
        public int MontoTotal { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
