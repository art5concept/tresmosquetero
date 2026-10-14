using System;
using System.Collections.Generic;
using System.Text;

//using System.Data.SqlClient;
using System.Data;
using tresmosquetero.capa_logica;
using Microsoft.Data.SqlClient;

namespace tresmosquetero.capa_datos
{
    class DepartamentosDatos
    {
        ConexionDatos Conectar;
        public DepartamentosDatos()
        {
            Conectar = new ConexionDatos();
        }
        public bool Agregar(LogicaDepartamento Odepartamento)
        {
           return Conectar.ConexionSinRetornoDatos("INSERT INTO Departamentos (departamentos) VALUES ('" + Odepartamento.Departamento + "')");
        }
       
        public DataSet MostrarDep()
        {
            SqlCommand sentencia = new SqlCommand("SELECT * FROM Departamentos");
            return Conectar.EjecutarSentencia(sentencia);
        }

        public int Eliminar(LogicaDepartamento Odepartamento)
        {
             Conectar.ConexionSinRetornoDatos("DELETE FROM Departamentos WHERE ID = " + Odepartamento.ID);
            return 1;
        }

    }
}
         