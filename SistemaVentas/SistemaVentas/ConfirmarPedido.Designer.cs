namespace SistemaVentas
{
    partial class ConfirmarPedido
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.dgvPedidosConf = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbConfir = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.rbConfirmar = new System.Windows.Forms.RadioButton();
            this.rbRechazar = new System.Windows.Forms.RadioButton();
            this.rbReprocesar = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidosConf)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(88, 33);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(111, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Todos los pedidos";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(269, 33);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(127, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Pedidos por confirmar";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // dgvPedidosConf
            // 
            this.dgvPedidosConf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidosConf.Location = new System.Drawing.Point(12, 87);
            this.dgvPedidosConf.Name = "dgvPedidosConf";
            this.dgvPedidosConf.Size = new System.Drawing.Size(456, 205);
            this.dgvPedidosConf.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleccionar pedido:";
            // 
            // cbConfir
            // 
            this.cbConfir.FormattingEnabled = true;
            this.cbConfir.Location = new System.Drawing.Point(12, 340);
            this.cbConfir.Name = "cbConfir";
            this.cbConfir.Size = new System.Drawing.Size(121, 21);
            this.cbConfir.TabIndex = 4;
            this.cbConfir.SelectedIndexChanged += new System.EventHandler(this.cbConfir_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(147, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 26);
            this.button1.TabIndex = 5;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(269, 402);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 24);
            this.button2.TabIndex = 6;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rbConfirmar
            // 
            this.rbConfirmar.AutoSize = true;
            this.rbConfirmar.Location = new System.Drawing.Point(188, 306);
            this.rbConfirmar.Name = "rbConfirmar";
            this.rbConfirmar.Size = new System.Drawing.Size(69, 17);
            this.rbConfirmar.TabIndex = 7;
            this.rbConfirmar.TabStop = true;
            this.rbConfirmar.Text = "Confirmar";
            this.rbConfirmar.UseVisualStyleBackColor = true;
            this.rbConfirmar.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rbRechazar
            // 
            this.rbRechazar.AutoSize = true;
            this.rbRechazar.Location = new System.Drawing.Point(254, 329);
            this.rbRechazar.Name = "rbRechazar";
            this.rbRechazar.Size = new System.Drawing.Size(71, 17);
            this.rbRechazar.TabIndex = 8;
            this.rbRechazar.TabStop = true;
            this.rbRechazar.Text = "Rechazar";
            this.rbRechazar.UseVisualStyleBackColor = true;
            this.rbRechazar.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // rbReprocesar
            // 
            this.rbReprocesar.AutoSize = true;
            this.rbReprocesar.Location = new System.Drawing.Point(336, 344);
            this.rbReprocesar.Name = "rbReprocesar";
            this.rbReprocesar.Size = new System.Drawing.Size(80, 17);
            this.rbReprocesar.TabIndex = 9;
            this.rbReprocesar.TabStop = true;
            this.rbReprocesar.Text = "Reprocesar";
            this.rbReprocesar.UseVisualStyleBackColor = true;
            // 
            // ConfirmarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 438);
            this.Controls.Add(this.rbReprocesar);
            this.Controls.Add(this.rbRechazar);
            this.Controls.Add(this.rbConfirmar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbConfir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPedidosConf);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Name = "ConfirmarPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirmar pedido";
            this.Load += new System.EventHandler(this.ConfirmarPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidosConf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.DataGridView dgvPedidosConf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbConfir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton rbConfirmar;
        private System.Windows.Forms.RadioButton rbRechazar;
        private System.Windows.Forms.RadioButton rbReprocesar;
    }
}