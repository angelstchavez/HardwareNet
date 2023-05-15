using HardwareNet.Datos.Repositorio;
using HardwareNet.Entidad;
using System;
using System.Collections.Generic;

namespace HardwareNet.Negocio.Servicio
{
    public class CategoriaProductoService
    {
        private readonly CategoriaProductoRepository categoriaProductoRepository = new CategoriaProductoRepository();

        public int Crear(CategoriaProducto categoriaProducto, out string mensaje)
        {
            mensaje = string.Empty;

            if (categoriaProducto == null)
            {
                mensaje = "La categoría del producto no puede ser nula.";
                return 0;
            }

            if (string.IsNullOrWhiteSpace(categoriaProducto.Nombre))
            {
                mensaje = "El nombre de la categoría es obligatorio.";
                return 0;
            }

            int idCategoria = categoriaProductoRepository.Crear(categoriaProducto, out mensaje);

            if (idCategoria > 0)
            {
                mensaje = "Categoría creada correctamente.";
            }
            else
            {
                mensaje = "No se pudo crear la categoría.";
            }

            return idCategoria;
        }

        public bool Actualizar(CategoriaProducto categoriaProducto, out string mensaje)
        {
            mensaje = string.Empty;

            if (categoriaProducto == null)
            {
                mensaje = "La categoría del producto no puede ser nula.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(categoriaProducto.Nombre))
            {
                mensaje = "El nombre de la categoría es obligatorio.";
                return false;
            }

            if (!categoriaProductoRepository.Existe(categoriaProducto.IdCategoriaProducto))
            {
                mensaje = "La categoría no existe en la base de datos.";
                return false;
            }
            
            categoriaProducto.FechaModificacion = DateTime.Now;

            bool resultado = categoriaProductoRepository.Actualizar(categoriaProducto, out mensaje);

            if (resultado)
            {
                mensaje = "Categoría de producto actualizada correctamente.";
            }
            else
            {
                mensaje = "No se pudo actualizar la categoría de producto.";
            }

            return resultado;
        }

        public bool Eliminar(CategoriaProducto categoriaProducto, out string mensaje)
        {
            mensaje = string.Empty;

            if (categoriaProducto == null)
            {
                mensaje = "La categoría del producto no puede ser nula.";
                return false;
            }

            if (!categoriaProductoRepository.Existe(categoriaProducto.IdCategoriaProducto))
            {
                mensaje = "La categoría no existe en la base de datos.";
                return false;
            }

            if (!categoriaProductoRepository.Eliminar(categoriaProducto, out mensaje))
            {
                mensaje = "No se pudo eliminar la categoría.";
                return false;
            }

            mensaje = "Categoría eliminada correctamente.";
            return true;
        }

        public List<CategoriaProducto> Crear()
        {
            return categoriaProductoRepository.ObtenerTodos();
        }
    }
}
