using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentas
{
    public partial class RevisarPedido : Form
    {
        Correo correo = new Correo();
        public RevisarPedido()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            VentanaPrincipal abrirVP = new VentanaPrincipal();
            abrirVP.Show();
        }

        private void RevisarPedido_Load(object sender, EventArgs e)
        {
            Conexion c = new Conexion();
            c.llenarItemsEjVentas(cbEjecutivo);
            
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbEjecutivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Conexion c = new Conexion();
            String ejecutivo = cbEjecutivo.SelectedItem.ToString();
            c.cargarPedidos(ejecutivo, dgvPedidos);
            c.llenarItemsPedidos(ejecutivo, cbPedidoSelect);
        }

        private void cbPedidoSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexion c = new Conexion();
            String idfactura = cbPedidoSelect.SelectedItem.ToString();
            c.CambiarEstadoPedido(idfactura);
            MessageBox.Show("Pedido revisado!");
            this.Close();
            VentanaPrincipal VP = new VentanaPrincipal();
            VP.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Conexion c = new Conexion();
            String idFactura = cbPedidoSelect.SelectedItem.ToString();
            c.CambiarEstadoCancelado(idFactura);
            correo.enviarCorreo("sistema.ventasp2@gmail.com", "proyecto2", "Su pedido Fue cancelado", "Estado del Pedido", "hellencorderorobles@gmail.com");
            MessageBox.Show("Pedido cancelado!");
            this.Close();
            VentanaPrincipal VP = new VentanaPrincipal();
            VP.Show();
        }
    }
}
