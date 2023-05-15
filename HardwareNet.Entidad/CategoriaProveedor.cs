using System;

namespace HardwareNet.Entidad
{
    public class CategoriaProveedor
    {
        public int IdCategoriaProveedor { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public bool Estado { get; set; } = true;
    }
}
