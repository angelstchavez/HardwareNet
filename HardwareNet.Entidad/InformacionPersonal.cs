namespace HardwareNet.Entidad
{
    public class InformacionPersonal
    {
        public int IdInformacionPersonal { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string NumeroDocumento { get; set; }
        public TipoDocumento TipoDocumento { get; set; }
        public TipoSangre TipoSangre { get; set; }
    }
}
