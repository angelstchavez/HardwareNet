using HardwareNet.Entidad;

namespace HardwareNet.Datos.Interface
{
    public interface ICategoriaProveedor : IRepository<CategoriaProveedor>
    {
       bool ExisteProveedorRelacionado(int IdProveedor);
    }
}
