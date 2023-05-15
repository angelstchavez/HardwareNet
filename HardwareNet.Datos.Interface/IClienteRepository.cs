using HardwareNet.Entidad;

namespace HardwareNet.Datos.Interface
{
    public interface IClienteRepository : IRepository<Cliente>
    {
        bool ValidarCorreoElectronico(string correoElectronico);
        bool ExisteFacturaRelacionada(int IdCliente);
    }
}
