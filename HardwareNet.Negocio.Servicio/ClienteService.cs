using HardwareNet.Datos.Repositorio;
using HardwareNet.Entidad;
using System;
using System.Collections.Generic;

namespace HardwareNet.Negocio.Servicio
{
    public class ClienteService
    {
        private readonly ClienteRepository clienteRepository = new ClienteRepository();

        public int Crear(Cliente cliente, out string mensaje)
        {
            mensaje = string.Empty;

            if (cliente == null)
            {
                mensaje = "El cliente no puede ser nulo";
                return 0;
            }

            if (string.IsNullOrWhiteSpace(cliente.InformacionPersonal.PrimerNombre))
            {
                mensaje = "El primer nombre del cliente no puede ser vacío o nulo";
                return 0;
            }

            if (string.IsNullOrWhiteSpace(cliente.InformacionPersonal.PrimerApellido))
            {
                mensaje = "El primer apellido del cliente no puede ser vacío o nulo";
                return 0;
            }

            if (cliente.InformacionPersonal.TipoDocumento == null)
            {
                mensaje = "El tipo de documento del cliente no puede ser nulo";
                return 0;
            }

            if (string.IsNullOrWhiteSpace(cliente.InformacionPersonal.NumeroDocumento))
            {
                mensaje = "El número de documento del cliente no puede ser vacío o nulo";
                return 0;
            }

            if (cliente.informacionContacto == null)
            {
                mensaje = "La información de contacto del cliente no puede ser nula";
                return 0;
            }

            if (string.IsNullOrWhiteSpace(cliente.informacionContacto.CorreoElectronico))
            {
                mensaje = "El correo electrónico del cliente no puede ser vacío o nulo";
                return 0;
            }

            // Validar correo electrónico
            if (!clienteRepository.ValidarCorreoElectronico(cliente.informacionContacto.CorreoElectronico))
            {
                mensaje = "El correo electrónico ingresado no es válido";
                return 0;
            }

            if (string.IsNullOrWhiteSpace(cliente.informacionContacto.Telefono) && string.IsNullOrWhiteSpace(cliente.informacionContacto.Celular))
            {
                mensaje = "Al menos un número de teléfono o celular del cliente debe ser proporcionado";
                return 0;
            }

            if (cliente.informacionContacto.Municipio == null)
            {
                mensaje = "El municipio del cliente no puede ser nulo";
                return 0;
            }

            return clienteRepository.Crear(cliente, out mensaje);
        }

        public bool Actualizar(Cliente cliente, out string mensaje)
        {
            mensaje = string.Empty;

            if (cliente == null)
            {
                mensaje = "El cliente a actualizar no puede ser nulo";
                return false;
            }

            if (cliente.InformacionPersonal == null)
            {
                mensaje = "La información personal del cliente es obligatoria";
                return false;
            }

            if (string.IsNullOrEmpty(cliente.InformacionPersonal.PrimerNombre))
            {
                mensaje = "El primer nombre del cliente es obligatorio";
                return false;
            }

            if (string.IsNullOrEmpty(cliente.InformacionPersonal.PrimerApellido))
            {
                mensaje = "El primer apellido del cliente es obligatorio";
                return false;
            }

            if (string.IsNullOrEmpty(cliente.InformacionPersonal.NumeroDocumento))
            {
                mensaje = "El número de documento del cliente es obligatorio";
                return false;
            }

            if (cliente.InformacionPersonal.TipoDocumento == null)
            {
                mensaje = "El tipo de documento del cliente es obligatorio";
                return false;
            }

            if (cliente.informacionContacto == null)
            {
                mensaje = "La información de contacto del cliente es obligatoria";
                return false;
            }

            if (string.IsNullOrEmpty(cliente.informacionContacto.CorreoElectronico))
            {
                mensaje = "El correo electrónico del cliente es obligatorio";
                return false;
            }

            // Validar correo electrónico
            if (!clienteRepository.ValidarCorreoElectronico(cliente.informacionContacto.CorreoElectronico))
            {
                mensaje = "El correo electrónico ingresado no es válido";
                return false;
            }

            if (string.IsNullOrEmpty(cliente.informacionContacto.Direccion))
            {
                mensaje = "La dirección del cliente es obligatoria";
                return false;
            }

            if (cliente.informacionContacto.Municipio == null)
            {
                mensaje = "El municipio del cliente es obligatorio";
                return false;
            }

            cliente.FechaModificacion = DateTime.Now;
            return clienteRepository.Actualizar(cliente, out mensaje);
        }

        public bool Eliminar(Cliente cliente, out string mensaje)
        {
            mensaje = string.Empty;

            if (cliente == null)
            {
                mensaje = "El cliente no puede ser nulo.";
                return false;
            }

            if (cliente.IdCliente <= 0)
            {
                mensaje = "El ID del cliente no es válido.";
                return false;
            }


            // Verificar que el cliente no tenga facturas relacionadas
            if (clienteRepository.ExisteFacturaRelacionada(cliente.IdCliente))
            {
                mensaje = "El cliente no se puede eliminar porque tiene facturas relacionadas.";
                return false;
            }

            // Cambiar el estado del cliente a inactivo en lugar de borrarlo definitivamente
            cliente.Estado = false;
            cliente.FechaModificacion = DateTime.Now;

            return clienteRepository.Actualizar(cliente, out mensaje);
        }

        public List<Cliente> ObtenerClientes()
        {
            return clienteRepository.ObtenerTodos();
        }
    }
}
