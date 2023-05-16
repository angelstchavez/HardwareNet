using HardwareNet.Datos.Connexion;
using System;
using System.Data.OracleClient;

namespace HardwareNET.Test.Consola
{
    internal class Program
    {
        [Obsolete]
        static void Main(string[] args)
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(ConexionMaestra.CadenaConexion))
                {
                    connection.Open();
                    Console.WriteLine("Conectado");
                    Console.ReadKey();
                }
            }
            catch (OracleException ex)
            {
                // Manejo de excepciones específicas de Oracle
                Console.WriteLine("Error de Oracle: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Manejo de excepciones generales
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
