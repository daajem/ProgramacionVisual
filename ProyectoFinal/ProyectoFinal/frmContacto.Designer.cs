namespace ProyectoFinal
{
    partial class frmContacto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContacto));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(139, 129);
            label1.Name = "label1";
            label1.Size = new Size(139, 15);
            label1.TabIndex = 0;
            label1.Text = "Daniel Jimenez Manrique";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(106, 169);
            label2.Name = "label2";
            label2.Size = new Size(205, 15);
            label2.TabIndex = 1;
            label2.Text = "Rodrigo Moises Alvarado Mondragon";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(139, 207);
            label3.Name = "label3";
            label3.Size = new Size(148, 15);
            label3.TabIndex = 2;
            label3.Text = "Alexis Rodriguez Camacho";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(145, 245);
            label4.Name = "label4";
            label4.Size = new Size(133, 15);
            label4.TabIndex = 3;
            label4.Text = "Erubiel Cuevas Martinez";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(121, 280);
            label5.Name = "label5";
            label5.Size = new Size(166, 15);
            label5.TabIndex = 4;
            label5.Text = "Kathia Karely Rivera Rodriguez";
            // 
            // button1
            // 
            button1.Location = new Point(358, 385);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Cerrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmContacto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 420);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmContacto";
            Text = "Contacto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
    }
}