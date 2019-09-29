namespace ProyectoFinalProg3
{
    partial class ValidarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ValidarCliente));
            this.lblBankintoch = new System.Windows.Forms.Label();
            this.lblCedulaoPasaporte = new System.Windows.Forms.Label();
            this.txtCedulaoPasaporte = new System.Windows.Forms.TextBox();
            this.txtNoCuenta = new System.Windows.Forms.TextBox();
            this.lblNoCuenta = new System.Windows.Forms.Label();
            this.btnValidar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblValidarCliente = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBankintoch
            // 
            this.lblBankintoch.AutoSize = true;
            this.lblBankintoch.BackColor = System.Drawing.Color.Transparent;
            this.lblBankintoch.Font = new System.Drawing.Font("Stencil", 36.75F);
            this.lblBankintoch.Location = new System.Drawing.Point(244, 22);
            this.lblBankintoch.Name = "lblBankintoch";
            this.lblBankintoch.Size = new System.Drawing.Size(335, 59);
            this.lblBankintoch.TabIndex = 1;
            this.lblBankintoch.Text = "BANKINTOCH";
            this.lblBankintoch.Click += new System.EventHandler(this.LblBankintoch_Click);
            // 
            // lblCedulaoPasaporte
            // 
            this.lblCedulaoPasaporte.AutoSize = true;
            this.lblCedulaoPasaporte.BackColor = System.Drawing.Color.Transparent;
            this.lblCedulaoPasaporte.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedulaoPasaporte.Location = new System.Drawing.Point(163, 268);
            this.lblCedulaoPasaporte.Name = "lblCedulaoPasaporte";
            this.lblCedulaoPasaporte.Size = new System.Drawing.Size(174, 19);
            this.lblCedulaoPasaporte.TabIndex = 2;
            this.lblCedulaoPasaporte.Text = "Cedula o Pasaporte";
            // 
            // txtCedulaoPasaporte
            // 
            this.txtCedulaoPasaporte.Location = new System.Drawing.Point(343, 267);
            this.txtCedulaoPasaporte.Name = "txtCedulaoPasaporte";
            this.txtCedulaoPasaporte.Size = new System.Drawing.Size(161, 20);
            this.txtCedulaoPasaporte.TabIndex = 3;
            // 
            // txtNoCuenta
            // 
            this.txtNoCuenta.Location = new System.Drawing.Point(291, 340);
            this.txtNoCuenta.Name = "txtNoCuenta";
            this.txtNoCuenta.Size = new System.Drawing.Size(161, 20);
            this.txtNoCuenta.TabIndex = 4;
            // 
            // lblNoCuenta
            // 
            this.lblNoCuenta.AutoSize = true;
            this.lblNoCuenta.BackColor = System.Drawing.Color.Transparent;
            this.lblNoCuenta.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoCuenta.Location = new System.Drawing.Point(167, 340);
            this.lblNoCuenta.Name = "lblNoCuenta";
            this.lblNoCuenta.Size = new System.Drawing.Size(99, 19);
            this.lblNoCuenta.TabIndex = 5;
            this.lblNoCuenta.Text = "No. Cuenta";
            // 
            // btnValidar
            // 
            this.btnValidar.BackColor = System.Drawing.Color.Transparent;
            this.btnValidar.Font = new System.Drawing.Font("Stencil", 15F);
            this.btnValidar.Location = new System.Drawing.Point(547, 405);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(107, 33);
            this.btnValidar.TabIndex = 6;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = false;
            this.btnValidar.Click += new System.EventHandler(this.BtnValidar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Font = new System.Drawing.Font("Stencil", 15F);
            this.btnCancelar.Location = new System.Drawing.Point(665, 405);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(123, 31);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // lblValidarCliente
            // 
            this.lblValidarCliente.AutoSize = true;
            this.lblValidarCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblValidarCliente.Font = new System.Drawing.Font("Stencil", 18F);
            this.lblValidarCliente.Location = new System.Drawing.Point(298, 112);
            this.lblValidarCliente.Name = "lblValidarCliente";
            this.lblValidarCliente.Size = new System.Drawing.Size(214, 29);
            this.lblValidarCliente.TabIndex = 8;
            this.lblValidarCliente.Text = "Validar Cliente";
            // 
            // ValidarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblValidarCliente);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.lblNoCuenta);
            this.Controls.Add(this.txtNoCuenta);
            this.Controls.Add(this.txtCedulaoPasaporte);
            this.Controls.Add(this.lblCedulaoPasaporte);
            this.Controls.Add(this.lblBankintoch);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ValidarCliente";
            this.Text = "ValidarCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBankintoch;
        private System.Windows.Forms.Label lblCedulaoPasaporte;
        private System.Windows.Forms.TextBox txtCedulaoPasaporte;
        private System.Windows.Forms.TextBox txtNoCuenta;
        private System.Windows.Forms.Label lblNoCuenta;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblValidarCliente;
    }
}