using HardwareNet.Datos.Interface;
using HardwareNet.Entidad;
using System.Collections.Generic;

namespace HardwareNet.Datos.Repositorio
{
    public class ClienteRepository : IClienteRepository
    {
        public bool Actualizar(Cliente entidad, out string mensaje)
        {
            throw new System.NotImplementedException();
        }

        public int Crear(Cliente entidad, out string mensaje)
        {
            throw new System.NotImplementedException();
        }

        public bool Eliminar(Cliente entidad, out string mensaje)
        {
            throw new System.NotImplementedException();
        }

        public bool Existe(int id)
        {
            throw new System.NotImplementedException();
        }

        public bool ExisteFacturaRelacionada(int IdCliente)
        {
            throw new System.NotImplementedException();
        }

        public Cliente ObtenerPorId(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Cliente> ObtenerTodos()
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
