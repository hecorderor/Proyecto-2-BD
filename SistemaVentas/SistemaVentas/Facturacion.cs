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
    public partial class Facturacion : Form
    {
        public Facturacion()
        {
            InitializeComponent();
        }

        private void CancelarFact_Click(object sender, EventArgs e)
        {
            this.Close();
            VentanaPrincipal abrir = new VentanaPrincipal();
            abrir.Show();
        }

        private void Facturacion_Load(object sender, EventArgs e)
        {
            Conexion c = new Conexion();
            c.cargarPedidosConfirmados(dgPedidosConfirmados);
            c.llenarItemsConfirmados(cbPedidosFacturar);
        }

        private void bFacturar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pedido facturado");
            this.Close();
            VentanaPrincipal VP = new VentanaPrincipal();
            VP.Show();
        }
    }
}
