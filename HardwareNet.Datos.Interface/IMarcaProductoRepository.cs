using HardwareNet.Entidad;

namespace HardwareNet.Datos.Interface
{
    public interface IMarcaProductoRepository : IRepository<MarcaProducto>
    {
        bool ValidarCompraEmpleado();
    }
}
