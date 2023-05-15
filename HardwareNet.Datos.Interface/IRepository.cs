using System.Collections.Generic;

namespace HardwareNet.Datos.Interface
{
    public interface IRepository<T> where T : class
    {
        T ObtenerPorId(int id);
        bool Existe(int id);
        int Crear(T entidad, out string mensaje);
        bool Actualizar(T entidad, out string mensaje);
        bool Eliminar(T entidad, out string mensaje);
        List<T> ObtenerTodos();
    }
}
