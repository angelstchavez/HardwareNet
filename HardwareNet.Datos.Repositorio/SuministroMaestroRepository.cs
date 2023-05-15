using HardwareNet.Datos.Interface;
using HardwareNet.Entidad;
using System;
using System.Collections.Generic;
using System.Data;

namespace HardwareNet.Datos.Repositorio
{
    public class SuministroMaestroRepository : ISuministroMaestroRepository
    {
        public bool Crear(SuministroMaestro suministroMaestro, DataTable detalleSuministro, out string mensaje)
        {
            throw new NotImplementedException();
        }

        public int ObtenerCorrelativo()
        {
            throw new NotImplementedException();
        }

        public List<SuministroMaestro> ObtenerSuministrosMaestros()
        {
            throw new NotImplementedException();
        }
    }
}
