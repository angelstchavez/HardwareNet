using System;

namespace HardwareNet.Entidad
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public SubcategoriaProducto SubcategoriaProducto { get; set; }
        public MarcaProducto Marca { get; set; }
        public string Nombre { get; set; }
        public string NumeroReferencia { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioCosto { get; set; }
        public decimal PrecioVenta { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public bool Estado { get; set; } = true;
    }
}
