namespace ProyectoFinalProg3
{
    partial class Retiro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Retiro));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRetirar = new System.Windows.Forms.Button();
            this.lblNoCuenta = new System.Windows.Forms.Label();
            this.txtNoCuenta = new System.Windows.Forms.TextBox();
            this.txtCedulaoPasaporte = new System.Windows.Forms.TextBox();
            this.lblCedulaoPasaporte = new System.Windows.Forms.Label();
            this.lblRetiro = new System.Windows.Forms.Label();
            this.lblBankintoch = new System.Windows.Forms.Label();
            this.lblMontoaRetirar = new System.Windows.Forms.Label();
            this.txtMontoaRetirar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Font = new System.Drawing.Font("Stencil", 15F);
            this.btnCancelar.Location = new System.Drawing.Point(869, 491);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(164, 38);
            this.btnCancelar.TabIndex = 32;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnRetirar
            // 
            this.btnRetirar.BackColor = System.Drawing.Color.Transparent;
            this.btnRetirar.Font = new System.Drawing.Font("Stencil", 15F);
            this.btnRetirar.Location = new System.Drawing.Point(684, 491);
            this.btnRetirar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRetirar.Name = "btnRetirar";
            this.btnRetirar.Size = new System.Drawing.Size(171, 41);
            this.btnRetirar.TabIndex = 31;
            this.btnRetirar.Text = "Retirar";
            this.btnRetirar.UseVisualStyleBackColor = false;
            this.btnRetirar.Click += new System.EventHandler(this.BtnRetirar_Click);
            // 
            // lblNoCuenta
            // 
            this.lblNoCuenta.AutoSize = true;
            this.lblNoCuenta.BackColor = System.Drawing.Color.Transparent;
            this.lblNoCuenta.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoCuenta.Location = new System.Drawing.Point(284, 351);
            this.lblNoCuenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNoCuenta.Name = "lblNoCuenta";
            this.lblNoCuenta.Size = new System.Drawing.Size(122, 24);
            this.lblNoCuenta.TabIndex = 26;
            this.lblNoCuenta.Text = "No. Cuenta";
            // 
            // txtNoCuenta
            // 
            this.txtNoCuenta.Location = new System.Drawing.Point(524, 353);
            this.txtNoCuenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNoCuenta.Name = "txtNoCuenta";
            this.txtNoCuenta.Size = new System.Drawing.Size(213, 22);
            this.txtNoCuenta.TabIndex = 25;
            // 
            // txtCedulaoPasaporte
            // 
            this.txtCedulaoPasaporte.Location = new System.Drawing.Point(524, 286);
            this.txtCedulaoPasaporte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCedulaoPasaporte.Name = "txtCedulaoPasaporte";
            this.txtCedulaoPasaporte.Size = new System.Drawing.Size(213, 22);
            this.txtCedulaoPasaporte.TabIndex = 24;
            // 
            // lblCedulaoPasaporte
            // 
            this.lblCedulaoPasaporte.AutoSize = true;
            this.lblCedulaoPasaporte.BackColor = System.Drawing.Color.Transparent;
            this.lblCedulaoPasaporte.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedulaoPasaporte.Location = new System.Drawing.Point(284, 287);
            this.lblCedulaoPasaporte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCedulaoPasaporte.Name = "lblCedulaoPasaporte";
            this.lblCedulaoPasaporte.Size = new System.Drawing.Size(219, 24);
            this.lblCedulaoPasaporte.TabIndex = 23;
            this.lblCedulaoPasaporte.Text = "Cedula o Pasaporte";
            // 
            // lblRetiro
            // 
            this.lblRetiro.AutoSize = true;
            this.lblRetiro.BackColor = System.Drawing.Color.Transparent;
            this.lblRetiro.Font = new System.Drawing.Font("Stencil", 20F);
            this.lblRetiro.Location = new System.Drawing.Point(472, 144);
            this.lblRetiro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRetiro.Name = "lblRetiro";
            this.lblRetiro.Size = new System.Drawing.Size(140, 40);
            this.lblRetiro.TabIndex = 22;
            this.lblRetiro.Text = "Retiro";
            // 
            // lblBankintoch
            // 
            this.lblBankintoch.AutoSize = true;
            this.lblBankintoch.BackColor = System.Drawing.Color.Transparent;
            this.lblBankintoch.Font = new System.Drawing.Font("Stencil", 30.75F);
            this.lblBankintoch.Location = new System.Drawing.Point(364, 47);
            this.lblBankintoch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBankintoch.Name = "lblBankintoch";
            this.lblBankintoch.Size = new System.Drawing.Size(356, 61);
            this.lblBankintoch.TabIndex = 21;
            this.lblBankintoch.Text = "BANKINTOCH";
            // 
            // lblMontoaRetirar
            // 
            this.lblMontoaRetirar.AutoSize = true;
            this.lblMontoaRetirar.BackColor = System.Drawing.Color.Transparent;
            this.lblMontoaRetirar.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoaRetirar.Location = new System.Drawing.Point(284, 416);
            this.lblMontoaRetirar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMontoaRetirar.Name = "lblMontoaRetirar";
            this.lblMontoaRetirar.Size = new System.Drawing.Size(185, 24);
            this.lblMontoaRetirar.TabIndex = 34;
            this.lblMontoaRetirar.Text = "Monto a Retirar";
            // 
            // txtMontoaRetirar
            // 
            this.txtMontoaRetirar.Location = new System.Drawing.Point(524, 415);
            this.txtMontoaRetirar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMontoaRetirar.Name = "txtMontoaRetirar";
            this.txtMontoaRetirar.Size = new System.Drawing.Size(213, 22);
            this.txtMontoaRetirar.TabIndex = 35;
            // 
            // Retiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.txtMontoaRetirar);
            this.Controls.Add(this.lblMontoaRetirar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRetirar);
            this.Controls.Add(this.lblNoCuenta);
            this.Controls.Add(this.txtNoCuenta);
            this.Controls.Add(this.txtCedulaoPasaporte);
            this.Controls.Add(this.lblCedulaoPasaporte);
            this.Controls.Add(this.lblRetiro);
            this.Controls.Add(this.lblBankintoch);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Retiro";
            this.Text = "Retiro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRetirar;
        private System.Windows.Forms.Label lblNoCuenta;
        private System.Windows.Forms.TextBox txtNoCuenta;
        private System.Windows.Forms.TextBox txtCedulaoPasaporte;
        private System.Windows.Forms.Label lblCedulaoPasaporte;
        private System.Windows.Forms.Label lblRetiro;
        private System.Windows.Forms.Label lblBankintoch;
        private System.Windows.Forms.Label lblMontoaRetirar;
        private System.Windows.Forms.TextBox txtMontoaRetirar;
    }
}