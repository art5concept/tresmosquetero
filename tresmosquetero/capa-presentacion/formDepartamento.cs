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
            llenarDataGrid();
            LimpiarEntradas();
        }


        private void buttonDepAgregar_Click(object sender, EventArgs e)
        {

            //MessageBox.Show("Todo conectado...");

            // Recolectar la información del formulario y agregarla a la base de datos
            OdepartamentoDatos.Agregar(RecolectarInformacion());
            llenarDataGrid();
            LimpiarEntradas();

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

            dataGridDepartamento.ClearSelection();
            if (indice >= 0)
            {



                txtIDDepa.Text = dataGridDepartamento.Rows[indice].Cells[0].Value.ToString();
                txtDepa.Text = dataGridDepartamento.Rows[indice].Cells[1].Value.ToString();

                buttonDepAgregar.Enabled = false;
                buttonDepaModificar.Enabled = true;
                buttonDepaBorrar.Enabled = true;
                buttonDepaCancelar.Enabled = true;
            }
        }

        private void buttonDepaBorrar_Click(object sender, EventArgs e)
        {
            OdepartamentoDatos.Eliminar(RecolectarInformacion());
            llenarDataGrid();
            LimpiarEntradas();
        }

        private void buttonDepaModificar_Click(object sender, EventArgs e)
        {
            OdepartamentoDatos.Editar(RecolectarInformacion());
            llenarDataGrid();
            LimpiarEntradas();
        }



        // esto qeudo en la parte 1cel capitulo 19 de la serie de youtube que estamos viendo
        // ahora se pondra ha hacer lo del los iconos
        public void llenarDataGrid()
        {
            dataGridDepartamento.DataSource = OdepartamentoDatos.MostrarDep().Tables[0];
            dataGridDepartamento.Columns[0].HeaderText = "ID";
            dataGridDepartamento.Columns[1].HeaderText = "Nombre del Departamento";
        }

        public void LimpiarEntradas()
        {
            txtDepa.Text = "";
            txtIDDepa.Text = "";

            buttonDepAgregar.Enabled = true;
            buttonDepaModificar.Enabled = false;
            buttonDepaBorrar.Enabled = false;
            buttonDepaCancelar.Enabled = false;
        }

        private void buttonDepaCancelar_Click(object sender, EventArgs e)
        {
            LimpiarEntradas();
        }
    }
}
