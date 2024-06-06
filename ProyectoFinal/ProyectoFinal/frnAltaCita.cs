using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class frnAltaCita : Form
    {
        public frnAltaCita()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection("server=DESKTOP-B6B5N8Q\\MSSQLSERVER19; database=bd2024; Integrated Security=True;");

        private void frnAltaCita_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                conexion.Open();
                string consulta = "select * from pacientes";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                SqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    cboPaciente.Items.Add(lector.GetString(2));
                }
                lector.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                string consulta = "select * from doctores";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                SqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    cboDoctor.Items.Add(lector.GetString(2));
                }
                lector.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bttonAgregarCita_Click(object sender, EventArgs e)
        {
            string pacienteAsig = cboPaciente.SelectedItem.ToString();
            string doctorAsig = cboDoctor.SelectedItem.ToString();
            int dia = int.Parse(txtDia.Text);
            int mes = int.Parse(txtMes.Text);
            int year = int.Parse(txtYear.Text);
            string horario = cboHorario.SelectedItem.ToString();
            string descripcion = txtDescripcion.Text;

            try
            {
                // Open the connection
                conexion.Open();

                // SQL insert command
                string insertQuery = "INSERT INTO citas (pacient_Asig, doctor_Asig, dia, mes, year, horario, descripcion) " +
                                     "VALUES (@pacienteAsig, @doctorAsig, @dia, @mes, @year, @horario, @descripcion)";

                // Create the SQL command
                SqlCommand comando = new SqlCommand(insertQuery, conexion);

                // Add the parameters to the command
                comando.Parameters.AddWithValue("@pacienteAsig", pacienteAsig);
                comando.Parameters.AddWithValue("@doctorAsig", doctorAsig);
                comando.Parameters.AddWithValue("@dia", dia);
                comando.Parameters.AddWithValue("@mes", mes);
                comando.Parameters.AddWithValue("@year", year);
                comando.Parameters.AddWithValue("@horario", horario);
                comando.Parameters.AddWithValue("@descripcion", descripcion);

                // Execute the command
                comando.ExecuteNonQuery();

                // Notify the user
                MessageBox.Show("Cita agregada exitosamente.");
            }
            catch (Exception ex)
            {
                // Handle the error
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                // Close the connection
                conexion.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

