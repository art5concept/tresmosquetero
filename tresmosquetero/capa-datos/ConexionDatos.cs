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
        private string _conexionDatos = "Server=192.168.50.211,1433;Database=Nuevo_Mundo;User Id=sa;Password=Qu1n_Hu4;TrustServerCertificate=True;";
        SqlConnection? Conexion;

        public SqlConnection EnlazarConexion()
        {
            this.Conexion = new SqlConnection(this._conexionDatos);
            return this.Conexion;
        }


        /*Ejecutar comando sin retorno de datos*/
        public bool ConexionSinRetornoDatos(string strComando)
        {
            try
            {

                SqlCommand Comando = new SqlCommand();
                Comando.CommandText = strComando;
                Comando.Connection = this.EnlazarConexion();
                Conexion.Open();
                Comando.ExecuteNonQuery();
                Conexion.Close();


                //using (SqlConnection conexonTemp = EnlazarConexion())
                //{
                //    conexonTemp.Open();

                //    using (SqlCommand Comando = new SqlCommand("SELECT COUNT(*) FROM Departamentos", conexonTemp))
                //    {
                //        Comando.ExecuteScalar(); // Ejecuta la consulta de forma ligera
                //    }
                //}

                return true;
            }
            catch
            {
                return false;
            }
        }

            // Sobrecarga IDU

        public bool ConexionSinRetornoDatos(SqlCommand SQLComando)
        {
            try
            {

                SqlCommand Comando = SQLComando;
             
                Comando.Connection = this.EnlazarConexion();
                Conexion.Open();
                Comando.ExecuteNonQuery();
                Conexion.Close();


                //using (SqlConnection conexonTemp = EnlazarConexion())
                //{
                //    conexonTemp.Open();

                //    using (SqlCommand Comando = new SqlCommand("SELECT COUNT(*) FROM Departamentos", conexonTemp))
                //    {
                //        Comando.ExecuteScalar(); // Ejecuta la consulta de forma ligera
                //    }
                //}

                return true;
            }
            catch
            {
                return false;
            }
        }

        /*Ejecutar comando con retorno de datos*/

        public DataSet EjecutarSentencia(SqlCommand sqlComando)
        {
            DataSet dataSet = new DataSet();
            SqlDataAdapter Adaptador = new SqlDataAdapter();

            try
            {
                SqlCommand Comando = new SqlCommand();
                Comando = sqlComando;
                Comando.Connection = EnlazarConexion();
                Adaptador.SelectCommand = Comando;
                Conexion.Open();
                Adaptador.Fill(dataSet);
                Conexion.Close();
                return dataSet;
            }
            catch (Exception ex)
            {
                // Manejar la excepción según sea necesario
                Console.WriteLine($"Error al ejecutar la sentencia: {ex.Message}");
            }
            return dataSet;

        }
    }
}
