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

        private void registrarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaPaciente altaPaciente = new frmAltaPaciente();
            altaPaciente.Show();
        }

        private void consultarPacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarPacientes consultarPacientes = new frmConsultarPacientes();
            consultarPacientes.Show();

        }
        private void agregarCitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frnAltaCita altaCita = new frnAltaCita();
            altaCita.Show();

        }
        private void citasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarCitas consultarCitas = new frmConsultarCitas();
            consultarCitas.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmContacto contacto = new frmContacto();
            contacto.Show();
        }
    }
}
