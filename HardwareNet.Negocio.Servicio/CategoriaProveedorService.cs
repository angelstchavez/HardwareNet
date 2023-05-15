using HardwareNet.Datos.Repositorio;
using HardwareNet.Entidad;
using System.Collections.Generic;
using System;

namespace HardwareNet.Negocio.Servicio
{
    public class CategoriaProveedorService
    {
        private readonly CategoriaProveedorRepository categoriaProveedorRepository = new CategoriaProveedorRepository();

        public int Crear(CategoriaProveedor categoriaProveedor, out string mensaje)
        {
            mensaje = string.Empty;

            if (string.IsNullOrWhiteSpace(categoriaProveedor.Nombre))
            {
                mensaje = "El nombre de la categoría no puede estar vacío.";
                return 0;
            }

            // Validar que no exista otra categoría con el mismo nombre
            if (categoriaProveedorRepository.Existe(categoriaProveedor.IdCategoriaProveedor))
            {
                mensaje = "Ya existe una categoría con el mismo nombre.";
                return 0;
            }

            // Asignar la fecha de creación y el estado por defecto
            categoriaProveedor.FechaCreacion = DateTime.Now;
            categoriaProveedor.Estado = true;

            return categoriaProveedorRepository.Crear(categoriaProveedor, out mensaje);
        }

        public bool Actualizar(CategoriaProveedor categoriaProveedor, out string mensaje)
        {
            mensaje = string.Empty;

            if (string.IsNullOrWhiteSpace(categoriaProveedor.Nombre))
            {
                mensaje = "El nombre de la categoría no puede estar vacío.";
                return false;
            }

            // Validar que no exista otra categoría con el mismo nombre
            if (categoriaProveedorRepository.Existe(categoriaProveedor.IdCategoriaProveedor))
            {
                mensaje = "Ya existe una categoría con el mismo nombre.";
                return false;
            }

            // Asignar la fecha de modificación
            categoriaProveedor.FechaModificacion = DateTime.Now;

            return categoriaProveedorRepository.Actualizar(categoriaProveedor, out mensaje);
        }

        public bool Eliminar(CategoriaProveedor categoriaProveedor, out string mensaje)
        {
            mensaje = string.Empty;

            // Verificar que no existan proveedores asociados a esta categoría
            if (categoriaProveedorRepository.ExisteProveedorRelacionado(categoriaProveedor.IdCategoriaProveedor))
            {
                mensaje = "No se puede eliminar la categoría porque existen proveedores asociados.";
                return false;
            }

            // Actualizar el estado de la categoría a inactivo
            categoriaProveedor.Estado = false;
            categoriaProveedor.FechaModificacion = DateTime.Now;

            return categoriaProveedorRepository.Eliminar(categoriaProveedor, out mensaje);
        }

        public List<CategoriaProveedor> ObtenerTodos()
        {
            return categoriaProveedorRepository.ObtenerTodos();
        }
    }
}
