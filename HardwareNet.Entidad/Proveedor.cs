using System;

namespace HardwareNet.Entidad
{
    public class Proveedor
    {
        public int IdProveedor { get; set; }
        public string RazonSocial { get; set; }
        public CategoriaProveedor CategoriaProveedor { get; set; }
        public InformacionContacto InformacionContacto { get; set; }
        public TipoDocumento TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public bool Estado { get; set; } = true;
    }
}
