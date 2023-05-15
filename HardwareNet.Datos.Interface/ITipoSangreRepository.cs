using HardwareNet.Entidad;
using System.Collections.Generic;

namespace HardwareNet.Datos.Interface
{
    public interface ITipoSangreRepository
    {
        List<TipoSangre> ObtenerTiposSangre();
    }
}
