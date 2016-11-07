namespace SistemaVentas
{
    partial class ReporteVentasClentes
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
            this.CancelarRVC = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelarRVC
            // 
            this.CancelarRVC.Location = new System.Drawing.Point(161, 189);
            this.CancelarRVC.Name = "CancelarRVC";
            this.CancelarRVC.Size = new System.Drawing.Size(168, 42);
            this.CancelarRVC.TabIndex = 0;
            this.CancelarRVC.Text = "Cancelar";
            this.CancelarRVC.UseVisualStyleBackColor = true;
            this.CancelarRVC.Click += new System.EventHandler(this.CancelarRVC_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(451, 152);
            this.dataGridView1.TabIndex = 1;
            // 
            // ReporteVentasClentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 261);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CancelarRVC);
            this.Name = "ReporteVentasClentes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadíaticas de ventas por cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CancelarRVC;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}