namespace ProyectoFinal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            darAltaDoctorToolStripMenuItem = new ToolStripMenuItem();
            registrarPacienteToolStripMenuItem = new ToolStripMenuItem();
            agregarCitaToolStripMenuItem = new ToolStripMenuItem();
            editarToolStripMenuItem = new ToolStripMenuItem();
            verToolStripMenuItem = new ToolStripMenuItem();
            consultarDoctoresToolStripMenuItem = new ToolStripMenuItem();
            consultarPacientesToolStripMenuItem = new ToolStripMenuItem();
            citasToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, editarToolStripMenuItem, verToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { darAltaDoctorToolStripMenuItem, registrarPacienteToolStripMenuItem, agregarCitaToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(60, 20);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // darAltaDoctorToolStripMenuItem
            // 
            darAltaDoctorToolStripMenuItem.Name = "darAltaDoctorToolStripMenuItem";
            darAltaDoctorToolStripMenuItem.Size = new Size(168, 22);
            darAltaDoctorToolStripMenuItem.Text = "Dar Alta Doctor";
            darAltaDoctorToolStripMenuItem.Click += darAltaDoctorToolStripMenuItem_Click;
            // 
            // registrarPacienteToolStripMenuItem
            // 
            registrarPacienteToolStripMenuItem.Name = "registrarPacienteToolStripMenuItem";
            registrarPacienteToolStripMenuItem.Size = new Size(168, 22);
            registrarPacienteToolStripMenuItem.Text = "Registrar Paciente";
            registrarPacienteToolStripMenuItem.Click += registrarPacienteToolStripMenuItem_Click;
            // 
            // agregarCitaToolStripMenuItem
            // 
            agregarCitaToolStripMenuItem.Name = "agregarCitaToolStripMenuItem";
            agregarCitaToolStripMenuItem.Size = new Size(168, 22);
            agregarCitaToolStripMenuItem.Text = "Agregar Cita";
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(49, 20);
            editarToolStripMenuItem.Text = "Editar";
            // 
            // verToolStripMenuItem
            // 
            verToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { consultarDoctoresToolStripMenuItem, consultarPacientesToolStripMenuItem, citasToolStripMenuItem });
            verToolStripMenuItem.Name = "verToolStripMenuItem";
            verToolStripMenuItem.Size = new Size(35, 20);
            verToolStripMenuItem.Text = "Ver";
            // 
            // consultarDoctoresToolStripMenuItem
            // 
            consultarDoctoresToolStripMenuItem.Name = "consultarDoctoresToolStripMenuItem";
            consultarDoctoresToolStripMenuItem.Size = new Size(178, 22);
            consultarDoctoresToolStripMenuItem.Text = "Consultar Doctores";
            consultarDoctoresToolStripMenuItem.Click += consultarDoctoresToolStripMenuItem_Click;
            // 
            // consultarPacientesToolStripMenuItem
            // 
            consultarPacientesToolStripMenuItem.Name = "consultarPacientesToolStripMenuItem";
            consultarPacientesToolStripMenuItem.Size = new Size(178, 22);
            consultarPacientesToolStripMenuItem.Text = "Consultar Pacientes";
            consultarPacientesToolStripMenuItem.Click += consultarPacientesToolStripMenuItem_Click;
            // 
            // citasToolStripMenuItem
            // 
            citasToolStripMenuItem.Name = "citasToolStripMenuItem";
            citasToolStripMenuItem.Size = new Size(178, 22);
            citasToolStripMenuItem.Text = "Citas";
            // 
            // button1
            // 
            button1.Location = new Point(688, 415);
            button1.Name = "button1";
            button1.Size = new Size(100, 23);
            button1.TabIndex = 1;
            button1.Text = "Cerrar Sesion";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Menu";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem darAltaDoctorToolStripMenuItem;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem verToolStripMenuItem;
        private ToolStripMenuItem consultarDoctoresToolStripMenuItem;
        private ToolStripMenuItem registrarPacienteToolStripMenuItem;
        private ToolStripMenuItem agregarCitaToolStripMenuItem;
        private ToolStripMenuItem consultarPacientesToolStripMenuItem;
        private ToolStripMenuItem citasToolStripMenuItem;
        private Button button1;
    }
}
