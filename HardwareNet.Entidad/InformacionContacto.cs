namespace HardwareNet.Entidad
{
    public class InformacionContacto
    {
        public int IdInformacionContacto { get; set; }
        public string CorreoElectronico { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public Municipio Municipio { get; set; }
    }
}