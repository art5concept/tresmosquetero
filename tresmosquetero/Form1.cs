using System.Data.SqlClient; //Espacio de nombres para SQL Server
using tresmosquetero.capa_presentacion; 

namespace tresmosquetero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void b_jugadores_Click(object sender, EventArgs e)
        {

        }

        private void b_departamento_Click(object sender, EventArgs e)
        {
            formDepartamento formDepartamento = new formDepartamento();
            formDepartamento.ShowDialog();

        }
    }
}
