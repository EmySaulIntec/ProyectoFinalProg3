namespace ProyectoFinalProg3
{
    partial class FrmmRetirement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmmRetirement));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRetirar = new System.Windows.Forms.Button();
            this.lblNoCuenta = new System.Windows.Forms.Label();
            this.txtNoCuenta = new System.Windows.Forms.TextBox();
            this.txtIdentification = new System.Windows.Forms.TextBox();
            this.lblCedulaoPasaporte = new System.Windows.Forms.Label();
            this.lblRetiro = new System.Windows.Forms.Label();
            this.lblBankintoch = new System.Windows.Forms.Label();
            this.lblMontoaRetirar = new System.Windows.Forms.Label();
            this.txtMontoaRetirar = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioIdentification = new System.Windows.Forms.RadioButton();
            this.radioPassport = new System.Windows.Forms.RadioButton();
            this.listAmountReturneds = new System.Windows.Forms.ListBox();
            this.lblAmountReturned = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnCancelar.Location = new System.Drawing.Point(978, 614);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(184, 48);
            this.btnCancelar.TabIndex = 32;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnRetirar
            // 
            this.btnRetirar.BackColor = System.Drawing.Color.Transparent;
            this.btnRetirar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnRetirar.Location = new System.Drawing.Point(770, 614);
            this.btnRetirar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRetirar.Name = "btnRetirar";
            this.btnRetirar.Size = new System.Drawing.Size(192, 51);
            this.btnRetirar.TabIndex = 31;
            this.btnRetirar.Text = "Retirar";
            this.btnRetirar.UseVisualStyleBackColor = false;
            this.btnRetirar.Click += new System.EventHandler(this.BtnRetirar_Click);
            // 
            // lblNoCuenta
            // 
            this.lblNoCuenta.AutoSize = true;
            this.lblNoCuenta.BackColor = System.Drawing.Color.Transparent;
            this.lblNoCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoCuenta.Location = new System.Drawing.Point(320, 439);
            this.lblNoCuenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNoCuenta.Name = "lblNoCuenta";
            this.lblNoCuenta.Size = new System.Drawing.Size(133, 29);
            this.lblNoCuenta.TabIndex = 26;
            this.lblNoCuenta.Text = "No. Cuenta";
            // 
            // txtNoCuenta
            // 
            this.txtNoCuenta.Location = new System.Drawing.Point(590, 441);
            this.txtNoCuenta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNoCuenta.Name = "txtNoCuenta";
            this.txtNoCuenta.Size = new System.Drawing.Size(239, 26);
            this.txtNoCuenta.TabIndex = 25;
            // 
            // txtIdentification
            // 
            this.txtIdentification.Location = new System.Drawing.Point(590, 358);
            this.txtIdentification.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdentification.Name = "txtIdentification";
            this.txtIdentification.Size = new System.Drawing.Size(239, 26);
            this.txtIdentification.TabIndex = 24;
            // 
            // lblCedulaoPasaporte
            // 
            this.lblCedulaoPasaporte.AutoSize = true;
            this.lblCedulaoPasaporte.BackColor = System.Drawing.Color.Transparent;
            this.lblCedulaoPasaporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedulaoPasaporte.Location = new System.Drawing.Point(320, 359);
            this.lblCedulaoPasaporte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCedulaoPasaporte.Name = "lblCedulaoPasaporte";
            this.lblCedulaoPasaporte.Size = new System.Drawing.Size(226, 29);
            this.lblCedulaoPasaporte.TabIndex = 23;
            this.lblCedulaoPasaporte.Text = "Cedula o Pasaporte";
            // 
            // lblRetiro
            // 
            this.lblRetiro.AutoSize = true;
            this.lblRetiro.BackColor = System.Drawing.Color.Transparent;
            this.lblRetiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblRetiro.Location = new System.Drawing.Point(531, 180);
            this.lblRetiro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRetiro.Name = "lblRetiro";
            this.lblRetiro.Size = new System.Drawing.Size(127, 46);
            this.lblRetiro.TabIndex = 22;
            this.lblRetiro.Text = "Retiro";
            // 
            // lblBankintoch
            // 
            this.lblBankintoch.AutoSize = true;
            this.lblBankintoch.BackColor = System.Drawing.Color.Transparent;
            this.lblBankintoch.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.75F);
            this.lblBankintoch.Location = new System.Drawing.Point(410, 59);
            this.lblBankintoch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBankintoch.Name = "lblBankintoch";
            this.lblBankintoch.Size = new System.Drawing.Size(436, 71);
            this.lblBankintoch.TabIndex = 21;
            this.lblBankintoch.Text = "BANKINTOCH";
            // 
            // lblMontoaRetirar
            // 
            this.lblMontoaRetirar.AutoSize = true;
            this.lblMontoaRetirar.BackColor = System.Drawing.Color.Transparent;
            this.lblMontoaRetirar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoaRetirar.Location = new System.Drawing.Point(320, 520);
            this.lblMontoaRetirar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMontoaRetirar.Name = "lblMontoaRetirar";
            this.lblMontoaRetirar.Size = new System.Drawing.Size(177, 29);
            this.lblMontoaRetirar.TabIndex = 34;
            this.lblMontoaRetirar.Text = "Monto a Retirar";
            // 
            // txtMontoaRetirar
            // 
            this.txtMontoaRetirar.Location = new System.Drawing.Point(590, 519);
            this.txtMontoaRetirar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMontoaRetirar.Name = "txtMontoaRetirar";
            this.txtMontoaRetirar.Size = new System.Drawing.Size(239, 26);
            this.txtMontoaRetirar.TabIndex = 35;
            this.txtMontoaRetirar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontoaRetirar_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.radioIdentification);
            this.groupBox1.Controls.Add(this.radioPassport);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(874, 318);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(266, 86);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Identificacion";
            // 
            // radioIdentification
            // 
            this.radioIdentification.AutoSize = true;
            this.radioIdentification.BackColor = System.Drawing.Color.Transparent;
            this.radioIdentification.Checked = true;
            this.radioIdentification.Location = new System.Drawing.Point(20, 48);
            this.radioIdentification.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioIdentification.Name = "radioIdentification";
            this.radioIdentification.Size = new System.Drawing.Size(90, 24);
            this.radioIdentification.TabIndex = 22;
            this.radioIdentification.TabStop = true;
            this.radioIdentification.Text = "Cedula";
            this.radioIdentification.UseVisualStyleBackColor = false;
            // 
            // radioPassport
            // 
            this.radioPassport.AutoSize = true;
            this.radioPassport.BackColor = System.Drawing.Color.Transparent;
            this.radioPassport.Location = new System.Drawing.Point(130, 46);
            this.radioPassport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioPassport.Name = "radioPassport";
            this.radioPassport.Size = new System.Drawing.Size(116, 24);
            this.radioPassport.TabIndex = 23;
            this.radioPassport.Text = "Pasaporte";
            this.radioPassport.UseVisualStyleBackColor = false;
            // 
            // listAmountReturneds
            // 
            this.listAmountReturneds.FormattingEnabled = true;
            this.listAmountReturneds.ItemHeight = 20;
            this.listAmountReturneds.Location = new System.Drawing.Point(61, 366);
            this.listAmountReturneds.Name = "listAmountReturneds";
            this.listAmountReturneds.Size = new System.Drawing.Size(187, 244);
            this.listAmountReturneds.TabIndex = 37;
            this.listAmountReturneds.Visible = false;
            // 
            // lblAmountReturned
            // 
            this.lblAmountReturned.AutoSize = true;
            this.lblAmountReturned.BackColor = System.Drawing.Color.Transparent;
            this.lblAmountReturned.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountReturned.Location = new System.Drawing.Point(46, 318);
            this.lblAmountReturned.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmountReturned.Name = "lblAmountReturned";
            this.lblAmountReturned.Size = new System.Drawing.Size(243, 29);
            this.lblAmountReturned.TabIndex = 38;
            this.lblAmountReturned.Text = "Monedas Retornadas";
            this.lblAmountReturned.Visible = false;
            // 
            // FrmmRetirement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.ControlBox = false;
            this.Controls.Add(this.lblAmountReturned);
            this.Controls.Add(this.listAmountReturneds);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtMontoaRetirar);
            this.Controls.Add(this.lblMontoaRetirar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRetirar);
            this.Controls.Add(this.lblNoCuenta);
            this.Controls.Add(this.txtNoCuenta);
            this.Controls.Add(this.txtIdentification);
            this.Controls.Add(this.lblCedulaoPasaporte);
            this.Controls.Add(this.lblRetiro);
            this.Controls.Add(this.lblBankintoch);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmmRetirement";
            this.Text = "Retiro";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRetirar;
        private System.Windows.Forms.Label lblNoCuenta;
        private System.Windows.Forms.TextBox txtNoCuenta;
        private System.Windows.Forms.TextBox txtIdentification;
        private System.Windows.Forms.Label lblCedulaoPasaporte;
        private System.Windows.Forms.Label lblRetiro;
        private System.Windows.Forms.Label lblBankintoch;
        private System.Windows.Forms.Label lblMontoaRetirar;
        private System.Windows.Forms.TextBox txtMontoaRetirar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioIdentification;
        private System.Windows.Forms.RadioButton radioPassport;
        private System.Windows.Forms.ListBox listAmountReturneds;
        private System.Windows.Forms.Label lblAmountReturned;
    }
}