using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using tresmosquetero.capa_datos;

using tresmosquetero.capa_logica;

namespace tresmosquetero.capa_presentacion
{
    public partial class formDepartamento : Form
    {
        DepartamentosDatos OdepartamentoDatos;



        // metodo constructor del formulario
        public formDepartamento()
        {
            OdepartamentoDatos = new DepartamentosDatos();
            InitializeComponent();
            dataGridDepartamento.DataSource = OdepartamentoDatos.MostrarDep().Tables[0];
        }


        private void buttonDepAgregar_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Todo conectado...");

            // Recolectar la información del formulario y agregarla a la base de datos
            OdepartamentoDatos.Agregar(RecolectarInformacion());

        }

        private LogicaDepartamento RecolectarInformacion()
        {

            LogicaDepartamento Odepartamento = new LogicaDepartamento();
            int ID = 0; int.TryParse(txtIDDepa.Text, out ID);

            Odepartamento.ID = ID;
            Odepartamento.Departamento = txtDepa.Text;

            return Odepartamento;

        }

        private void txtIDDepa_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridDepartamento_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int indice = e.RowIndex;
            txtIDDepa.Text = dataGridDepartamento.Rows[indice].Cells[0].Value.ToString();
            txtDepa.Text = dataGridDepartamento.Rows[indice].Cells[1].Value.ToString();
        }

        private void buttonDepaBorrar_Click(object sender, EventArgs e)
        {
            OdepartamentoDatos.Eliminar(RecolectarInformacion());
            dataGridDepartamento.DataSource = OdepartamentoDatos.MostrarDep().Tables[0];

        }
    }
}
