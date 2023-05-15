using HardwareNet.Datos.Repositorio;
using HardwareNet.Entidad;
using System.Collections.Generic;

namespace HardwareNet.Negocio.Servicio
{
    public class ProveedorService
    {
        private readonly ProveedorRepository proveedorRepository = new ProveedorRepository();

        int Crear(Proveedor proveedor, out string mensaje)
        {
            mensaje = string.Empty;

            if (proveedor == null)
            {
                mensaje = "El proveedor no puede ser nulo.";
                return 0;
            }

            if (string.IsNullOrWhiteSpace(proveedor.RazonSocial))
            {
                mensaje = "La razón social del proveedor es obligatoria.";
                return 0;
            }

            if (proveedor.TipoDocumento == null)
            {
                mensaje = "El tipo de documento del proveedor es obligatorio.";
                return 0;
            }

            if (string.IsNullOrWhiteSpace(proveedor.NumeroDocumento))
            {
                mensaje = "El número de documento del proveedor es obligatorio.";
                return 0;
            }

            if (proveedor.CategoriaProveedor == null)
            {
                mensaje = "La categoría del proveedor es obligatoria.";
                return 0;
            }

            if (proveedor.InformacionContacto == null)
            {
                mensaje = "La información de contacto del proveedor es obligatoria.";
                return 0;
            }

            int idProveedor = proveedorRepository.Crear(proveedor, out mensaje);

            if (idProveedor > 0)
            {
                mensaje = "Proveedor creado correctamente.";
            }
            else
            {
                mensaje = "No se pudo crear el proveedor.";
            }

            return idProveedor;
        }

        bool Actualizar(Proveedor proveedor, out string mensaje)
        {
            mensaje = string.Empty;

            if (proveedor == null)
            {
                mensaje = "El proveedor no puede ser nulo.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(proveedor.RazonSocial))
            {
                mensaje = "La razón social del proveedor es obligatoria.";
                return false;
            }

            if (proveedor.TipoDocumento == null)
            {
                mensaje = "El tipo de documento del proveedor es obligatorio.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(proveedor.NumeroDocumento))
            {
                mensaje = "El número de documento del proveedor es obligatorio.";
                return false;
            }

            if (proveedor.CategoriaProveedor == null)
            {
                mensaje = "La categoría del proveedor es obligatoria.";
                return false;
            }

            if (proveedor.InformacionContacto == null)
            {
                mensaje = "La información de contacto del proveedor es obligatoria.";
                return false;
            }

            if (!proveedorRepository.Existe(proveedor.IdProveedor))
            {
                mensaje = "No se pudo encontrar el proveedor.";
                return false;
            }

            bool resultado = proveedorRepository.Actualizar(proveedor, out mensaje);

            if (resultado)
            {
                mensaje = "Proveedor actualizado correctamente.";
            }
            else
            {
                mensaje = "No se pudo actualizar el proveedor.";
            }

            return resultado;
        }

        bool Eliminar(Proveedor proveedor, out string mensaje)
        {
            mensaje = string.Empty;

            if (proveedor == null)
            {
                mensaje = "El proveedor no puede ser nulo.";
                return false;
            }

            if (!proveedorRepository.Existe(proveedor.IdProveedor))
            {
                mensaje = "El proveedor no existe en la base de datos.";
                return false;
            }

            if (proveedorRepository.ValidarProductosAsociados(proveedor.IdProveedor))
            {
                mensaje = "El proveedor tiene productos asociados y no puede ser eliminado.";
                return false;
            }

            bool resultado = proveedorRepository.Eliminar(proveedor, out mensaje);

            if (resultado)
            {
                mensaje = "El proveedor fue eliminado correctamente.";
            }
            else
            {
                mensaje = "No se pudo eliminar el proveedor.";
            }

            return resultado;
        }

        public List<Proveedor> ObtenerProveedores()
        {
            return proveedorRepository.ObtenerTodos();
        }
    }
}
