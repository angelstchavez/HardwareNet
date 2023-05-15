using System;

namespace HardwareNet.Entidad
{
    public class ModuloAcceso
    {
        public int IdModuloAcceso { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public bool Estado { get; set; } = true;
        public RolEmpleado RolUsuario { get; set; }
    }
}
