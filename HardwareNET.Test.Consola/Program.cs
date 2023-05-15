using System.Data;
using System;
using Devart.Data.Oracle;
using HardwareNet.Entidad;
using HardwareNet.Negocio.Servicio;

namespace HardwareNET.Test.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MarcaProducto marca = new MarcaProducto
            {
                IdMarcaProducto = 1,
                Nombre = "Marca de prueba",
                FechaCreacion = DateTime.Now,
                FechaModificacion = DateTime.Now,
                Estado = true
            };

            int resultado = 0;
            string mensaje = string.Empty;

            // Llamamos al método Crear
            resultado = new MarcaProductoService().Crear(marca, out mensaje);

            // Verificamos el resultado
            if (resultado > 1)
            {
                Console.WriteLine("Marca creada correctamente");
            }
            else
            {
                Console.WriteLine($"Error al crear marca: {mensaje}");
                Console.WriteLine($"Id: {marca.IdMarcaProducto}");
            }

            Console.ReadKey();
        }
    }
}
