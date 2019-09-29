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
            this.btnCancelar.Location = new System.Drawing.Point(652, 399);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(123, 31);
            this.btnCancelar.TabIndex = 32;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnRetirar
            // 
            this.btnRetirar.BackColor = System.Drawing.Color.Transparent;
            this.btnRetirar.Font = new System.Drawing.Font("Stencil", 15F);
            this.btnRetirar.Location = new System.Drawing.Point(513, 399);
            this.btnRetirar.Name = "btnRetirar";
            this.btnRetirar.Size = new System.Drawing.Size(128, 33);
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
            this.lblNoCuenta.Location = new System.Drawing.Point(213, 285);
            this.lblNoCuenta.Name = "lblNoCuenta";
            this.lblNoCuenta.Size = new System.Drawing.Size(99, 19);
            this.lblNoCuenta.TabIndex = 26;
            this.lblNoCuenta.Text = "No. Cuenta";
            // 
            // txtNoCuenta
            // 
            this.txtNoCuenta.Location = new System.Drawing.Point(337, 285);
            this.txtNoCuenta.Name = "txtNoCuenta";
            this.txtNoCuenta.Size = new System.Drawing.Size(161, 20);
            this.txtNoCuenta.TabIndex = 25;
            // 
            // txtCedulaoPasaporte
            // 
            this.txtCedulaoPasaporte.Location = new System.Drawing.Point(393, 232);
            this.txtCedulaoPasaporte.Name = "txtCedulaoPasaporte";
            this.txtCedulaoPasaporte.Size = new System.Drawing.Size(161, 20);
            this.txtCedulaoPasaporte.TabIndex = 24;
            // 
            // lblCedulaoPasaporte
            // 
            this.lblCedulaoPasaporte.AutoSize = true;
            this.lblCedulaoPasaporte.BackColor = System.Drawing.Color.Transparent;
            this.lblCedulaoPasaporte.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedulaoPasaporte.Location = new System.Drawing.Point(213, 233);
            this.lblCedulaoPasaporte.Name = "lblCedulaoPasaporte";
            this.lblCedulaoPasaporte.Size = new System.Drawing.Size(174, 19);
            this.lblCedulaoPasaporte.TabIndex = 23;
            this.lblCedulaoPasaporte.Text = "Cedula o Pasaporte";
            // 
            // lblRetiro
            // 
            this.lblRetiro.AutoSize = true;
            this.lblRetiro.BackColor = System.Drawing.Color.Transparent;
            this.lblRetiro.Font = new System.Drawing.Font("Stencil", 20F);
            this.lblRetiro.Location = new System.Drawing.Point(354, 117);
            this.lblRetiro.Name = "lblRetiro";
            this.lblRetiro.Size = new System.Drawing.Size(113, 32);
            this.lblRetiro.TabIndex = 22;
            this.lblRetiro.Text = "Retiro";
            // 
            // lblBankintoch
            // 
            this.lblBankintoch.AutoSize = true;
            this.lblBankintoch.BackColor = System.Drawing.Color.Transparent;
            this.lblBankintoch.Font = new System.Drawing.Font("Stencil", 30.75F);
            this.lblBankintoch.Location = new System.Drawing.Point(273, 38);
            this.lblBankintoch.Name = "lblBankintoch";
            this.lblBankintoch.Size = new System.Drawing.Size(279, 48);
            this.lblBankintoch.TabIndex = 21;
            this.lblBankintoch.Text = "BANKINTOCH";
            // 
            // lblMontoaRetirar
            // 
            this.lblMontoaRetirar.AutoSize = true;
            this.lblMontoaRetirar.BackColor = System.Drawing.Color.Transparent;
            this.lblMontoaRetirar.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoaRetirar.Location = new System.Drawing.Point(213, 338);
            this.lblMontoaRetirar.Name = "lblMontoaRetirar";
            this.lblMontoaRetirar.Size = new System.Drawing.Size(149, 19);
            this.lblMontoaRetirar.TabIndex = 34;
            this.lblMontoaRetirar.Text = "Monto a Retirar";
            // 
            // txtMontoaRetirar
            // 
            this.txtMontoaRetirar.Location = new System.Drawing.Point(393, 337);
            this.txtMontoaRetirar.Name = "txtMontoaRetirar";
            this.txtMontoaRetirar.Size = new System.Drawing.Size(161, 20);
            this.txtMontoaRetirar.TabIndex = 35;
            // 
            // Retiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
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