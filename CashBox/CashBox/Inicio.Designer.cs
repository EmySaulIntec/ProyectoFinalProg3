namespace ProyectoFinalProg3
{
    partial class FrmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            this.lblBankintoch = new System.Windows.Forms.Label();
            this.btnValidarCliente = new System.Windows.Forms.Button();
            this.btnDeposito = new System.Windows.Forms.Button();
            this.btnRetiro = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transaccionesFallidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBankintoch
            // 
            this.lblBankintoch.AutoSize = true;
            this.lblBankintoch.BackColor = System.Drawing.Color.Transparent;
            this.lblBankintoch.Font = new System.Drawing.Font("Stencil", 36.75F);
            this.lblBankintoch.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblBankintoch.Location = new System.Drawing.Point(418, 44);
            this.lblBankintoch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBankintoch.Name = "lblBankintoch";
            this.lblBankintoch.Size = new System.Drawing.Size(335, 59);
            this.lblBankintoch.TabIndex = 0;
            this.lblBankintoch.Text = "BANKINTOCH";
            // 
            // btnValidarCliente
            // 
            this.btnValidarCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnValidarCliente.Font = new System.Drawing.Font("Stencil", 15.75F);
            this.btnValidarCliente.Location = new System.Drawing.Point(428, 170);
            this.btnValidarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnValidarCliente.Name = "btnValidarCliente";
            this.btnValidarCliente.Size = new System.Drawing.Size(345, 58);
            this.btnValidarCliente.TabIndex = 1;
            this.btnValidarCliente.Text = "Validar Cliente";
            this.btnValidarCliente.UseVisualStyleBackColor = false;
            this.btnValidarCliente.Click += new System.EventHandler(this.BtnValidarCliente_Click);
            // 
            // btnDeposito
            // 
            this.btnDeposito.BackColor = System.Drawing.Color.Transparent;
            this.btnDeposito.Font = new System.Drawing.Font("Stencil", 15.75F);
            this.btnDeposito.Location = new System.Drawing.Point(503, 263);
            this.btnDeposito.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeposito.Name = "btnDeposito";
            this.btnDeposito.Size = new System.Drawing.Size(206, 57);
            this.btnDeposito.TabIndex = 2;
            this.btnDeposito.Text = "Deposito";
            this.btnDeposito.UseVisualStyleBackColor = false;
            this.btnDeposito.Click += new System.EventHandler(this.BtnDeposito_Click);
            // 
            // btnRetiro
            // 
            this.btnRetiro.BackColor = System.Drawing.Color.Transparent;
            this.btnRetiro.Font = new System.Drawing.Font("Stencil", 15.75F);
            this.btnRetiro.Location = new System.Drawing.Point(503, 363);
            this.btnRetiro.Margin = new System.Windows.Forms.Padding(4);
            this.btnRetiro.Name = "btnRetiro";
            this.btnRetiro.Size = new System.Drawing.Size(206, 50);
            this.btnRetiro.TabIndex = 3;
            this.btnRetiro.Text = "Retiro";
            this.btnRetiro.UseVisualStyleBackColor = false;
            this.btnRetiro.Click += new System.EventHandler(this.BtnRetiro_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Stencil", 13F);
            this.btnCerrarSesion.Location = new System.Drawing.Point(910, 498);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(271, 41);
            this.btnCerrarSesion.TabIndex = 32;
            this.btnCerrarSesion.Text = "Cerrar Sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.BtnCerrarSesion_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.configuracionToolStripMenuItem,
            this.transaccionesFallidasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1200, 24);
            this.menuStrip1.TabIndex = 33;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Bold);
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // configuracionToolStripMenuItem
            // 
            this.configuracionToolStripMenuItem.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Bold);
            this.configuracionToolStripMenuItem.Name = "configuracionToolStripMenuItem";
            this.configuracionToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.configuracionToolStripMenuItem.Text = "Configuracion";
            this.configuracionToolStripMenuItem.Click += new System.EventHandler(this.configuracionToolStripMenuItem_Click);
            // 
            // transaccionesFallidasToolStripMenuItem
            // 
            this.transaccionesFallidasToolStripMenuItem.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Bold);
            this.transaccionesFallidasToolStripMenuItem.Name = "transaccionesFallidasToolStripMenuItem";
            this.transaccionesFallidasToolStripMenuItem.Size = new System.Drawing.Size(190, 20);
            this.transaccionesFallidasToolStripMenuItem.Text = "Transacciones Fallidas";
            this.transaccionesFallidasToolStripMenuItem.Click += new System.EventHandler(this.transaccionesFallidasToolStripMenuItem_Click);
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 554);
            this.ControlBox = false;
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.btnRetiro);
            this.Controls.Add(this.btnDeposito);
            this.Controls.Add(this.btnValidarCliente);
            this.Controls.Add(this.lblBankintoch);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Stencil", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmHome";
            this.Text = "BANKINTOCH";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBankintoch;
        private System.Windows.Forms.Button btnValidarCliente;
        private System.Windows.Forms.Button btnDeposito;
        private System.Windows.Forms.Button btnRetiro;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transaccionesFallidasToolStripMenuItem;
    }
}