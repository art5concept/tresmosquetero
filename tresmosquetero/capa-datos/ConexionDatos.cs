using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Microsoft.Data.SqlClient;
using System.Text;
using System.Runtime.CompilerServices;

namespace tresmosquetero.capa_datos
{
    internal class ConexionDatos
    {
        private string _conexionDatos = "Server=192.168.50.211,1433;Database=Nuevo_Mundo;User_Id=sa;Password=Qu1n_Hu4;Trusted_Connection=true;";
        public SqlConnection Conexion;

        public SqlConnection EnlazarConexion()
        {
            if (Conexion == null)
            {
                Conexion = new SqlConnection(_conexionDatos);
            }
            return Conexion;
        }

        public bool PruebaConexion()
        {
            try
            {
                using (SqlConnection conexonTemp = EnlazarConexion())
                {
                    conexonTemp.Open();

                    using (SqlCommand Comando = new SqlCommand("SELECT COUNT(*) FROM Departamentos", conexonTemp))
                    {
                        Comando.ExecuteScalar(); // Ejecuta la consulta de forma ligera
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
