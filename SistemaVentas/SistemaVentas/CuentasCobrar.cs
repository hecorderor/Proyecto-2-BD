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
    public partial class CuentasCobrar : Form
    {
        public CuentasCobrar()
        {
            InitializeComponent();
        }

        private void CancelarCC_Click(object sender, EventArgs e)
        {
            this.Close();
            VentanaPrincipal abrir = new VentanaPrincipal();
            abrir.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cuenta cancelada");
            this.Close();
            VentanaPrincipal VP = new VentanaPrincipal();
            VP.Show();
        }
    }
}
