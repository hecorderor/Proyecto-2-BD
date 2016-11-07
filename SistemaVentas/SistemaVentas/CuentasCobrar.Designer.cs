namespace SistemaVentas
{
    partial class CuentasCobrar
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
            this.CancelarCC = new System.Windows.Forms.Button();
            this.dgCuentasCobrar = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgCuentasCobrar)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelarCC
            // 
            this.CancelarCC.Location = new System.Drawing.Point(283, 314);
            this.CancelarCC.Name = "CancelarCC";
            this.CancelarCC.Size = new System.Drawing.Size(99, 23);
            this.CancelarCC.TabIndex = 0;
            this.CancelarCC.Text = "Salir";
            this.CancelarCC.UseVisualStyleBackColor = true;
            this.CancelarCC.Click += new System.EventHandler(this.CancelarCC_Click);
            // 
            // dgCuentasCobrar
            // 
            this.dgCuentasCobrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCuentasCobrar.Location = new System.Drawing.Point(36, 25);
            this.dgCuentasCobrar.Name = "dgCuentasCobrar";
            this.dgCuentasCobrar.Size = new System.Drawing.Size(414, 160);
            this.dgCuentasCobrar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione la cuenta a cancelar";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(246, 219);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(146, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cancelar cuenta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CuentasCobrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 358);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgCuentasCobrar);
            this.Controls.Add(this.CancelarCC);
            this.Name = "CuentasCobrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuentas por cobrar";
            ((System.ComponentModel.ISupportInitialize)(this.dgCuentasCobrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelarCC;
        private System.Windows.Forms.DataGridView dgCuentasCobrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
    }
}