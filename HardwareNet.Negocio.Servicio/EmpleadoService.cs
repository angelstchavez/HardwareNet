using HardwareNet.Datos.Repositorio;
using HardwareNet.Entidad;
using System;
using System.Collections.Generic;

namespace HardwareNet.Negocio.Servicio
{
    public class EmpleadoService
    {
        private readonly EmpleadoRepository empleadoRepository = new EmpleadoRepository();

        public Empleado ObtenerPorId(int id)
        {
            return empleadoRepository.ObtenerPorId(id);            
        }

        public int Crear(Empleado empleado, out string mensaje)
        {
            mensaje = string.Empty;

            if(empleado == null)
            {
                mensaje = "El empleado no puede ser nulo.";
                return 0;
            }

            if (string.IsNullOrWhiteSpace(empleado.InformacionPersonal.PrimerNombre))
            {
                mensaje = "El primer nombre del empleado es obligatorio.";
                return 0;
            }

            if (string.IsNullOrWhiteSpace(empleado.InformacionPersonal.PrimerApellido))
            {
                mensaje = "El primer apellido del empleado es obligatorio.";
                return 0;
            }

            if (string.IsNullOrWhiteSpace(empleado.InformacionPersonal.NumeroDocumento))
            {
                mensaje = "El número de documento es obligatorio.";
                return 0;
            }

            if (!empleadoRepository.ValidarCorreoElectronico(empleado.InformacionContacto.CorreoElectronico))
            {
                mensaje = "El correo electrónico es inválido.";
                return 0;
            }

            if (string.IsNullOrWhiteSpace(empleado.NombreUsuario))
            {
                mensaje = "El usuario es obligatorio.";
                return 0;
            }

            if (string.IsNullOrWhiteSpace(empleado.Contrasena))
            {
                mensaje = "La contraseña es obligatoria.";
                return 0;
            }

            int idEmpleado = empleadoRepository.Crear(empleado, out mensaje);

            if (idEmpleado > 0)
            {
                mensaje = "Empleado creado correctamente.";
            }
            else
            {
                mensaje = "No se pudo crear el empleado.";
            }

            return idEmpleado;
        }

        public bool Actualizar(Empleado empleado, out string mensaje)
        {
            mensaje = string.Empty;

            if (!empleadoRepository.Existe(empleado.IdEmpleado))
            {
                mensaje = "El empleado no existe.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(empleado.InformacionPersonal.NumeroDocumento))
            {
                mensaje = "El número de documento es obligatorio.";
                return false;
            }

            if (!empleadoRepository.ValidarCorreoElectronico(empleado.InformacionContacto.CorreoElectronico))
            {
                mensaje = "El correo electrónico no es válido.";
                return false;
            }

            if (empleado.Contrasena.Length < 8)
            {
                mensaje = "La contraseña debe tener al menos 8 caracteres.";
                return false;
            }

            bool resultado = empleadoRepository.Actualizar(empleado, out mensaje);

            if (resultado)
            {
                mensaje = "Empleado actualizado correctamente.";
            }
            else
            {
                mensaje = "Error al actualizar el empleado.";
            }

            return resultado;
        }

        public bool Eliminar(Empleado empleado, out string mensaje)
        {
            mensaje = string.Empty;

            if (empleado == null)
            {
                mensaje = "El empleado no puede ser nulo.";
                return false;
            }

            if (empleado.IdEmpleado <= 0)
            {
                mensaje = "El ID del empleado no es válido.";
                return false;
            }

            if (!empleadoRepository.Existe(empleado.IdEmpleado))
            {
                mensaje = "El empleado no existe en la base de datos.";
                return false;
            }

            //if (facturaMaestraRepository.ExistenVentasConEmpleado(empleado.IdEmpleado))
            //{
            //    mensaje = "El empleado tiene ventas asociadas y no se puede eliminar.";
            //    return false;
            //}

            bool resultado = empleadoRepository.Eliminar(empleado, out mensaje);

            if (resultado)
            {
                mensaje = "Empleado eliminado correctamente.";
            }
            else
            {
                mensaje = "Error al eliminar el empleado.";
            }

            return resultado;
        }

        public List<Empleado> ObtenerEmpleados()
        {
            return empleadoRepository.ObtenerTodos();
        }
    }
}
