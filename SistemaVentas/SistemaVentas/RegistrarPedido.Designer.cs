namespace SistemaVentas
{
    partial class RegistrarPedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbProducto = new System.Windows.Forms.ComboBox();
            this.bRegistrarPedido = new System.Windows.Forms.Button();
            this.CancelarRP = new System.Windows.Forms.Button();
            this.dtPEntregaProducto = new System.Windows.Forms.DateTimePicker();
            this.tbCantidadProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCondicionPago = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbNombreCliente = new System.Windows.Forms.ComboBox();
            this.cbEjVentas = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID Cliente:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ejecutivo de venta:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fecha de entrega:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Cantidad:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Producto:";
            // 
            // cbProducto
            // 
            this.cbProducto.FormattingEnabled = true;
            this.cbProducto.Location = new System.Drawing.Point(178, 135);
            this.cbProducto.Name = "cbProducto";
            this.cbProducto.Size = new System.Drawing.Size(122, 21);
            this.cbProducto.TabIndex = 12;
            // 
            // bRegistrarPedido
            // 
            this.bRegistrarPedido.Location = new System.Drawing.Point(93, 256);
            this.bRegistrarPedido.Name = "bRegistrarPedido";
            this.bRegistrarPedido.Size = new System.Drawing.Size(82, 29);
            this.bRegistrarPedido.TabIndex = 14;
            this.bRegistrarPedido.Text = "Registrar";
            this.bRegistrarPedido.UseVisualStyleBackColor = true;
            this.bRegistrarPedido.Click += new System.EventHandler(this.bRegistrarPedido_Click);
            // 
            // CancelarRP
            // 
            this.CancelarRP.Location = new System.Drawing.Point(203, 256);
            this.CancelarRP.Name = "CancelarRP";
            this.CancelarRP.Size = new System.Drawing.Size(85, 29);
            this.CancelarRP.TabIndex = 15;
            this.CancelarRP.Text = "Cancelar";
            this.CancelarRP.UseVisualStyleBackColor = true;
            this.CancelarRP.Click += new System.EventHandler(this.CancelarRP_Click);
            // 
            // dtPEntregaProducto
            // 
            this.dtPEntregaProducto.Location = new System.Drawing.Point(178, 98);
            this.dtPEntregaProducto.Name = "dtPEntregaProducto";
            this.dtPEntregaProducto.Size = new System.Drawing.Size(224, 20);
            this.dtPEntregaProducto.TabIndex = 17;
            // 
            // tbCantidadProducto
            // 
            this.tbCantidadProducto.Location = new System.Drawing.Point(178, 174);
            this.tbCantidadProducto.Name = "tbCantidadProducto";
            this.tbCantidadProducto.Size = new System.Drawing.Size(64, 20);
            this.tbCantidadProducto.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Coondición de pago:";
            // 
            // cbCondicionPago
            // 
            this.cbCondicionPago.FormattingEnabled = true;
            this.cbCondicionPago.Items.AddRange(new object[] {
            "Pago a 15 días",
            "Pago a 30 días",
            "Pago a 3 meses",
            "Pago a 6 meses",
            "Pago a 1 año"});
            this.cbCondicionPago.Location = new System.Drawing.Point(178, 207);
            this.cbCondicionPago.Name = "cbCondicionPago";
            this.cbCondicionPago.Size = new System.Drawing.Size(110, 21);
            this.cbCondicionPago.TabIndex = 21;
            this.cbCondicionPago.SelectedIndexChanged += new System.EventHandler(this.cbCondicionPago_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 22;
            // 
            // cbNombreCliente
            // 
            this.cbNombreCliente.FormattingEnabled = true;
            this.cbNombreCliente.Location = new System.Drawing.Point(178, 28);
            this.cbNombreCliente.Name = "cbNombreCliente";
            this.cbNombreCliente.Size = new System.Drawing.Size(121, 21);
            this.cbNombreCliente.TabIndex = 23;
            this.cbNombreCliente.SelectedIndexChanged += new System.EventHandler(this.cbNombreCliente_SelectedIndexChanged);
            // 
            // cbEjVentas
            // 
            this.cbEjVentas.FormattingEnabled = true;
            this.cbEjVentas.Location = new System.Drawing.Point(178, 62);
            this.cbEjVentas.Name = "cbEjVentas";
            this.cbEjVentas.Size = new System.Drawing.Size(121, 21);
            this.cbEjVentas.TabIndex = 24;
            // 
            // RegistrarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 304);
            this.Controls.Add(this.cbEjVentas);
            this.Controls.Add(this.cbNombreCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCondicionPago);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCantidadProducto);
            this.Controls.Add(this.dtPEntregaProducto);
            this.Controls.Add(this.CancelarRP);
            this.Controls.Add(this.bRegistrarPedido);
            this.Controls.Add(this.cbProducto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Name = "RegistrarPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar pedido";
            this.Load += new System.EventHandler(this.RegistrarPedido_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbProducto;
        private System.Windows.Forms.Button bRegistrarPedido;
        private System.Windows.Forms.Button CancelarRP;
        private System.Windows.Forms.DateTimePicker dtPEntregaProducto;
        private System.Windows.Forms.TextBox tbCantidadProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCondicionPago;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbNombreCliente;
        private System.Windows.Forms.ComboBox cbEjVentas;
    }
}