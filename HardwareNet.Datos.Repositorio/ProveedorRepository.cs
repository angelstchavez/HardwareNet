using HardwareNet.Datos.Interface;
using HardwareNet.Entidad;
using System.Collections.Generic;

namespace HardwareNet.Datos.Repositorio
{
    public class ProveedorRepository : IProveedorRepository
    {
        public bool Actualizar(Proveedor entidad, out string mensaje)
        {
            throw new System.NotImplementedException();
        }

        public int Crear(Proveedor entidad, out string mensaje)
        {
            throw new System.NotImplementedException();
        }

        public bool Eliminar(Proveedor entidad, out string mensaje)
        {
            throw new System.NotImplementedException();
        }

        public bool Existe(int id)
        {
            throw new System.NotImplementedException();
        }

        public Proveedor ObtenerPorId(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Proveedor> ObtenerTodos()
        {
            throw new System.NotImplementedException();
        }

        public bool ValidarCorreoElectronico(string correoElectronico)
        {
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

        public bool ValidarProductosAsociados(int IdProveedor)
        {
            throw new System.NotImplementedException();
        }
    }
}