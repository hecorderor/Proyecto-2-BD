namespace SistemaVentas
{
    partial class Clientes
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
            this.LNombreCliente = new System.Windows.Forms.Label();
            this.LPais = new System.Windows.Forms.Label();
            this.LDireccionFisica = new System.Windows.Forms.Label();
            this.LCodigoPostal = new System.Windows.Forms.Label();
            this.LTelefono = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LDirecEntrega = new System.Windows.Forms.Label();
            this.LCorreoCliente = new System.Windows.Forms.Label();
            this.bRegistrarCliente = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bCancelarCliente = new System.Windows.Forms.Button();
            this.tbNombreCliente = new System.Windows.Forms.TextBox();
            this.tbPais = new System.Windows.Forms.TextBox();
            this.tbDireccionFisica = new System.Windows.Forms.TextBox();
            this.tbCodPostal = new System.Windows.Forms.TextBox();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.tbCredito = new System.Windows.Forms.TextBox();
            this.tbDireccionEntrega = new System.Windows.Forms.TextBox();
            this.tbCorreoCliente = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LNombreCliente
            // 
            this.LNombreCliente.AutoSize = true;
            this.LNombreCliente.Location = new System.Drawing.Point(29, 59);
            this.LNombreCliente.Name = "LNombreCliente";
            this.LNombreCliente.Size = new System.Drawing.Size(47, 13);
            this.LNombreCliente.TabIndex = 0;
            this.LNombreCliente.Text = "Nombre:";
            // 
            // LPais
            // 
            this.LPais.AutoSize = true;
            this.LPais.Location = new System.Drawing.Point(29, 88);
            this.LPais.Name = "LPais";
            this.LPais.Size = new System.Drawing.Size(32, 13);
            this.LPais.TabIndex = 1;
            this.LPais.Text = "País:";
            // 
            // LDireccionFisica
            // 
            this.LDireccionFisica.AutoSize = true;
            this.LDireccionFisica.Location = new System.Drawing.Point(29, 118);
            this.LDireccionFisica.Name = "LDireccionFisica";
            this.LDireccionFisica.Size = new System.Drawing.Size(84, 13);
            this.LDireccionFisica.TabIndex = 2;
            this.LDireccionFisica.Text = "Dirección física:";
            // 
            // LCodigoPostal
            // 
            this.LCodigoPostal.AutoSize = true;
            this.LCodigoPostal.Location = new System.Drawing.Point(29, 177);
            this.LCodigoPostal.Name = "LCodigoPostal";
            this.LCodigoPostal.Size = new System.Drawing.Size(75, 13);
            this.LCodigoPostal.TabIndex = 3;
            this.LCodigoPostal.Text = "Código Postal:";
            // 
            // LTelefono
            // 
            this.LTelefono.AutoSize = true;
            this.LTelefono.Location = new System.Drawing.Point(29, 207);
            this.LTelefono.Name = "LTelefono";
            this.LTelefono.Size = new System.Drawing.Size(52, 13);
            this.LTelefono.TabIndex = 4;
            this.LTelefono.Text = "Teléfono:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Límite de crédito:";
            // 
            // LDirecEntrega
            // 
            this.LDirecEntrega.AutoSize = true;
            this.LDirecEntrega.Location = new System.Drawing.Point(29, 147);
            this.LDirecEntrega.Name = "LDirecEntrega";
            this.LDirecEntrega.Size = new System.Drawing.Size(121, 13);
            this.LDirecEntrega.TabIndex = 6;
            this.LDirecEntrega.Text = "Dirección para entregar:";
            // 
            // LCorreoCliente
            // 
            this.LCorreoCliente.AutoSize = true;
            this.LCorreoCliente.Location = new System.Drawing.Point(29, 271);
            this.LCorreoCliente.Name = "LCorreoCliente";
            this.LCorreoCliente.Size = new System.Drawing.Size(96, 13);
            this.LCorreoCliente.TabIndex = 7;
            this.LCorreoCliente.Text = "Correo electrónico:";
            // 
            // bRegistrarCliente
            // 
            this.bRegistrarCliente.Location = new System.Drawing.Point(75, 313);
            this.bRegistrarCliente.Name = "bRegistrarCliente";
            this.bRegistrarCliente.Size = new System.Drawing.Size(75, 23);
            this.bRegistrarCliente.TabIndex = 11;
            this.bRegistrarCliente.Text = "Registrar";
            this.bRegistrarCliente.UseVisualStyleBackColor = true;
            this.bRegistrarCliente.Click += new System.EventHandler(this.bRegistrarCliente_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ingrese los siguientes datos";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // bCancelarCliente
            // 
            this.bCancelarCliente.BackColor = System.Drawing.SystemColors.HighlightText;
            this.bCancelarCliente.Location = new System.Drawing.Point(156, 313);
            this.bCancelarCliente.Name = "bCancelarCliente";
            this.bCancelarCliente.Size = new System.Drawing.Size(85, 23);
            this.bCancelarCliente.TabIndex = 13;
            this.bCancelarCliente.Text = "Cancelar";
            this.bCancelarCliente.UseVisualStyleBackColor = false;
            this.bCancelarCliente.Click += new System.EventHandler(this.bCancelarCliente_Click);
            // 
            // tbNombreCliente
            // 
            this.tbNombreCliente.Location = new System.Drawing.Point(163, 56);
            this.tbNombreCliente.MaxLength = 60;
            this.tbNombreCliente.Name = "tbNombreCliente";
            this.tbNombreCliente.Size = new System.Drawing.Size(124, 20);
            this.tbNombreCliente.TabIndex = 14;
            this.tbNombreCliente.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbPais
            // 
            this.tbPais.Location = new System.Drawing.Point(163, 85);
            this.tbPais.Name = "tbPais";
            this.tbPais.Size = new System.Drawing.Size(123, 20);
            this.tbPais.TabIndex = 15;
            // 
            // tbDireccionFisica
            // 
            this.tbDireccionFisica.Location = new System.Drawing.Point(163, 118);
            this.tbDireccionFisica.Name = "tbDireccionFisica";
            this.tbDireccionFisica.Size = new System.Drawing.Size(123, 20);
            this.tbDireccionFisica.TabIndex = 16;
            // 
            // tbCodPostal
            // 
            this.tbCodPostal.Location = new System.Drawing.Point(164, 174);
            this.tbCodPostal.Name = "tbCodPostal";
            this.tbCodPostal.Size = new System.Drawing.Size(124, 20);
            this.tbCodPostal.TabIndex = 17;
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(164, 204);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(123, 20);
            this.tbTelefono.TabIndex = 18;
            // 
            // tbCredito
            // 
            this.tbCredito.Location = new System.Drawing.Point(164, 236);
            this.tbCredito.Name = "tbCredito";
            this.tbCredito.Size = new System.Drawing.Size(123, 20);
            this.tbCredito.TabIndex = 19;
            // 
            // tbDireccionEntrega
            // 
            this.tbDireccionEntrega.Location = new System.Drawing.Point(164, 147);
            this.tbDireccionEntrega.Name = "tbDireccionEntrega";
            this.tbDireccionEntrega.Size = new System.Drawing.Size(124, 20);
            this.tbDireccionEntrega.TabIndex = 20;
            // 
            // tbCorreoCliente
            // 
            this.tbCorreoCliente.Location = new System.Drawing.Point(163, 271);
            this.tbCorreoCliente.Name = "tbCorreoCliente";
            this.tbCorreoCliente.Size = new System.Drawing.Size(123, 20);
            this.tbCorreoCliente.TabIndex = 21;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 364);
            this.Controls.Add(this.tbCorreoCliente);
            this.Controls.Add(this.tbDireccionEntrega);
            this.Controls.Add(this.tbCredito);
            this.Controls.Add(this.tbTelefono);
            this.Controls.Add(this.tbCodPostal);
            this.Controls.Add(this.tbDireccionFisica);
            this.Controls.Add(this.tbPais);
            this.Controls.Add(this.tbNombreCliente);
            this.Controls.Add(this.bCancelarCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bRegistrarCliente);
            this.Controls.Add(this.LCorreoCliente);
            this.Controls.Add(this.LDirecEntrega);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LTelefono);
            this.Controls.Add(this.LCodigoPostal);
            this.Controls.Add(this.LDireccionFisica);
            this.Controls.Add(this.LPais);
            this.Controls.Add(this.LNombreCliente);
            this.Name = "Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LNombreCliente;
        private System.Windows.Forms.Label LPais;
        private System.Windows.Forms.Label LDireccionFisica;
        private System.Windows.Forms.Label LCodigoPostal;
        private System.Windows.Forms.Label LTelefono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LDirecEntrega;
        private System.Windows.Forms.Label LCorreoCliente;
        private System.Windows.Forms.Button bRegistrarCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bCancelarCliente;
        private System.Windows.Forms.TextBox tbNombreCliente;
        private System.Windows.Forms.TextBox tbPais;
        private System.Windows.Forms.TextBox tbDireccionFisica;
        private System.Windows.Forms.TextBox tbCodPostal;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.TextBox tbCredito;
        private System.Windows.Forms.TextBox tbDireccionEntrega;
        private System.Windows.Forms.TextBox tbCorreoCliente;
    }
}