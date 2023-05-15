using HardwareNet.Entidad;

namespace HardwareNet.Datos.Interface
{
    public interface IProveedorRepository : IRepository<Proveedor>
    {
        bool ValidarCorreoElectronico(string correoElectronico);
        bool ValidarProductosAsociados(int IdProveedor);
    }
}
