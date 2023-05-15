using HardwareNet.Entidad;

namespace HardwareNet.Datos.Interface
{
    public interface IEmpleadoRepository : IRepository<Empleado>
    {
        bool ValidarCorreoElectronico(string correoElectronico);
    }
}
