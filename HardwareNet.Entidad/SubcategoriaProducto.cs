using System;

namespace HardwareNet.Entidad
{
    public class SubcategoriaProducto
    {
        public int IdSubcategoriaProducto { get; set; }
        public CategoriaProducto Categoria { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public bool Estado { get; set; } = true;
    }
}
