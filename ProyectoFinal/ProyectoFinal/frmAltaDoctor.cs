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
    public partial class frmAltaDoctor : Form
    {

        SqlConnection Conexion = new SqlConnection();
        SqlCommand Comando;
        SqlDataAdapter Adaptador = null;
        DataTable Tabla = new DataTable();
        string Sql = " ";
        string Servidor = @"DESKTOP-B6B5N8Q\MSSQLSERVER19";
        string Base_Datos = "bd2024";
        int indice = 0;
        void Conectar()
        {
            try
            {
                //Para establecer la conexion con el servidor debemos usar el objeto Conexion
                //especificando a traves de su propiedad ConnectionString el nombre del servidor, la bases de datos
                //y el tiempo de seguridad
                Conexion.ConnectionString = "Data Source=" + Servidor + ";" +
                "Initial Catalog=" + Base_Datos + ";" +
                "Integrated security=true";
                try
                //Bloque try catch para captura de exepciones en ejecución
                {
                    Conexion.Open(); //Abrimos la conexión
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("ClientesBDError al tratar de establecer la conexión " + ex.Message);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error en la conexión: " + ex.Message);
            }
        }
        //*********************************************************************
        //Este método recibe como parámetro un índice correspondiente al registro a cargar
        void CargarDatos(int indice)
        {
            if (Tabla.Rows.Count > 0) //Si el objeto Tabla posee registros procedemos a realizar la asignación
            {
                DataRow fila = Tabla.Rows[indice]; //Creamos una fila del Objeto Tabla
                //Asignamos los valores correspondientes a cada registro
                txtIdentificacion.Text = fila["identificador"].ToString();
                txtPri_nom.Text = fila["pri_nom"].ToString();
                txtSeg_nom.Text = fila["seg_nom"].ToString();
                txtPri_ape.Text = fila["pri_ape"].ToString();
                txtSeg_ape.Text = fila["seg_ape"].ToString();
                cboGenero.Text = fila["genero"].ToString();
                txtTelefono.Text = fila["telefono"].ToString();
                txtDireccion.Text = fila["direccion"].ToString();
            }
            else
            {
                MessageBox.Show("No hay registros para mostrar");
            }
        }
        //Metodo para refrescar el DataTable despues de insertar,modificar o eliminar registros
        void RefrescarDatos()
        {
            //seleccionamos todos los datos de la tabla personal
            Sql = "select * from doctores";
            //SqlDataAdapter 
            Adaptador = new SqlDataAdapter(Sql, Conexion); //pasamos los parametros al adaptador
            Tabla.Clear(); //limpiamos antes de llenar el objeto oTabla
            Adaptador.Fill(Tabla); //llenamos la tabla
        }
        public frmAltaDoctor()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox == null)
                return;

            // Elimina todos los caracteres no numéricos
            string cleaned = new string(textBox.Text.Where(char.IsDigit).ToArray());

            // Aplicar el formato
            string formatted = "";
            int length = cleaned.Length;

            if (length > 0)
                formatted += cleaned.Substring(0, Math.Min(3, length));
            if (length > 3)
                formatted += "-" + cleaned.Substring(3, Math.Min(3, length - 3));
            if (length > 6)
                formatted += "-" + cleaned.Substring(6, Math.Min(2, length - 6));
            if (length > 8)
                formatted += "-" + cleaned.Substring(8, Math.Min(2, length - 8));

            // Guardar la posición actual del cursor
            int cursorPosition = textBox.SelectionStart;

            // Actualizar el texto del TextBox
            textBox.Text = formatted;

            // Restaurar la posición del cursor
            textBox.SelectionStart = Math.Min(cursorPosition, formatted.Length);

            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);


        }
        private void button1_Click(object sender, EventArgs e)
        {
            Sql = "insert into doctores(identificador, pri_nom, seg_nom, pri_ape, seg_ape, genero, telefono, direccion) " +
                "values(@identificador,@pri_nom,@seg_nom,@pri_ape,@seg_ape,@genero,@telefono,@direccion)";

            using (SqlConnection conn = new SqlConnection("Data Source=" + Servidor + ";" +
                                                          "Initial Catalog=" + Base_Datos + ";" +
                                                          "Integrated security=true"))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(Sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@identificador", txtIdentificacion.Text);
                        cmd.Parameters.AddWithValue("@pri_nom", txtPri_nom.Text);
                        cmd.Parameters.AddWithValue("@seg_nom", txtSeg_nom.Text);
                        cmd.Parameters.AddWithValue("@pri_ape", txtPri_ape.Text);
                        cmd.Parameters.AddWithValue("@seg_ape", txtSeg_ape.Text);
                        cmd.Parameters.AddWithValue("@genero", cboGenero.Text);
                        cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                        cmd.Parameters.AddWithValue("@direccion", txtDireccion.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registro insertado");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Sql = "delete from doctores where identificador=@identificador";

            using (SqlConnection conn = new SqlConnection("Data Source=" + Servidor + ";" +
                                                          "Initial Catalog=" + Base_Datos + ";" +
                                                          "Integrated security=true"))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(Sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@identificador", txtIdentificacion.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registro eliminado");
                        
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Sql = "update doctores set pri_nom=@pri_nom, seg_nom=@seg_nom, pri_ape=@pri_ape, seg_ape=@seg_ape, genero=@genero, telefono=@telefono, direccion=@direccion where identificador=@identificador";

            using (SqlConnection conn = new SqlConnection("Data Source=" + Servidor + ";" +
                                                          "Initial Catalog=" + Base_Datos + ";" +
                                                          "Integrated security=true"))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(Sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@identificador", txtIdentificacion.Text);
                        cmd.Parameters.AddWithValue("@pri_nom", txtPri_nom.Text);
                        cmd.Parameters.AddWithValue("@seg_nom", txtSeg_nom.Text);
                        cmd.Parameters.AddWithValue("@pri_ape", txtPri_ape.Text);
                        cmd.Parameters.AddWithValue("@seg_ape", txtSeg_ape.Text);
                        cmd.Parameters.AddWithValue("@genero", cboGenero.Text);
                        cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                        cmd.Parameters.AddWithValue("@direccion", txtDireccion.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registro editado");
                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            {
                if (Tabla.Rows.Count > 0)
                {
                    int id = int.Parse(txtIdentificacion.Text);
                    DataRow[] fila = Tabla.Select(String.Format("Identificador ={0}", id)); //Buscamos la fila deseada
                    if (fila.Length > 0)//Si se encontro la fila
                    {
                        indice = Tabla.Rows.IndexOf(fila[0]); //Obtenemos el indice la fila buscada
                        //Pasamos el indice como parametro al metodo CargarDatos
                        CargarDatos(indice);
                    }
                    else
                    {
                        MessageBox.Show("El doctor que buscas no esta registrado");
                    }
                }
            }
        }

        
    
    
    }
}
