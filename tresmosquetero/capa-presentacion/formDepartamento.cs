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
        public formDepartamento()
        {
            InitializeComponent();
        }


        private void buttonDepAgregar_Click(object sender, EventArgs e)
        {
            //recolectar informacion del formulario

     
            RecolectarInformacion();

            ConexionDatos Conectar = new ConexionDatos();
            if (Conectar.PruebaConexion())
            {
                MessageBox.Show("Todo conectado...");
            }


        }

        private void RecolectarInformacion()
        {

            LogicaDepartamento Odepartamento = new LogicaDepartamento();
            int ID = 0; int.TryParse(txtIDDepa.Text, out ID);

            Odepartamento.ID = ID;
            Odepartamento.Departamento = txtDepa.Text;

            MessageBox.Show(Odepartamento.ID.ToString());
            MessageBox.Show(Odepartamento.Departamento);

        }

        private void txtIDDepa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
