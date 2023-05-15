using HardwareNet.Entidad;
using System.Collections.Generic;

namespace HardwareNet.Datos.Interface
{
    public interface ITipoDocumentoRepository
    {
        List<TipoDocumento> ObtenerTiposDocumento();
    }
}
