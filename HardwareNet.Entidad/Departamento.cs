using System;

namespace HardwareNet.Entidad
{
    public class Departamento
    {
        public int IdDepartamento { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaCreacion { get; set; }
        public Pais Pais { get; set; }
    }
}
