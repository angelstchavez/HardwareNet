using HardwareNet.Datos.Repositorio;
using HardwareNet.Entidad;
using System.Collections.Generic;

namespace HardwareNet.Negocio.Servicio
{
    public class TipoDocumentoService
    {
        private readonly TipoDocumentoRepository tipoDocumentoRepository = new TipoDocumentoRepository();

        public List<TipoDocumento> ObtenerTiposDocumentos()
        {
            return tipoDocumentoRepository.ObtenerTiposDocumento();
        }
    }
}
