using HardwareNet.Datos.Repositorio;
using HardwareNet.Entidad;
using System;
using System.Collections.Generic;

namespace HardwareNet.Negocio.Servicio
{
    public class MarcaProductoService
    {
        private readonly MarcaProductoRepository marcaProductoRepository = new MarcaProductoRepository();

        public int Crear(MarcaProducto marca, out string mensaje)
        {
            mensaje = string.Empty;

            if (marca == null)
            {
                mensaje = "La marca del producto no puede ser nula.";
                return 0;
            }

            if (string.IsNullOrWhiteSpace(marca.Nombre))
            {
                mensaje = "El nombre de la marca es obligatorio.";
                return 0;
            }

            int idMarca = marcaProductoRepository.Crear(marca, out mensaje);

            if (idMarca > 0)
            {
                mensaje = "Empleado creado correctamente.";
            }
            else
            {
                mensaje = "No se pudo crear el empleado.";
            }

            return idMarca;
        }

        public bool Actualizar(MarcaProducto marca, out string mensaje)
        {

            mensaje = string.Empty;

            if (marca == null)
            {
                mensaje = "La marca del producto no puede ser nula.";
                return false;
            }

            var marcaExistente = marcaProductoRepository.ObtenerPorId(marca.IdMarcaProducto);
            if (marcaExistente == null)
            {
                mensaje = "La marca del producto no existe en la base de datos.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(marca.Nombre))
            {
                mensaje = "El nombre de la marca es obligatorio.";
                return false;
            }

            marca.FechaModificacion = DateTime.Now;

            return marcaProductoRepository.Actualizar(marca, out mensaje);
        }

        public bool Eliminar(MarcaProducto marca, out string mensaje)
        {
            mensaje = string.Empty;

            if (marca == null)
            {
                mensaje = "La marca del producto no puede ser nula.";
                return false;
            }

            var marcaExistente = marcaProductoRepository.ObtenerPorId(marca.IdMarcaProducto);
            if (marcaExistente == null)
            {
                mensaje = "La marca del producto no existe en la base de datos.";
                return false;
            }

            marcaExistente.Estado = false;

            return marcaProductoRepository.Eliminar(marcaExistente, out mensaje);
        }

        public List<MarcaProducto> ObtenerMarcas()
        {
            return marcaProductoRepository.ObtenerTodos();
        }
    }
}
