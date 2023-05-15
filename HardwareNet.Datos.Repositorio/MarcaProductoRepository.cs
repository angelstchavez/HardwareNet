using HardwareNet.Datos.Connexion;
using HardwareNet.Datos.Interface;
using HardwareNet.Entidad;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;

namespace HardwareNet.Datos.Repositorio
{
    public class MarcaProductoRepository : IMarcaProductoRepository
    {
        public bool Actualizar(MarcaProducto entidad, out string mensaje)
        {
            throw new System.NotImplementedException();
        }

        public int Crear(MarcaProducto entidad, out string mensaje)
        {
            int resultado = 0;
            mensaje = string.Empty;

            try
            {
                // Crear la conexión a la base de datos
                using (OracleConnection conexion = new OracleConnection(ConexionMaestra.CadenaConexion))
                {
                    // Crear el comando y asignar los parámetros
                    using (OracleCommand comando = new OracleCommand("InsertarMarca", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.Add("p_IdMarcaProducto", OracleDbType.Int32).Value = entidad.IdMarcaProducto;
                        comando.Parameters.Add("p_Nombre", OracleDbType.Varchar2).Value = entidad.Nombre;
                        comando.Parameters.Add("p_FechaCreacion", OracleDbType.Date).Value = entidad.FechaCreacion;
                        comando.Parameters.Add("p_FechaModificacion", OracleDbType.Date).Value = entidad.FechaModificacion ?? (object)DBNull.Value;
                        comando.Parameters.Add("p_Estado", OracleDbType.Int32).Value = entidad.Estado ? 1 : 0;
                        comando.Parameters.Add("p_Resultado", OracleDbType.Int32).Direction = ParameterDirection.Output;
                        comando.Parameters.Add("p_Mensaje", OracleDbType.Varchar2, 2000).Direction = ParameterDirection.Output;

                        // Abrir la conexión y ejecutar el comando
                        conexion.Open();
                        comando.ExecuteNonQuery();

                        // Asignar los valores de salida
                        resultado = Convert.ToInt32(comando.Parameters["p_Resultado"].Value);
                        mensaje = comando.Parameters["p_Mensaje"].Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                mensaje = "Error al crear marca: " + ex.Message;
            }

            return resultado;
        }

        public bool Eliminar(MarcaProducto entidad, out string mensaje)
        {
            throw new System.NotImplementedException();
        }

        public bool Existe(int id)
        {
            throw new System.NotImplementedException();
        }

        public MarcaProducto ObtenerPorId(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<MarcaProducto> ObtenerTodos()
        {
            throw new System.NotImplementedException();
        }

        public bool ValidarCompraEmpleado()
        {
            throw new System.NotImplementedException();
        }
    }
}
