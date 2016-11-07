using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentas
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {
            Conexion c = new Conexion();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string pdfPath = Path.Combine(Application.StartupPath, "manual_de_usuario_ventas.pdf");
            Process.Start(pdfPath);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clientes abrirClientes = new Clientes();
            abrirClientes.Show();
            this.Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            RevisarPedido abrirRP = new RevisarPedido();
            abrirRP.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistrarPedido abrirRP = new RegistrarPedido();
            abrirRP.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ConfirmarPedido abrirCP = new ConfirmarPedido();
            abrirCP.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Facturacion abrirFact = new Facturacion();
            abrirFact.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CuentasCobrar abrirCC = new CuentasCobrar();
            abrirCC.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ReporteVentasClentes abrirRVC = new ReporteVentasClentes();
            abrirRVC.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ReporteVentasProducto abrirRVP = new ReporteVentasProducto();
            abrirRVP.Show();
            this.Hide(); 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Catalogo abrirCat = new Catalogo();
            abrirCat.Show();
            this.Hide();
        }
    }
}
