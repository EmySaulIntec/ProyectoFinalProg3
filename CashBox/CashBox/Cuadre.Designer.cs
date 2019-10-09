namespace CashBox
{
    partial class Cuadre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cuadre));
            this.lblMontoCaja = new System.Windows.Forms.Label();
            this.txtMontoCaja = new System.Windows.Forms.TextBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lblTotalDeposito = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalCaja = new System.Windows.Forms.Label();
            this.txtTotalDeposito = new System.Windows.Forms.TextBox();
            this.txtTotalRetiro = new System.Windows.Forms.TextBox();
            this.txtTotalCaja = new System.Windows.Forms.TextBox();
            this.btnGenerarCuadre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMontoCaja
            // 
            this.lblMontoCaja.AutoSize = true;
            this.lblMontoCaja.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblMontoCaja.Location = new System.Drawing.Point(550, 33);
            this.lblMontoCaja.Name = "lblMontoCaja";
            this.lblMontoCaja.Size = new System.Drawing.Size(61, 13);
            this.lblMontoCaja.TabIndex = 0;
            this.lblMontoCaja.Text = "Monto Caja";
            // 
            // txtMontoCaja
            // 
            this.txtMontoCaja.Location = new System.Drawing.Point(632, 33);
            this.txtMontoCaja.Name = "txtMontoCaja";
            this.txtMontoCaja.Size = new System.Drawing.Size(100, 20);
            this.txtMontoCaja.TabIndex = 1;
            this.txtMontoCaja.TextChanged += new System.EventHandler(this.TxtMontoCaja_TextChanged);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(-4, 2);
            this.reportViewer1.Name = "ReportViewer";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(522, 400);
            this.reportViewer1.TabIndex = 0;
            // 
            // lblTotalDeposito
            // 
            this.lblTotalDeposito.AutoSize = true;
            this.lblTotalDeposito.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblTotalDeposito.Location = new System.Drawing.Point(520, 79);
            this.lblTotalDeposito.Name = "lblTotalDeposito";
            this.lblTotalDeposito.Size = new System.Drawing.Size(91, 13);
            this.lblTotalDeposito.TabIndex = 2;
            this.lblTotalDeposito.Text = "Total Deposito (1)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Location = new System.Drawing.Point(534, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total Retiro (2)";
            // 
            // lblTotalCaja
            // 
            this.lblTotalCaja.AutoSize = true;
            this.lblTotalCaja.Location = new System.Drawing.Point(556, 220);
            this.lblTotalCaja.Name = "lblTotalCaja";
            this.lblTotalCaja.Size = new System.Drawing.Size(55, 13);
            this.lblTotalCaja.TabIndex = 4;
            this.lblTotalCaja.Text = "Total Caja";
            // 
            // txtTotalDeposito
            // 
            this.txtTotalDeposito.Location = new System.Drawing.Point(632, 76);
            this.txtTotalDeposito.Name = "txtTotalDeposito";
            this.txtTotalDeposito.Size = new System.Drawing.Size(100, 20);
            this.txtTotalDeposito.TabIndex = 5;
            // 
            // txtTotalRetiro
            // 
            this.txtTotalRetiro.Location = new System.Drawing.Point(632, 131);
            this.txtTotalRetiro.Name = "txtTotalRetiro";
            this.txtTotalRetiro.Size = new System.Drawing.Size(100, 20);
            this.txtTotalRetiro.TabIndex = 6;
            // 
            // txtTotalCaja
            // 
            this.txtTotalCaja.Location = new System.Drawing.Point(632, 220);
            this.txtTotalCaja.Name = "txtTotalCaja";
            this.txtTotalCaja.Size = new System.Drawing.Size(100, 20);
            this.txtTotalCaja.TabIndex = 7;
            this.txtTotalCaja.TextChanged += new System.EventHandler(this.TxtTotalCaja_TextChanged);
            // 
            // btnGenerarCuadre
            // 
            this.btnGenerarCuadre.Location = new System.Drawing.Point(581, 171);
            this.btnGenerarCuadre.Name = "btnGenerarCuadre";
            this.btnGenerarCuadre.Size = new System.Drawing.Size(104, 23);
            this.btnGenerarCuadre.TabIndex = 8;
            this.btnGenerarCuadre.Text = "Generar Cuadre";
            this.btnGenerarCuadre.UseVisualStyleBackColor = true;
            this.btnGenerarCuadre.Click += new System.EventHandler(this.BtnGenerarCuadre_Click);
            // 
            // Cuadre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(843, 483);
            this.Controls.Add(this.btnGenerarCuadre);
            this.Controls.Add(this.txtTotalCaja);
            this.Controls.Add(this.txtTotalRetiro);
            this.Controls.Add(this.txtTotalDeposito);
            this.Controls.Add(this.lblTotalCaja);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTotalDeposito);
            this.Controls.Add(this.txtMontoCaja);
            this.Controls.Add(this.lblMontoCaja);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cuadre";
            this.Text = "Cuadre";
            this.Load += new System.EventHandler(this.Cuadre_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMontoCaja;
        private System.Windows.Forms.TextBox txtMontoCaja;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label lblTotalDeposito;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalCaja;
        private System.Windows.Forms.TextBox txtTotalDeposito;
        private System.Windows.Forms.TextBox txtTotalRetiro;
        private System.Windows.Forms.TextBox txtTotalCaja;
        private System.Windows.Forms.Button btnGenerarCuadre;
    }
}