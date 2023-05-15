using System;

namespace HardwareNet.Entidad
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public InformacionPersonal InformacionPersonal { get; set; }
        public InformacionContacto informacionContacto { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public bool Estado { get; set; } = true;
    }
}
