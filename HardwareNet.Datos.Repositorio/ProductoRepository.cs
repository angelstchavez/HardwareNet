using HardwareNet.Datos.Interface;
using HardwareNet.Entidad;
using System.Collections.Generic;

namespace HardwareNet.Datos.Repositorio
{
    public class ProductoRepository : IProductoRepository
    {
        public bool Actualizar(Producto entidad, out string mensaje)
        {
            throw new System.NotImplementedException();
        }

        public int Crear(Producto entidad, out string mensaje)
        {
            throw new System.NotImplementedException();
        }

        public bool Eliminar(Producto entidad, out string mensaje)
        {
            throw new System.NotImplementedException();
        }

        public bool Existe(int id)
        {
            throw new System.NotImplementedException();
        }

        public Producto ObtenerPorId(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Producto> ObtenerTodos()
        {
            throw new System.NotImplementedException();
        }
    }
}
