namespace tresmosquetero.capa_presentacion
{
    partial class formEmpleados
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
            txt = new Label();
            textID = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            comboBoxDepa = new ComboBox();
            label3 = new Label();
            iconpic = new PictureBox();
            txtPrimerApellido = new TextBox();
            label4 = new Label();
            buttonIcon = new Button();
            buttonAgregar = new Button();
            buttonModificar = new Button();
            buttonBorrar = new Button();
            buttonCancelar = new Button();
            datagrid_Empleados = new DataGridView();
            textSegundoApellido = new TextBox();
            label5 = new Label();
            txtGmail = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)iconpic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)datagrid_Empleados).BeginInit();
            SuspendLayout();
            // 
            // txt
            // 
            txt.AutoSize = true;
            txt.Location = new Point(203, 19);
            txt.Name = "txt";
            txt.Size = new Size(21, 15);
            txt.TabIndex = 0;
            txt.Text = "ID:";
            // 
            // textID
            // 
            textID.Location = new Point(203, 37);
            textID.Name = "textID";
            textID.Size = new Size(100, 23);
            textID.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(351, 19);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(351, 37);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(255, 23);
            txtNombre.TabIndex = 3;
            // 
            // comboBoxDepa
            // 
            comboBoxDepa.FormattingEnabled = true;
            comboBoxDepa.Location = new Point(203, 188);
            comboBoxDepa.Name = "comboBoxDepa";
            comboBoxDepa.Size = new Size(403, 23);
            comboBoxDepa.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(203, 63);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 5;
            label3.Text = "Primer apellido:";
            // 
            // iconpic
            // 
            iconpic.Location = new Point(12, 19);
            iconpic.Name = "iconpic";
            iconpic.Size = new Size(167, 192);
            iconpic.TabIndex = 6;
            iconpic.TabStop = false;
            // 
            // txtPrimerApellido
            // 
            txtPrimerApellido.Location = new Point(203, 81);
            txtPrimerApellido.Name = "txtPrimerApellido";
            txtPrimerApellido.Size = new Size(143, 23);
            txtPrimerApellido.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(374, 63);
            label4.Name = "label4";
            label4.Size = new Size(102, 15);
            label4.TabIndex = 8;
            label4.Text = "Segundo apellido:";
            // 
            // buttonIcon
            // 
            buttonIcon.Location = new Point(12, 217);
            buttonIcon.Name = "buttonIcon";
            buttonIcon.Size = new Size(167, 23);
            buttonIcon.TabIndex = 9;
            buttonIcon.Text = "Examinar";
            buttonIcon.UseVisualStyleBackColor = true;
            // 
            // buttonAgregar
            // 
            buttonAgregar.Location = new Point(202, 217);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(75, 23);
            buttonAgregar.TabIndex = 10;
            buttonAgregar.Text = "Agregar";
            buttonAgregar.UseVisualStyleBackColor = true;
            // 
            // buttonModificar
            // 
            buttonModificar.Location = new Point(314, 217);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(75, 23);
            buttonModificar.TabIndex = 11;
            buttonModificar.Text = "Editar";
            buttonModificar.UseVisualStyleBackColor = true;
            // 
            // buttonBorrar
            // 
            buttonBorrar.Location = new Point(416, 217);
            buttonBorrar.Name = "buttonBorrar";
            buttonBorrar.Size = new Size(75, 23);
            buttonBorrar.TabIndex = 12;
            buttonBorrar.Text = "Eliminar";
            buttonBorrar.UseVisualStyleBackColor = true;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(531, 217);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(75, 23);
            buttonCancelar.TabIndex = 13;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // datagrid_Empleados
            // 
            datagrid_Empleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagrid_Empleados.Location = new Point(12, 268);
            datagrid_Empleados.Name = "datagrid_Empleados";
            datagrid_Empleados.Size = new Size(594, 177);
            datagrid_Empleados.TabIndex = 14;
            // 
            // textSegundoApellido
            // 
            textSegundoApellido.Location = new Point(374, 81);
            textSegundoApellido.Name = "textSegundoApellido";
            textSegundoApellido.Size = new Size(232, 23);
            textSegundoApellido.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(202, 116);
            label5.Name = "label5";
            label5.Size = new Size(108, 15);
            label5.TabIndex = 16;
            label5.Text = "Correo electrónico:";
            // 
            // txtGmail
            // 
            txtGmail.Location = new Point(202, 137);
            txtGmail.Name = "txtGmail";
            txtGmail.Size = new Size(350, 23);
            txtGmail.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(202, 170);
            label6.Name = "label6";
            label6.Size = new Size(86, 15);
            label6.TabIndex = 18;
            label6.Text = "Departamento:";
            // 
            // formEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(671, 470);
            Controls.Add(label6);
            Controls.Add(txtGmail);
            Controls.Add(label5);
            Controls.Add(textSegundoApellido);
            Controls.Add(datagrid_Empleados);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonBorrar);
            Controls.Add(buttonModificar);
            Controls.Add(buttonAgregar);
            Controls.Add(buttonIcon);
            Controls.Add(label4);
            Controls.Add(txtPrimerApellido);
            Controls.Add(iconpic);
            Controls.Add(label3);
            Controls.Add(comboBoxDepa);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(textID);
            Controls.Add(txt);
            Name = "formEmpleados";
            Text = "formJugadores";
            ((System.ComponentModel.ISupportInitialize)iconpic).EndInit();
            ((System.ComponentModel.ISupportInitialize)datagrid_Empleados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txt;
        private TextBox textID;
        private Label label2;
        private TextBox txtNombre;
        private ComboBox comboBoxDepa;
        private Label label3;
        private PictureBox iconpic;
        private TextBox txtPrimerApellido;
        private Label label4;
        private Button buttonIcon;
        private Button buttonAgregar;
        private Button buttonModificar;
        private Button buttonBorrar;
        private Button buttonCancelar;
        private DataGridView datagrid_Empleados;
        private TextBox textSegundoApellido;
        private Label label5;
        private TextBox txtGmail;
        private Label label6;
    }
}