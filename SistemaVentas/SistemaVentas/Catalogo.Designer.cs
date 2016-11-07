namespace SistemaVentas
{
    partial class Catalogo
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
            this.SalirCP = new System.Windows.Forms.Button();
            this.dgCatalogo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgCatalogo)).BeginInit();
            this.SuspendLayout();
            // 
            // SalirCP
            // 
            this.SalirCP.Location = new System.Drawing.Point(147, 274);
            this.SalirCP.Name = "SalirCP";
            this.SalirCP.Size = new System.Drawing.Size(123, 39);
            this.SalirCP.TabIndex = 0;
            this.SalirCP.Text = "Salir";
            this.SalirCP.UseVisualStyleBackColor = true;
            this.SalirCP.Click += new System.EventHandler(this.SalirCP_Click);
            // 
            // dgCatalogo
            // 
            this.dgCatalogo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCatalogo.Location = new System.Drawing.Point(12, 12);
            this.dgCatalogo.Name = "dgCatalogo";
            this.dgCatalogo.Size = new System.Drawing.Size(386, 230);
            this.dgCatalogo.TabIndex = 1;
            this.dgCatalogo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCatalogo_CellContentClick);
            // 
            // Catalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 325);
            this.Controls.Add(this.dgCatalogo);
            this.Controls.Add(this.SalirCP);
            this.Name = "Catalogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catálogo de productos";
            this.Load += new System.EventHandler(this.Catalogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCatalogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SalirCP;
        private System.Windows.Forms.DataGridView dgCatalogo;
    }
}