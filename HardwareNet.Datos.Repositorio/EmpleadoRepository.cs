using HardwareNet.Entidad;
using System.Collections.Generic;

namespace HardwareNet.Datos.Repositorio
{
    public class EmpleadoRepository : Interface.IEmpleadoRepository
    {
        public bool Actualizar(Empleado entidad, out string mensaje)
        {
            throw new System.NotImplementedException();
        }

        public int Crear(Empleado entidad, out string mensaje)
        {
            throw new System.NotImplementedException();
        }

        public bool Eliminar(Empleado entidad, out string mensaje)
        {
            throw new System.NotImplementedException();
        }

        public bool Existe(int id)
        {
            throw new System.NotImplementedException();
        }

        public Empleado ObtenerPorId(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Empleado> ObtenerTodos()
        {
            throw new System.NotImplementedException();
        }

        public bool ValidarCorreoElectronico(string correoElectronico)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(correoElectronico);
                return addr.Address == correoElectronico;
            }
            catch
            {
                return false;
            }
        }
    }
}
