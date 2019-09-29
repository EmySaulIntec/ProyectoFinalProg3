namespace ProyectoFinalProg3
{
    partial class Deposito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deposito));
            this.lblDeposito = new System.Windows.Forms.Label();
            this.lblBankintoch = new System.Windows.Forms.Label();
            this.lblNoCuenta = new System.Windows.Forms.Label();
            this.txtNoCuenta = new System.Windows.Forms.TextBox();
            this.txtCedulaoPasaporte = new System.Windows.Forms.TextBox();
            this.lblCedulaoPasaporte = new System.Windows.Forms.Label();
            this.lblMontoaDepositar = new System.Windows.Forms.Label();
            this.txtMontoaDepositar = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.txtNoCuentaDestino = new System.Windows.Forms.TextBox();
            this.lblNoCuentaDestino = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDeposito
            // 
            this.lblDeposito.AutoSize = true;
            this.lblDeposito.BackColor = System.Drawing.Color.Transparent;
            this.lblDeposito.Font = new System.Drawing.Font("Stencil", 20F);
            this.lblDeposito.Location = new System.Drawing.Point(323, 105);
            this.lblDeposito.Name = "lblDeposito";
            this.lblDeposito.Size = new System.Drawing.Size(142, 32);
            this.lblDeposito.TabIndex = 10;
            this.lblDeposito.Text = "Deposito";
            // 
            // lblBankintoch
            // 
            this.lblBankintoch.AutoSize = true;
            this.lblBankintoch.BackColor = System.Drawing.Color.Transparent;
            this.lblBankintoch.Font = new System.Drawing.Font("Stencil", 30.75F);
            this.lblBankintoch.Location = new System.Drawing.Point(259, 41);
            this.lblBankintoch.Name = "lblBankintoch";
            this.lblBankintoch.Size = new System.Drawing.Size(279, 48);
            this.lblBankintoch.TabIndex = 9;
            this.lblBankintoch.Text = "BANKINTOCH";
            // 
            // lblNoCuenta
            // 
            this.lblNoCuenta.AutoSize = true;
            this.lblNoCuenta.BackColor = System.Drawing.Color.Transparent;
            this.lblNoCuenta.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoCuenta.Location = new System.Drawing.Point(209, 229);
            this.lblNoCuenta.Name = "lblNoCuenta";
            this.lblNoCuenta.Size = new System.Drawing.Size(99, 19);
            this.lblNoCuenta.TabIndex = 14;
            this.lblNoCuenta.Text = "No. Cuenta";
            // 
            // txtNoCuenta
            // 
            this.txtNoCuenta.Location = new System.Drawing.Point(333, 229);
            this.txtNoCuenta.Name = "txtNoCuenta";
            this.txtNoCuenta.Size = new System.Drawing.Size(161, 20);
            this.txtNoCuenta.TabIndex = 13;
            // 
            // txtCedulaoPasaporte
            // 
            this.txtCedulaoPasaporte.Location = new System.Drawing.Point(389, 176);
            this.txtCedulaoPasaporte.Name = "txtCedulaoPasaporte";
            this.txtCedulaoPasaporte.Size = new System.Drawing.Size(161, 20);
            this.txtCedulaoPasaporte.TabIndex = 12;
            // 
            // lblCedulaoPasaporte
            // 
            this.lblCedulaoPasaporte.AutoSize = true;
            this.lblCedulaoPasaporte.BackColor = System.Drawing.Color.Transparent;
            this.lblCedulaoPasaporte.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedulaoPasaporte.Location = new System.Drawing.Point(209, 177);
            this.lblCedulaoPasaporte.Name = "lblCedulaoPasaporte";
            this.lblCedulaoPasaporte.Size = new System.Drawing.Size(174, 19);
            this.lblCedulaoPasaporte.TabIndex = 11;
            this.lblCedulaoPasaporte.Text = "Cedula o Pasaporte";
            // 
            // lblMontoaDepositar
            // 
            this.lblMontoaDepositar.AutoSize = true;
            this.lblMontoaDepositar.BackColor = System.Drawing.Color.Transparent;
            this.lblMontoaDepositar.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoaDepositar.Location = new System.Drawing.Point(209, 332);
            this.lblMontoaDepositar.Name = "lblMontoaDepositar";
            this.lblMontoaDepositar.Size = new System.Drawing.Size(166, 19);
            this.lblMontoaDepositar.TabIndex = 18;
            this.lblMontoaDepositar.Text = "Monto a Depositar";
            // 
            // txtMontoaDepositar
            // 
            this.txtMontoaDepositar.Location = new System.Drawing.Point(389, 333);
            this.txtMontoaDepositar.Name = "txtMontoaDepositar";
            this.txtMontoaDepositar.Size = new System.Drawing.Size(161, 20);
            this.txtMontoaDepositar.TabIndex = 17;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Font = new System.Drawing.Font("Stencil", 15F);
            this.btnCancelar.Location = new System.Drawing.Point(665, 407);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(123, 31);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnDepositar
            // 
            this.btnDepositar.BackColor = System.Drawing.Color.Transparent;
            this.btnDepositar.Font = new System.Drawing.Font("Stencil", 15F);
            this.btnDepositar.Location = new System.Drawing.Point(526, 407);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(128, 33);
            this.btnDepositar.TabIndex = 19;
            this.btnDepositar.Text = "Depositar";
            this.btnDepositar.UseVisualStyleBackColor = false;
            this.btnDepositar.Click += new System.EventHandler(this.BtnDepositar_Click);
            // 
            // txtNoCuentaDestino
            // 
            this.txtNoCuentaDestino.Location = new System.Drawing.Point(389, 277);
            this.txtNoCuentaDestino.Name = "txtNoCuentaDestino";
            this.txtNoCuentaDestino.Size = new System.Drawing.Size(161, 20);
            this.txtNoCuentaDestino.TabIndex = 15;
            // 
            // lblNoCuentaDestino
            // 
            this.lblNoCuentaDestino.AutoSize = true;
            this.lblNoCuentaDestino.BackColor = System.Drawing.Color.Transparent;
            this.lblNoCuentaDestino.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoCuentaDestino.Location = new System.Drawing.Point(209, 277);
            this.lblNoCuentaDestino.Name = "lblNoCuentaDestino";
            this.lblNoCuentaDestino.Size = new System.Drawing.Size(168, 19);
            this.lblNoCuentaDestino.TabIndex = 16;
            this.lblNoCuentaDestino.Text = "No. Cuenta Destino";
            // 
            // Deposito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnDepositar);
            this.Controls.Add(this.lblMontoaDepositar);
            this.Controls.Add(this.txtMontoaDepositar);
            this.Controls.Add(this.lblNoCuentaDestino);
            this.Controls.Add(this.txtNoCuentaDestino);
            this.Controls.Add(this.lblNoCuenta);
            this.Controls.Add(this.txtNoCuenta);
            this.Controls.Add(this.txtCedulaoPasaporte);
            this.Controls.Add(this.lblCedulaoPasaporte);
            this.Controls.Add(this.lblDeposito);
            this.Controls.Add(this.lblBankintoch);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Deposito";
            this.Text = "Deposito";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeposito;
        private System.Windows.Forms.Label lblBankintoch;
        private System.Windows.Forms.Label lblNoCuenta;
        private System.Windows.Forms.TextBox txtNoCuenta;
        private System.Windows.Forms.TextBox txtCedulaoPasaporte;
        private System.Windows.Forms.Label lblCedulaoPasaporte;
        private System.Windows.Forms.Label lblMontoaDepositar;
        private System.Windows.Forms.TextBox txtMontoaDepositar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.TextBox txtNoCuentaDestino;
        private System.Windows.Forms.Label lblNoCuentaDestino;
    }
}