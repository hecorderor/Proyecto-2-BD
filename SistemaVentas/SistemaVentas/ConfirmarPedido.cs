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
    public partial class ConfirmarPedido : Form
    {
        public ConfirmarPedido()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            VentanaPrincipal abrir = new VentanaPrincipal();
            abrir.Show();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Conexion c = new Conexion();
            c.cargarPedidosRevisados(dgvPedidosConf);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Conexion c = new Conexion();
            c.cargarPedidosTodos(dgvPedidosConf);
        }

        private void ConfirmarPedido_Load(object sender, EventArgs e)
        {
            Conexion c = new Conexion();
            c.llenarItemsRevisados(cbConfir);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexion c = new Conexion();
            String idfactura = cbConfir.SelectedItem.ToString();
            if (rbConfirmar.Checked)
            {
                c.CambiarEstadoConfirmado(idfactura);
            }
            else if (rbRechazar.Checked)
            {
                c.CambiarEstadoRechazado(idfactura);
            }
            else if (rbReprocesar.Checked)
            {
                c.CambiarEstadoReprocesadp(idfactura);
            }
            MessageBox.Show("Se cambió el estado del pedido correctamente.");
            this.Close();
            VentanaPrincipal VP = new VentanaPrincipal();
            VP.Show();
            
        }

        private void cbConfir_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
