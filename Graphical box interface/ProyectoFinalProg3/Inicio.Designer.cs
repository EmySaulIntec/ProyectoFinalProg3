namespace ProyectoFinalProg3
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.lblBankintoch = new System.Windows.Forms.Label();
            this.btnValidarCliente = new System.Windows.Forms.Button();
            this.btnDeposito = new System.Windows.Forms.Button();
            this.btnRetiro = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBankintoch
            // 
            this.lblBankintoch.AutoSize = true;
            this.lblBankintoch.BackColor = System.Drawing.Color.Transparent;
            this.lblBankintoch.Font = new System.Drawing.Font("Stencil", 36.75F);
            this.lblBankintoch.Location = new System.Drawing.Point(235, 36);
            this.lblBankintoch.Name = "lblBankintoch";
            this.lblBankintoch.Size = new System.Drawing.Size(335, 59);
            this.lblBankintoch.TabIndex = 0;
            this.lblBankintoch.Text = "BANKINTOCH";
            // 
            // btnValidarCliente
            // 
            this.btnValidarCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnValidarCliente.Font = new System.Drawing.Font("Stencil", 15.75F);
            this.btnValidarCliente.Location = new System.Drawing.Point(285, 138);
            this.btnValidarCliente.Name = "btnValidarCliente";
            this.btnValidarCliente.Size = new System.Drawing.Size(230, 47);
            this.btnValidarCliente.TabIndex = 1;
            this.btnValidarCliente.Text = "Validar Cliente";
            this.btnValidarCliente.UseVisualStyleBackColor = false;
            this.btnValidarCliente.Click += new System.EventHandler(this.BtnValidarCliente_Click);
            // 
            // btnDeposito
            // 
            this.btnDeposito.BackColor = System.Drawing.Color.Transparent;
            this.btnDeposito.Font = new System.Drawing.Font("Stencil", 15.75F);
            this.btnDeposito.Location = new System.Drawing.Point(335, 214);
            this.btnDeposito.Name = "btnDeposito";
            this.btnDeposito.Size = new System.Drawing.Size(137, 46);
            this.btnDeposito.TabIndex = 2;
            this.btnDeposito.Text = "Deposito";
            this.btnDeposito.UseVisualStyleBackColor = false;
            this.btnDeposito.Click += new System.EventHandler(this.BtnDeposito_Click);
            // 
            // btnRetiro
            // 
            this.btnRetiro.BackColor = System.Drawing.Color.Transparent;
            this.btnRetiro.Font = new System.Drawing.Font("Stencil", 15.75F);
            this.btnRetiro.Location = new System.Drawing.Point(335, 295);
            this.btnRetiro.Name = "btnRetiro";
            this.btnRetiro.Size = new System.Drawing.Size(137, 41);
            this.btnRetiro.TabIndex = 3;
            this.btnRetiro.Text = "Retiro";
            this.btnRetiro.UseVisualStyleBackColor = false;
            this.btnRetiro.Click += new System.EventHandler(this.BtnRetiro_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Stencil", 13F);
            this.btnCerrarSesion.Location = new System.Drawing.Point(607, 405);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(181, 33);
            this.btnCerrarSesion.TabIndex = 32;
            this.btnCerrarSesion.Text = "Cerrar Sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.BtnCerrarSesion_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.btnRetiro);
            this.Controls.Add(this.btnDeposito);
            this.Controls.Add(this.btnValidarCliente);
            this.Controls.Add(this.lblBankintoch);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Inicio";
            this.Text = "BANKINTOCH INICIO";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBankintoch;
        private System.Windows.Forms.Button btnValidarCliente;
        private System.Windows.Forms.Button btnDeposito;
        private System.Windows.Forms.Button btnRetiro;
        private System.Windows.Forms.Button btnCerrarSesion;
    }
}