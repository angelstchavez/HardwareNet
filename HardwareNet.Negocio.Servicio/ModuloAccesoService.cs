using HardwareNet.Datos.Repositorio;
using HardwareNet.Entidad;
using System.Collections.Generic;

namespace HardwareNet.Negocio.Servicio
{
    public class ModuloAccesoService
    {
        private readonly ModuloAccesoRepository moduloAccesoRepository = new ModuloAccesoRepository();

        public List<ModuloAcceso> ObtenerModulosAcceso()
        {
            return moduloAccesoRepository.ObtenerModulosAcceso();
        }
    }
}
