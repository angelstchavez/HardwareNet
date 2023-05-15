using HardwareNet.Entidad;
using System.Collections.Generic;
using System.Data;

namespace HardwareNet.Datos.Interface
{
    public interface ISuministroMaestroRepository
    {
        int ObtenerCorrelativo();
        List<SuministroMaestro> ObtenerSuministrosMaestros();
        bool Crear(SuministroMaestro suministroMaestro, DataTable detalleSuministro, out string mensaje);
    }
}
