using System.Configuration;

namespace HardwareNet.Datos.Connexion
{
    public class ConexionMaestra
    {
        public static string CadenaConexion = ConfigurationManager.ConnectionStrings["CadenaConexion"].ToString();
    }
}
