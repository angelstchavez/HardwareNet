using System;

namespace HardwareNet.Entidad
{
    public class CategoriaProducto
    {
        public int IdCategoriaProducto { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public bool Estado { get; set; } = true;
    }
}
