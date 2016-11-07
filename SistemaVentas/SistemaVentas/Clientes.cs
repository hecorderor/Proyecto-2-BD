using System;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace SistemaVentas
{
    public partial class Clientes : Form
    {
        
        public Clientes()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Clientes_Load(object sender, EventArgs e)
        {

        }

        private void bCancelarCliente_Click(object sender, EventArgs e)
        {
            this.Close();
            VentanaPrincipal abrirVP = new VentanaPrincipal();
            abrirVP.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bRegistrarCliente_Click(object sender, EventArgs e)
        {
            String nombreCliente = tbNombreCliente.Text;
            String direccionFisico = tbDireccionFisica.Text;
            String direccionEntrega = tbDireccionEntrega.Text;
            String codPostal = tbCodPostal.Text;
            String telefono = tbTelefono.Text;
            String credito = tbCredito.Text;
            String correo = tbCorreoCliente.Text;

            Random r = new Random();
            int aleatorio1 = r.Next(1000, 9999);
            int idCliente = aleatorio1;


            DateTime thisDay = DateTime.Today;
            DateTime dateOnly = thisDay.Date;
            String fecha = dateOnly.ToString("d");

            string datosConexion = @"Data Source=DESKTOP-LE92SRN\SQLEXPRESS;Initial Catalog= master; Integrated Security=True;";
            string insertarCliente = "insert into Cliente values( '"+nombreCliente+"', "+idCliente+", 'ISO 3155 ALFA-3','"+direccionFisico+"', '"+direccionEntrega+"', '"+codPostal+"', "+telefono+", "+credito+", '"+correo+"', '"+fecha+"')";
            StringBuilder errorMessages = new StringBuilder();

            using (SqlConnection conexion = new SqlConnection(datosConexion))
            {
                SqlCommand command = new SqlCommand(insertarCliente, conexion);

                try
                {
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    for (int i = 0; i < ex.Errors.Count; i++)
                    {
                        errorMessages.Append("Index #" + i + "\n" +
                            "Message: " + ex.Errors[i].Message + "\n" +
                            "LineNumber:: " + ex.Errors[i].LineNumber + "\n" +
                            "Source: " + ex.Errors[i].Source + "\n" +
                            "Procedure: " + ex.Errors[i].Procedure + "\n");
                    }
                    Console.WriteLine(errorMessages.ToString());
                }
            }

            MessageBox.Show("Se registró el cliente correctamente.", "Registro");
            this.Close();

            VentanaPrincipal vp = new VentanaPrincipal();
            vp.Show();
        }
    }
}    

