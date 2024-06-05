namespace ProyectoFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void darAltaDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaDoctor altaDoctor = new frmAltaDoctor();
            altaDoctor.Show();
        }

        private void consultarDoctoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarDoctores consultarDoctores = new frmConsultarDoctores();
            consultarDoctores.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
