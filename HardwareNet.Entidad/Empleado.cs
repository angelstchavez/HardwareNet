using System;

namespace HardwareNet.Entidad
{
    public class Empleado
    {
        public int IdEmpleado { get; set; }
        public RolEmpleado RolEmpleado { get; set; }
        public InformacionPersonal InformacionPersonal { get; set; }
        public InformacionContacto InformacionContacto { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public bool Estado { get; set; } = true;
    }
}
