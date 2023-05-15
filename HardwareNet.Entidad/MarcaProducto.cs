using System;

namespace HardwareNet.Entidad
{
    public class MarcaProducto
    {
        public int IdMarcaProducto { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public bool Estado { get; set; } = true;
    }
}
