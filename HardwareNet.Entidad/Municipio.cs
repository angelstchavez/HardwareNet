using System;

namespace HardwareNet.Entidad
{
    public class Municipio
    {
        public int IdMunicipio { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaCreacion { get; set; }
        public Departamento Departamento { get; set; }
    }
}
