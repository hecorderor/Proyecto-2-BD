namespace SistemaVentas
{
    partial class Facturacion
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
            this.CancelarFact = new System.Windows.Forms.Button();
            this.dgPedidosConfirmados = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPedidosFacturar = new System.Windows.Forms.ComboBox();
            this.bFacturar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgPedidosConfirmados)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelarFact
            // 
            this.CancelarFact.Location = new System.Drawing.Point(234, 300);
            this.CancelarFact.Name = "CancelarFact";
            this.CancelarFact.Size = new System.Drawing.Size(81, 27);
            this.CancelarFact.TabIndex = 0;
            this.CancelarFact.Text = "Cancelar";
            this.CancelarFact.UseVisualStyleBackColor = true;
            this.CancelarFact.Click += new System.EventHandler(this.CancelarFact_Click);
            // 
            // dgPedidosConfirmados
            // 
            this.dgPedidosConfirmados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPedidosConfirmados.Location = new System.Drawing.Point(32, 22);
            this.dgPedidosConfirmados.Name = "dgPedidosConfirmados";
            this.dgPedidosConfirmados.Size = new System.Drawing.Size(368, 159);
            this.dgPedidosConfirmados.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Seleccionar pedido a  facturar";
            // 
            // cbPedidosFacturar
            // 
            this.cbPedidosFacturar.FormattingEnabled = true;
            this.cbPedidosFacturar.Location = new System.Drawing.Point(209, 207);
            this.cbPedidosFacturar.Name = "cbPedidosFacturar";
            this.cbPedidosFacturar.Size = new System.Drawing.Size(178, 21);
            this.cbPedidosFacturar.TabIndex = 4;
            // 
            // bFacturar
            // 
            this.bFacturar.Location = new System.Drawing.Point(115, 300);
            this.bFacturar.Name = "bFacturar";
            this.bFacturar.Size = new System.Drawing.Size(92, 27);
            this.bFacturar.TabIndex = 5;
            this.bFacturar.Text = "Facturar";
            this.bFacturar.UseVisualStyleBackColor = true;
            this.bFacturar.Click += new System.EventHandler(this.bFacturar_Click);
            // 
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 353);
            this.Controls.Add(this.bFacturar);
            this.Controls.Add(this.cbPedidosFacturar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgPedidosConfirmados);
            this.Controls.Add(this.CancelarFact);
            this.Name = "Facturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturacion";
            this.Load += new System.EventHandler(this.Facturacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPedidosConfirmados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelarFact;
        private System.Windows.Forms.DataGridView dgPedidosConfirmados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbPedidosFacturar;
        private System.Windows.Forms.Button bFacturar;
    }
}