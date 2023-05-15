using HardwareNet.Datos.Repositorio;
using HardwareNet.Entidad;
using System;
using System.Collections.Generic;

namespace HardwareNet.Negocio.Servicio
{
    public class SubcategoriaProductoService
    {
        private readonly SubcategoriaProductoRepository subcategoriaProductoRepository = new SubcategoriaProductoRepository();

        public int Crear(SubcategoriaProducto subcategoriaProducto, out string mensaje)
        {
            mensaje = string.Empty;
            int resultado = 0;

            // Validación de la existencia de la categoría
            if (subcategoriaProducto.Categoria == null || subcategoriaProducto.Categoria.IdCategoriaProducto <= 0)
            {
                mensaje = "La subcategoría debe tener una categoría asociada";
                return resultado;
            }

            // Validación de la longitud del nombre de la subcategoría
            if (string.IsNullOrWhiteSpace(subcategoriaProducto.Nombre) || subcategoriaProducto.Nombre.Length > 50)
            {
                mensaje = "La longitud del nombre de la subcategoría debe ser entre 1 y 50 caracteres";
                return resultado;
            }

            subcategoriaProducto.FechaCreacion = DateTime.Now;
            resultado = subcategoriaProductoRepository.Crear(subcategoriaProducto, out mensaje);

            return resultado;
        }

        public bool Actualizar(SubcategoriaProducto subcategoriaProducto, out string mensaje)
        {
            mensaje = string.Empty;
            bool resultado = false;

            // Validación de la existencia de la subcategoría
            if (subcategoriaProducto.IdSubcategoriaProducto <= 0)
            {
                mensaje = "Debe seleccionar una subcategoría existente para actualizar";
                return resultado;
            }

            // Validación de la existencia de la categoría
            if (subcategoriaProducto.Categoria == null || subcategoriaProducto.Categoria.IdCategoriaProducto <= 0)
            {
                mensaje = "La subcategoría debe tener una categoría asociada";
                return resultado;
            }

            // Validación de la longitud del nombre de la subcategoría
            if (string.IsNullOrWhiteSpace(subcategoriaProducto.Nombre) || subcategoriaProducto.Nombre.Length > 50)
            {
                mensaje = "La longitud del nombre de la subcategoría debe ser entre 1 y 50 caracteres";
                return resultado;
            }

            subcategoriaProducto.FechaModificacion = DateTime.Now;
            resultado = subcategoriaProductoRepository.Actualizar(subcategoriaProducto, out mensaje);

            return resultado;
        }

        public bool Eliminar(SubcategoriaProducto subcategoriaProducto, out string mensaje)
        {
            mensaje = string.Empty;
            bool resultado = false;

            // Validación de la existencia de la subcategoría
            if (subcategoriaProducto.IdSubcategoriaProducto <= 0)
            {
                mensaje = "Debe seleccionar una subcategoría existente para eliminar";
                return resultado;
            }

            subcategoriaProducto.FechaModificacion = DateTime.Now;
            subcategoriaProducto.Estado = false;
            resultado = subcategoriaProductoRepository.Eliminar(subcategoriaProducto, out mensaje);

            return resultado;
        }

        public List<SubcategoriaProducto> ObtenerSubcategorias()
        {
            return subcategoriaProductoRepository.ObtenerTodos();
        }
    }
}
