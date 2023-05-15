using HardwareNet.Datos.Repositorio;
using HardwareNet.Entidad;
using System.Collections.Generic;

namespace HardwareNet.Negocio.Servicio
{
    public class PaisService
    {
        private readonly PaisRepository paisRepository = new PaisRepository();

        public List<Departamento> ObtenerDepartamentos()
        {
            return paisRepository.ObtenerDepartamentos();
        }
    }
}
