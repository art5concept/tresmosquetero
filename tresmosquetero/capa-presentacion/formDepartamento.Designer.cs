namespace tresmosquetero.capa_presentacion
{
    partial class formDepartamento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtIDDepa = new TextBox();
            label2 = new Label();
            txtDepa = new TextBox();
            buttonDepAgregar = new Button();
            buttonDepaModificar = new Button();
            buttonDepaBorrar = new Button();
            buttonDepaCancelar = new Button();
            dataGridDepartamento = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridDepartamento).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 27);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // txtIDDepa
            // 
            txtIDDepa.Location = new Point(23, 45);
            txtIDDepa.Name = "txtIDDepa";
            txtIDDepa.Size = new Size(107, 23);
            txtIDDepa.TabIndex = 1;
            txtIDDepa.TextChanged += txtIDDepa_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(189, 27);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 2;
            label2.Text = "Departamento:";
            // 
            // txtDepa
            // 
            txtDepa.Location = new Point(189, 45);
            txtDepa.Name = "txtDepa";
            txtDepa.Size = new Size(240, 23);
            txtDepa.TabIndex = 3;
            // 
            // buttonDepAgregar
            // 
            buttonDepAgregar.Location = new Point(25, 87);
            buttonDepAgregar.Name = "buttonDepAgregar";
            buttonDepAgregar.Size = new Size(75, 23);
            buttonDepAgregar.TabIndex = 4;
            buttonDepAgregar.Text = "Agregar";
            buttonDepAgregar.UseVisualStyleBackColor = true;
            buttonDepAgregar.Click += buttonDepAgregar_Click;
            // 
            // buttonDepaModificar
            // 
            buttonDepaModificar.Location = new Point(138, 87);
            buttonDepaModificar.Name = "buttonDepaModificar";
            buttonDepaModificar.Size = new Size(75, 23);
            buttonDepaModificar.TabIndex = 5;
            buttonDepaModificar.Text = "Editar";
            buttonDepaModificar.UseVisualStyleBackColor = true;
            // 
            // buttonDepaBorrar
            // 
            buttonDepaBorrar.Location = new Point(236, 87);
            buttonDepaBorrar.Name = "buttonDepaBorrar";
            buttonDepaBorrar.Size = new Size(75, 23);
            buttonDepaBorrar.TabIndex = 6;
            buttonDepaBorrar.Text = "Eliminar";
            buttonDepaBorrar.UseVisualStyleBackColor = true;
            // 
            // buttonDepaCancelar
            // 
            buttonDepaCancelar.Location = new Point(335, 87);
            buttonDepaCancelar.Name = "buttonDepaCancelar";
            buttonDepaCancelar.Size = new Size(75, 23);
            buttonDepaCancelar.TabIndex = 7;
            buttonDepaCancelar.Text = "Cancelar";
            buttonDepaCancelar.UseVisualStyleBackColor = true;
            // 
            // dataGridDepartamento
            // 
            dataGridDepartamento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridDepartamento.Location = new Point(23, 136);
            dataGridDepartamento.Name = "dataGridDepartamento";
            dataGridDepartamento.Size = new Size(406, 174);
            dataGridDepartamento.TabIndex = 8;
            // 
            // formDepartamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 340);
            Controls.Add(dataGridDepartamento);
            Controls.Add(buttonDepaCancelar);
            Controls.Add(buttonDepaBorrar);
            Controls.Add(buttonDepaModificar);
            Controls.Add(buttonDepAgregar);
            Controls.Add(txtDepa);
            Controls.Add(label2);
            Controls.Add(txtIDDepa);
            Controls.Add(label1);
            Name = "formDepartamento";
            Text = "formEquipo";
            ((System.ComponentModel.ISupportInitialize)dataGridDepartamento).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtIDDepa;
        private Label label2;
        private TextBox txtDepa;
        private Button buttonDepAgregar;
        private Button buttonDepaModificar;
        private Button buttonDepaBorrar;
        private Button buttonDepaCancelar;
        private DataGridView dataGridDepartamento;
    }
}