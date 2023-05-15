using HardwareNet.Datos.Interface;
using HardwareNet.Entidad;
using System.Collections.Generic;
using System.Data;

namespace HardwareNet.Datos.Repositorio
{
    public class FacturaMaestraRepository : IFacturaMaestraRepository
    {
        public bool AumentarStock(int idProducto, int cantidad)
        {
            throw new System.NotImplementedException();
        }

        public bool Crear(FacturaMaestra facturaMaestra, DataTable detalleSuministro, out string mensaje)
        {
            throw new System.NotImplementedException();
        }

        public int ObtenerCorrelativo()
        {
            throw new System.NotImplementedException();
        }

        public List<DetalleFactura> ObtenerDetallesFactura(int idFactura)
        {
            throw new System.NotImplementedException();
        }

        public List<FacturaMaestra> ObtenerFacturasMaestras()
        {
            throw new System.NotImplementedException();
        }

        public FacturaMaestra ObtenerVenta(string identificador)
        {
            throw new System.NotImplementedException();
        }

        public bool ReducirStock(int idProducto, int cantidad)
        {
            throw new System.NotImplementedException();
        }
    }
}
