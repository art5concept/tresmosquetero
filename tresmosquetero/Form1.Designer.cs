namespace tresmosquetero
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            b_empleados = new Button();
            b_departamento = new Button();
            SuspendLayout();
            // 
            // b_empleados
            // 
            b_empleados.BackgroundImageLayout = ImageLayout.Center;
            b_empleados.Location = new Point(478, 150);
            b_empleados.Name = "b_empleados";
            b_empleados.Size = new Size(203, 123);
            b_empleados.TabIndex = 0;
            b_empleados.Text = "Empleados";
            b_empleados.UseVisualStyleBackColor = true;
            b_empleados.Click += b_jugadores_Click;
            // 
            // b_departamento
            // 
            b_departamento.Location = new Point(86, 139);
            b_departamento.Name = "b_departamento";
            b_departamento.Size = new Size(208, 123);
            b_departamento.TabIndex = 1;
            b_departamento.Text = "Departamentos";
            b_departamento.UseVisualStyleBackColor = true;
            b_departamento.Click += b_departamento_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(b_departamento);
            Controls.Add(b_empleados);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button b_empleados;
        private Button b_departamento;
    }
}
