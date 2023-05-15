using HardwareNet.Entidad;
using System.Collections.Generic;
using System.Data;

namespace HardwareNet.Datos.Interface
{
    public interface IFacturaMaestraRepository
    {
        int ObtenerCorrelativo();
        List<FacturaMaestra> ObtenerFacturasMaestras();
        bool AumentarStock(int idProducto, int cantidad);
        bool ReducirStock(int idProducto, int cantidad);
        bool Crear(FacturaMaestra facturaMaestra, DataTable detalleSuministro, out string mensaje);
        FacturaMaestra ObtenerVenta(string identificador);
        List<DetalleFactura> ObtenerDetallesFactura(int idFactura);
    }
}