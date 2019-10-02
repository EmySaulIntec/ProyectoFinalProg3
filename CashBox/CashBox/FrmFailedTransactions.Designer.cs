namespace CashBox
{
    partial class FrmFailedTransactions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFailedTransactions));
            this.listUsers = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioIdentification = new System.Windows.Forms.RadioButton();
            this.radioPassport = new System.Windows.Forms.RadioButton();
            this.btnRetirar = new System.Windows.Forms.Button();
            this.lblNoIdentification = new System.Windows.Forms.Label();
            this.lblCasher = new System.Windows.Forms.Label();
            this.lblTransactionType = new System.Windows.Forms.Label();
            this.lblDestinyAccount = new System.Windows.Forms.Label();
            this.lblOriginAccount = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listUsers
            // 
            this.listUsers.FormattingEnabled = true;
            this.listUsers.ItemHeight = 12;
            this.listUsers.Location = new System.Drawing.Point(21, 68);
            this.listUsers.Name = "listUsers";
            this.listUsers.Size = new System.Drawing.Size(252, 256);
            this.listUsers.TabIndex = 10;
            this.listUsers.SelectedIndexChanged += new System.EventHandler(this.listUsers_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Stencil", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Transacciones Fallidas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 7.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(338, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Cuenta Origen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stencil", 7.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(595, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Cuenta Destino";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Stencil", 7.8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(787, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Tipo de Transaccion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Stencil", 7.8F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(595, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Cajero";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Stencil", 7.8F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(338, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "No. Identificacion";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.radioIdentification);
            this.groupBox1.Controls.Add(this.radioPassport);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Stencil", 7.8F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(341, 229);
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
            this.radioIdentification.Size = new System.Drawing.Size(70, 17);
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
            this.radioPassport.Size = new System.Drawing.Size(96, 17);
            this.radioPassport.TabIndex = 23;
            this.radioPassport.Text = "Pasaporte";
            this.radioPassport.UseVisualStyleBackColor = false;
            // 
            // btnRetirar
            // 
            this.btnRetirar.BackColor = System.Drawing.Color.Transparent;
            this.btnRetirar.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetirar.Location = new System.Drawing.Point(668, 229);
            this.btnRetirar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRetirar.Name = "btnRetirar";
            this.btnRetirar.Size = new System.Drawing.Size(280, 41);
            this.btnRetirar.TabIndex = 38;
            this.btnRetirar.Text = "Reintentar Transaccion";
            this.btnRetirar.UseVisualStyleBackColor = false;
            this.btnRetirar.Click += new System.EventHandler(this.btnRetirar_Click);
            // 
            // lblNoIdentification
            // 
            this.lblNoIdentification.AutoSize = true;
            this.lblNoIdentification.Font = new System.Drawing.Font("Stencil", 7.8F);
            this.lblNoIdentification.Location = new System.Drawing.Point(338, 96);
            this.lblNoIdentification.Name = "lblNoIdentification";
            this.lblNoIdentification.Size = new System.Drawing.Size(0, 13);
            this.lblNoIdentification.TabIndex = 44;
            // 
            // lblCasher
            // 
            this.lblCasher.AutoSize = true;
            this.lblCasher.Font = new System.Drawing.Font("Stencil", 7.8F);
            this.lblCasher.Location = new System.Drawing.Point(595, 96);
            this.lblCasher.Name = "lblCasher";
            this.lblCasher.Size = new System.Drawing.Size(0, 13);
            this.lblCasher.TabIndex = 43;
            // 
            // lblTransactionType
            // 
            this.lblTransactionType.AutoSize = true;
            this.lblTransactionType.Font = new System.Drawing.Font("Stencil", 7.8F);
            this.lblTransactionType.Location = new System.Drawing.Point(787, 96);
            this.lblTransactionType.Name = "lblTransactionType";
            this.lblTransactionType.Size = new System.Drawing.Size(0, 13);
            this.lblTransactionType.TabIndex = 42;
            // 
            // lblDestinyAccount
            // 
            this.lblDestinyAccount.AutoSize = true;
            this.lblDestinyAccount.Font = new System.Drawing.Font("Stencil", 7.8F);
            this.lblDestinyAccount.Location = new System.Drawing.Point(595, 159);
            this.lblDestinyAccount.Name = "lblDestinyAccount";
            this.lblDestinyAccount.Size = new System.Drawing.Size(0, 13);
            this.lblDestinyAccount.TabIndex = 41;
            // 
            // lblOriginAccount
            // 
            this.lblOriginAccount.AutoSize = true;
            this.lblOriginAccount.Font = new System.Drawing.Font("Stencil", 7.8F);
            this.lblOriginAccount.Location = new System.Drawing.Point(338, 159);
            this.lblOriginAccount.Name = "lblOriginAccount";
            this.lblOriginAccount.Size = new System.Drawing.Size(0, 13);
            this.lblOriginAccount.TabIndex = 40;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Stencil", 7.8F);
            this.lblDate.Location = new System.Drawing.Point(774, 20);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 13);
            this.lblDate.TabIndex = 45;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(733, 278);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 33);
            this.button1.TabIndex = 46;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmFailedTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(994, 336);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblNoIdentification);
            this.Controls.Add(this.lblCasher);
            this.Controls.Add(this.lblTransactionType);
            this.Controls.Add(this.lblDestinyAccount);
            this.Controls.Add(this.lblOriginAccount);
            this.Controls.Add(this.btnRetirar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listUsers);
            this.Font = new System.Drawing.Font("Stencil", 7.8F);
            this.Name = "FrmFailedTransactions";
            this.Text = "FrmFailedTransactions";
            this.Load += new System.EventHandler(this.FrmFailedTransactions_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listUsers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioIdentification;
        private System.Windows.Forms.RadioButton radioPassport;
        private System.Windows.Forms.Button btnRetirar;
        private System.Windows.Forms.Label lblNoIdentification;
        private System.Windows.Forms.Label lblCasher;
        private System.Windows.Forms.Label lblTransactionType;
        private System.Windows.Forms.Label lblDestinyAccount;
        private System.Windows.Forms.Label lblOriginAccount;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button button1;
    }
}