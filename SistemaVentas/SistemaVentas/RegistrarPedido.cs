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

namespace SistemaVentas
{
    public partial class RegistrarPedido : Form
    {
        public RegistrarPedido()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void CancelarRP_Click(object sender, EventArgs e)
        {
            this.Close();
            VentanaPrincipal abrir = new VentanaPrincipal();
            abrir.Show();
        }

        

        private void bRegistrarPedido_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int aleatorio1 = r.Next(10000, 99999);
            int idPedido = aleatorio1;

            DateTime thisDay = DateTime.Today;
            DateTime dateOnly = thisDay.Date;
            String fechaPedido = dateOnly.ToString("d");

            Object idCliente = cbNombreCliente.SelectedItem;
            String CondPago = cbCondicionPago.SelectedItem.ToString();
            String idEjV = cbEjVentas.SelectedItem.ToString();
            String fechaEntrega = dtPEntregaProducto.Value.ToString("MM-dd-yyyy");
            String cantidad = tbCantidadProducto.Text;
            String descripcion = cbProducto.SelectedItem.ToString();


            String datosConexion = @"Data Source=DESKTOP-LE92SRN\SQLEXPRESS;Initial Catalog= master; Integrated Security=True;";
            string insertarPedido = "insert into Pedidos values("+idPedido+"2016, '"+fechaPedido+"', "+idCliente+", '"+CondPago+"', "+idEjV+", '"+fechaEntrega+"', "+cantidad+", 3, 3, 2, 4, 'Registrado', '"+descripcion+"')";
            StringBuilder errorMessages = new StringBuilder();

            using (SqlConnection conexion = new SqlConnection(datosConexion)) 
            {
                SqlCommand command = new SqlCommand(insertarPedido, conexion);

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
                MessageBox.Show("Su pedido se regidtró correctamente");
                this.Close();
                VentanaPrincipal VP = new VentanaPrincipal();
                VP.Show();
            }
        }

        private void cbCondicionPago_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void cbNombreCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void RegistrarPedido_Load(object sender, EventArgs e)
        {
            Conexion c = new Conexion();
            c.llenarItemsClientes(cbNombreCliente);
            c.llenarItemsEjVentas(cbEjVentas);
            c.llenarItemsProductos(cbProducto);
        }
    }
}
