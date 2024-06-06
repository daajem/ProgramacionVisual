namespace ProyectoFinal
{
    partial class frmAltaPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAltaPaciente));
            button3 = new Button();
            groupBox2 = new GroupBox();
            button5 = new Button();
            button4 = new Button();
            button2 = new Button();
            button1 = new Button();
            groupBox1 = new GroupBox();
            txtIdentificacion = new TextBox();
            label8 = new Label();
            txtTelefono = new TextBox();
            cboGenero = new ComboBox();
            txtDireccion = new TextBox();
            txtSeg_ape = new TextBox();
            txtPri_ape = new TextBox();
            txtSeg_nom = new TextBox();
            txtPri_nom = new TextBox();
            label1 = new Label();
            label7 = new Label();
            label2 = new Label();
            label6 = new Label();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(432, 539);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 12;
            button3.Text = "Cerrar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button1);
            groupBox2.Location = new Point(11, 433);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(496, 91);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Controladores";
            // 
            // button5
            // 
            button5.Location = new Point(127, 51);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 3;
            button5.Text = "Buscar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(46, 51);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 2;
            button4.Text = "Editar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.Location = new Point(127, 22);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(46, 22);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtIdentificacion);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(cboGenero);
            groupBox1.Controls.Add(txtDireccion);
            groupBox1.Controls.Add(txtSeg_ape);
            groupBox1.Controls.Add(txtPri_ape);
            groupBox1.Controls.Add(txtSeg_nom);
            groupBox1.Controls.Add(txtPri_nom);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(11, 14);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(496, 394);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Paciente";
            // 
            // txtIdentificacion
            // 
            txtIdentificacion.Location = new Point(178, 50);
            txtIdentificacion.Name = "txtIdentificacion";
            txtIdentificacion.Size = new Size(129, 23);
            txtIdentificacion.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(86, 58);
            label8.Name = "label8";
            label8.Size = new Size(82, 15);
            label8.TabIndex = 14;
            label8.Text = "Identificacion:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(178, 290);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(238, 23);
            txtTelefono.TabIndex = 13;
            // 
            // cboGenero
            // 
            cboGenero.FormattingEnabled = true;
            cboGenero.Items.AddRange(new object[] { "Masculino", "Femenino", "Otro" });
            cboGenero.Location = new Point(178, 250);
            cboGenero.Name = "cboGenero";
            cboGenero.Size = new Size(121, 23);
            cboGenero.TabIndex = 12;
            cboGenero.Text = "Seleccionar";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(178, 330);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(238, 23);
            txtDireccion.TabIndex = 11;
            // 
            // txtSeg_ape
            // 
            txtSeg_ape.Location = new Point(178, 210);
            txtSeg_ape.Name = "txtSeg_ape";
            txtSeg_ape.Size = new Size(238, 23);
            txtSeg_ape.TabIndex = 10;
            // 
            // txtPri_ape
            // 
            txtPri_ape.Location = new Point(178, 170);
            txtPri_ape.Name = "txtPri_ape";
            txtPri_ape.Size = new Size(238, 23);
            txtPri_ape.TabIndex = 9;
            // 
            // txtSeg_nom
            // 
            txtSeg_nom.Location = new Point(178, 130);
            txtSeg_nom.Name = "txtSeg_nom";
            txtSeg_nom.Size = new Size(238, 23);
            txtSeg_nom.TabIndex = 8;
            // 
            // txtPri_nom
            // 
            txtPri_nom.Location = new Point(178, 90);
            txtPri_nom.Name = "txtPri_nom";
            txtPri_nom.Size = new Size(238, 23);
            txtPri_nom.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 98);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 0;
            label1.Text = "Primer Nombre:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(108, 338);
            label7.Name = "label7";
            label7.Size = new Size(60, 15);
            label7.TabIndex = 6;
            label7.Text = "Direccion:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 138);
            label2.Name = "label2";
            label2.Size = new Size(104, 15);
            label2.TabIndex = 1;
            label2.Text = "Segundo Nombre:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(113, 298);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 5;
            label6.Text = "Telefono:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(76, 178);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 2;
            label3.Text = "Primer Apellido:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(120, 258);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 4;
            label5.Text = "Genero:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(64, 218);
            label4.Name = "label4";
            label4.Size = new Size(104, 15);
            label4.TabIndex = 3;
            label4.Text = "Segundo Apellido:";
            // 
            // frmAltaPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 576);
            Controls.Add(button3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmAltaPaciente";
            Text = "frmAltaPaciente";
            Load += frmAltaPaciente_Load;
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button3;
        private GroupBox groupBox2;
        private Button button5;
        private Button button4;
        private Button button2;
        private Button button1;
        private GroupBox groupBox1;
        private TextBox txtIdentificacion;
        private Label label8;
        private TextBox txtTelefono;
        private ComboBox cboGenero;
        private TextBox txtDireccion;
        private TextBox txtSeg_ape;
        private TextBox txtPri_ape;
        private TextBox txtSeg_nom;
        private TextBox txtPri_nom;
        private Label label1;
        private Label label7;
        private Label label2;
        private Label label6;
        private Label label3;
        private Label label5;
        private Label label4;
    }
}