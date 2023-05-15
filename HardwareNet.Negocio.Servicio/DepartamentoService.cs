using HardwareNet.Datos.Repositorio;
using HardwareNet.Entidad;
using System.Collections.Generic;

namespace HardwareNet.Negocio.Servicio
{
    public class DepartamentoService
    {
        private readonly DepartamentoRepository departamentoRepository = new DepartamentoRepository();

        public List<Municipio> ObtenerMunicipios()
        {
            return departamentoRepository.ObtenerMunicipios();
        }
    }
}
