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
            SqlCommand SQLComando = new SqlCommand("INSERT INTO Departamentos VALUES (@Departamente) ");
            SQLComando.Parameters.Add("@Departamente",SqlDbType.VarChar).Value = Odepartamento.Departamento;

            // return Conectar.ConexionSinRetornoDatos("INSERT INTO Departamentos (departamentos) VALUES ('" + Odepartamento.Departamento + "')");

            return Conectar.ConexionSinRetornoDatos(SQLComando);

        }
       
        public DataSet MostrarDep()
        {
            SqlCommand sentencia = new SqlCommand("SELECT * FROM Departamentos");
            return Conectar.EjecutarSentencia(sentencia);
        }

        public bool Eliminar(LogicaDepartamento Odepartamento)
        {
            SqlCommand SQLComando = new SqlCommand("DELETE FROM Departamentos WHERE ID = @ID");
            SQLComando.Parameters.Add("@ID", SqlDbType.Int).Value = Odepartamento.ID;
            return Conectar.ConexionSinRetornoDatos(SQLComando);
            //Conectar.ConexionSinRetornoDatos("DELETE FROM Departamentos WHERE ID = " + Odepartamento.ID);
            //return 1;
        }
        public bool Editar(LogicaDepartamento Odepartamento)
        {
            SqlCommand SQLComando = new SqlCommand("UPDATE Departamentos SET departamentos = @Departamente WHERE ID = @ID");
            SQLComando.Parameters.Add("@Departamente", SqlDbType.VarChar).Value = Odepartamento.Departamento;
            SQLComando.Parameters.Add("@ID", SqlDbType.Int).Value = Odepartamento.ID;
            return Conectar.ConexionSinRetornoDatos(SQLComando);
            //Conectar.ConexionSinRetornoDatos("UPDATE Departamentos SET departamentos = '" + Odepartamento.Departamento + "' WHERE ID = " + Odepartamento.ID);
            //return 1;
        }

    }
}
         