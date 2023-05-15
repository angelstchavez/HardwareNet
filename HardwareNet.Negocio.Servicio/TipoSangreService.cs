using HardwareNet.Datos.Repositorio;
using HardwareNet.Entidad;
using System.Collections.Generic;

namespace HardwareNet.Negocio.Servicio
{
    public class TipoSangreService
    {
        private readonly TipoSangreRepository tipoSangreRepository = new TipoSangreRepository();
        
        public List<TipoSangre> ObtenerTiposSangre()
        {
            return tipoSangreRepository.ObtenerTiposSangre();
        }
    }
}
