using System;

namespace HardwareNet.Entidad
{
    public class DetalleFactura
    {
        public int IdDetalleFactura { get; set; }
        public Producto Producto { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Cantidad { get; set; }
        public decimal SubTotal { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
