namespace ProyectoFinal
{
    partial class frnAltaCita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frnAltaCita));
            label1 = new Label();
            label2 = new Label();
            txtDia = new TextBox();
            txtMes = new TextBox();
            txtYear = new TextBox();
            cboPaciente = new ComboBox();
            cboHorario = new ComboBox();
            label3 = new Label();
            button1 = new Button();
            label4 = new Label();
            cboDoctor = new ComboBox();
            button2 = new Button();
            label5 = new Label();
            txtDescripcion = new TextBox();
            bttonAgregarCita = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 102);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 0;
            label1.Text = "Paciente:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(105, 186);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 1;
            label2.Text = "Fecha:";
            label2.Click += label2_Click;
            // 
            // txtDia
            // 
            txtDia.Location = new Point(152, 183);
            txtDia.Name = "txtDia";
            txtDia.PlaceholderText = "DD";
            txtDia.Size = new Size(31, 23);
            txtDia.TabIndex = 2;
            txtDia.TextAlign = HorizontalAlignment.Center;
            // 
            // txtMes
            // 
            txtMes.Location = new Point(189, 183);
            txtMes.Name = "txtMes";
            txtMes.PlaceholderText = "MM";
            txtMes.Size = new Size(31, 23);
            txtMes.TabIndex = 3;
            txtMes.TextAlign = HorizontalAlignment.Center;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(226, 183);
            txtYear.Name = "txtYear";
            txtYear.PlaceholderText = "AAAA";
            txtYear.Size = new Size(52, 23);
            txtYear.TabIndex = 4;
            txtYear.TextAlign = HorizontalAlignment.Center;
            // 
            // cboPaciente
            // 
            cboPaciente.FormattingEnabled = true;
            cboPaciente.Location = new Point(152, 99);
            cboPaciente.Name = "cboPaciente";
            cboPaciente.Size = new Size(121, 23);
            cboPaciente.TabIndex = 5;
            cboPaciente.Text = "Seleccionar";
            // 
            // cboHorario
            // 
            cboHorario.FormattingEnabled = true;
            cboHorario.Items.AddRange(new object[] { "6:00am - 8:00am", "8:00am - 10:00am", "10:00am - 12:00pm", "12:00pm - 14:00pm" });
            cboHorario.Location = new Point(362, 183);
            cboHorario.Name = "cboHorario";
            cboHorario.Size = new Size(121, 23);
            cboHorario.TabIndex = 6;
            cboHorario.Text = "Seleccionar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(306, 186);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 7;
            label3.Text = "Horario:";
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(293, 99);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Refrescar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 141);
            label4.Name = "label4";
            label4.Size = new Size(99, 15);
            label4.TabIndex = 9;
            label4.Text = "Doctor Asignado:";
            label4.Click += label4_Click;
            // 
            // cboDoctor
            // 
            cboDoctor.FormattingEnabled = true;
            cboDoctor.Location = new Point(152, 138);
            cboDoctor.Name = "cboDoctor";
            cboDoctor.Size = new Size(121, 23);
            cboDoctor.TabIndex = 10;
            cboDoctor.Text = "Seleccionar";
            // 
            // button2
            // 
            button2.Location = new Point(293, 138);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 11;
            button2.Text = "Refrescar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 227);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 12;
            label5.Text = "Descripcion:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(47, 254);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(436, 105);
            txtDescripcion.TabIndex = 13;
            // 
            // bttonAgregarCita
            // 
            bttonAgregarCita.Location = new Point(226, 401);
            bttonAgregarCita.Name = "bttonAgregarCita";
            bttonAgregarCita.Size = new Size(91, 23);
            bttonAgregarCita.TabIndex = 14;
            bttonAgregarCita.Text = "Agregar Cita";
            bttonAgregarCita.UseVisualStyleBackColor = true;
            bttonAgregarCita.Click += bttonAgregarCita_Click;
            // 
            // button3
            // 
            button3.Location = new Point(467, 442);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 15;
            button3.Text = "Cerrar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // frnAltaCita
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 477);
            Controls.Add(button3);
            Controls.Add(bttonAgregarCita);
            Controls.Add(txtDescripcion);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(cboDoctor);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(cboHorario);
            Controls.Add(cboPaciente);
            Controls.Add(txtYear);
            Controls.Add(txtMes);
            Controls.Add(txtDia);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frnAltaCita";
            Text = "Alta Cita";
            Load += frnAltaCita_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtDia;
        private TextBox txtMes;
        private TextBox txtYear;
        private ComboBox cboPaciente;
        private ComboBox cboHorario;
        private Label label3;
        private Button button1;
        private Label label4;
        private ComboBox cboDoctor;
        private Button button2;
        private Label label5;
        private TextBox txtDescripcion;
        private Button bttonAgregarCita;
        private Button button3;
    }
}