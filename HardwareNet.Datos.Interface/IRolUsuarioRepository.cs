using HardwareNet.Entidad;
using System.Collections.Generic;

namespace HardwareNet.Datos.Interface
{
    public interface IRolUsuarioRepository
    {
        List<RolEmpleado> ObtenerRolesUsuario();
    }
}
