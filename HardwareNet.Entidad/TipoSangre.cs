using System;

namespace HardwareNet.Entidad
{
    public class TipoSangre
    {
        public int IdTipoSangre { get; set; }
        public string GrupoSanguineo { get; set; }
        public string FactorRh { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
