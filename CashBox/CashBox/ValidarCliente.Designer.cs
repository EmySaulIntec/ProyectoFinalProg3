namespace ProyectoFinalProg3
{
    partial class FrmValidateClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmValidateClient));
            this.lblBankintoch = new System.Windows.Forms.Label();
            this.lblCedulaoPasaporte = new System.Windows.Forms.Label();
            this.txtIdentification = new System.Windows.Forms.TextBox();
            this.txtNoCuenta = new System.Windows.Forms.TextBox();
            this.lblNoCuenta = new System.Windows.Forms.Label();
            this.btnValidar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblValidarCliente = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioIdentification = new System.Windows.Forms.RadioButton();
            this.radioPassport = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBankintoch
            // 
            this.lblBankintoch.AutoSize = true;
            this.lblBankintoch.BackColor = System.Drawing.Color.Transparent;
            this.lblBankintoch.Font = new System.Drawing.Font("Stencil", 36.75F);
            this.lblBankintoch.Location = new System.Drawing.Point(325, 27);
            this.lblBankintoch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBankintoch.Name = "lblBankintoch";
            this.lblBankintoch.Size = new System.Drawing.Size(426, 73);
            this.lblBankintoch.TabIndex = 1;
            this.lblBankintoch.Text = "BANKINTOCH";
            this.lblBankintoch.Click += new System.EventHandler(this.LblBankintoch_Click);
            // 
            // lblCedulaoPasaporte
            // 
            this.lblCedulaoPasaporte.AutoSize = true;
            this.lblCedulaoPasaporte.BackColor = System.Drawing.Color.Transparent;
            this.lblCedulaoPasaporte.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedulaoPasaporte.Location = new System.Drawing.Point(217, 330);
            this.lblCedulaoPasaporte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCedulaoPasaporte.Name = "lblCedulaoPasaporte";
            this.lblCedulaoPasaporte.Size = new System.Drawing.Size(219, 24);
            this.lblCedulaoPasaporte.TabIndex = 2;
            this.lblCedulaoPasaporte.Text = "Cedula o Pasaporte";
            // 
            // txtCedulaoPasaporte
            // 
            this.txtIdentification.Location = new System.Drawing.Point(457, 329);
            this.txtIdentification.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdentification.Name = "txtCedulaoPasaporte";
            this.txtIdentification.Size = new System.Drawing.Size(130, 22);
            this.txtIdentification.TabIndex = 3;
            // 
            // txtNoCuenta
            // 
            this.txtNoCuenta.Location = new System.Drawing.Point(457, 418);
            this.txtNoCuenta.Margin = new System.Windows.Forms.Padding(4);
            this.txtNoCuenta.Name = "txtNoCuenta";
            this.txtNoCuenta.Size = new System.Drawing.Size(213, 22);
            this.txtNoCuenta.TabIndex = 4;
            // 
            // lblNoCuenta
            // 
            this.lblNoCuenta.AutoSize = true;
            this.lblNoCuenta.BackColor = System.Drawing.Color.Transparent;
            this.lblNoCuenta.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoCuenta.Location = new System.Drawing.Point(223, 418);
            this.lblNoCuenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNoCuenta.Name = "lblNoCuenta";
            this.lblNoCuenta.Size = new System.Drawing.Size(122, 24);
            this.lblNoCuenta.TabIndex = 5;
            this.lblNoCuenta.Text = "No. Cuenta";
            // 
            // btnValidar
            // 
            this.btnValidar.BackColor = System.Drawing.Color.Transparent;
            this.btnValidar.Font = new System.Drawing.Font("Stencil", 15F);
            this.btnValidar.Location = new System.Drawing.Point(729, 498);
            this.btnValidar.Margin = new System.Windows.Forms.Padding(4);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(143, 41);
            this.btnValidar.TabIndex = 6;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = false;
            this.btnValidar.Click += new System.EventHandler(this.BtnValidar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Font = new System.Drawing.Font("Stencil", 15F);
            this.btnCancelar.Location = new System.Drawing.Point(887, 498);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(164, 38);
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
            this.lblValidarCliente.Location = new System.Drawing.Point(397, 138);
            this.lblValidarCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValidarCliente.Name = "lblValidarCliente";
            this.lblValidarCliente.Size = new System.Drawing.Size(267, 35);
            this.lblValidarCliente.TabIndex = 8;
            this.lblValidarCliente.Text = "Validar Cliente";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.radioIdentification);
            this.groupBox1.Controls.Add(this.radioPassport);
            this.groupBox1.Font = new System.Drawing.Font("Stencil", 7.8F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(618, 313);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 69);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Identificacion";
            // 
            // radioIdentification
            // 
            this.radioIdentification.AutoSize = true;
            this.radioIdentification.BackColor = System.Drawing.Color.Transparent;
            this.radioIdentification.Checked = true;
            this.radioIdentification.Location = new System.Drawing.Point(18, 38);
            this.radioIdentification.Name = "radioIdentification";
            this.radioIdentification.Size = new System.Drawing.Size(85, 21);
            this.radioIdentification.TabIndex = 22;
            this.radioIdentification.TabStop = true;
            this.radioIdentification.Text = "Cedula";
            this.radioIdentification.UseVisualStyleBackColor = false;
            // 
            // radioPassport
            // 
            this.radioPassport.AutoSize = true;
            this.radioPassport.BackColor = System.Drawing.Color.Transparent;
            this.radioPassport.Location = new System.Drawing.Point(116, 37);
            this.radioPassport.Name = "radioPassport";
            this.radioPassport.Size = new System.Drawing.Size(117, 21);
            this.radioPassport.TabIndex = 23;
            this.radioPassport.Text = "Pasaporte";
            this.radioPassport.UseVisualStyleBackColor = false;
            // 
            // FrmValidateClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblValidarCliente);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.lblNoCuenta);
            this.Controls.Add(this.txtNoCuenta);
            this.Controls.Add(this.txtIdentification);
            this.Controls.Add(this.lblCedulaoPasaporte);
            this.Controls.Add(this.lblBankintoch);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmValidateClient";
            this.Text = "ValidarCliente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBankintoch;
        private System.Windows.Forms.Label lblCedulaoPasaporte;
        private System.Windows.Forms.TextBox txtIdentification;
        private System.Windows.Forms.TextBox txtNoCuenta;
        private System.Windows.Forms.Label lblNoCuenta;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblValidarCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioIdentification;
        private System.Windows.Forms.RadioButton radioPassport;
    }
}