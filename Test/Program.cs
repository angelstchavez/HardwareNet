using HardwareNet.Datos.Connexion;
using Oracle.ManagedDataAccess.Client;
using System;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (OracleConnection connection = new OracleConnection(ConexionMaestra.CadenaConexion))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine($"Connexión exitosa: {connection.ServerVersion}");
                    Console.ReadKey();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.ReadKey();
                }
            }
        }
    }
}
