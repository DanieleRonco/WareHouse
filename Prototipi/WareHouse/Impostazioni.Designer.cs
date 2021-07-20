namespace WareHouse
{
    partial class Impostazioni
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
            this.lblLoginAutomatico = new System.Windows.Forms.Label();
            this.btnLoginAutomaticoSI = new System.Windows.Forms.Button();
            this.btnLoginAutomaticoNO = new System.Windows.Forms.Button();
            this.lblCambiaPassword = new System.Windows.Forms.Label();
            this.btnCambiaPassword = new System.Windows.Forms.Button();
            this.btnInquadra = new System.Windows.Forms.Button();
            this.btnImpostazioni = new System.Windows.Forms.Button();
            this.btnElenco = new System.Windows.Forms.Button();
            this.btnEsci = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLoginAutomatico
            // 
            this.lblLoginAutomatico.AutoSize = true;
            this.lblLoginAutomatico.Location = new System.Drawing.Point(31, 276);
            this.lblLoginAutomatico.Name = "lblLoginAutomatico";
            this.lblLoginAutomatico.Size = new System.Drawing.Size(92, 13);
            this.lblLoginAutomatico.TabIndex = 0;
            this.lblLoginAutomatico.Text = "Login Automatico:";
            // 
            // btnLoginAutomaticoSI
            // 
            this.btnLoginAutomaticoSI.Location = new System.Drawing.Point(141, 276);
            this.btnLoginAutomaticoSI.Name = "btnLoginAutomaticoSI";
            this.btnLoginAutomaticoSI.Size = new System.Drawing.Size(75, 23);
            this.btnLoginAutomaticoSI.TabIndex = 1;
            this.btnLoginAutomaticoSI.Text = "Sì";
            this.btnLoginAutomaticoSI.UseVisualStyleBackColor = true;
            this.btnLoginAutomaticoSI.Click += new System.EventHandler(this.btnLoginAutomaticoSI_Click);
            // 
            // btnLoginAutomaticoNO
            // 
            this.btnLoginAutomaticoNO.Location = new System.Drawing.Point(222, 276);
            this.btnLoginAutomaticoNO.Name = "btnLoginAutomaticoNO";
            this.btnLoginAutomaticoNO.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnLoginAutomaticoNO.Size = new System.Drawing.Size(75, 23);
            this.btnLoginAutomaticoNO.TabIndex = 2;
            this.btnLoginAutomaticoNO.Text = "No";
            this.btnLoginAutomaticoNO.UseVisualStyleBackColor = true;
            this.btnLoginAutomaticoNO.Click += new System.EventHandler(this.btnLoginAutomaticoNO_Click);
            // 
            // lblCambiaPassword
            // 
            this.lblCambiaPassword.AutoSize = true;
            this.lblCambiaPassword.Location = new System.Drawing.Point(31, 320);
            this.lblCambiaPassword.Name = "lblCambiaPassword";
            this.lblCambiaPassword.Size = new System.Drawing.Size(93, 13);
            this.lblCambiaPassword.TabIndex = 3;
            this.lblCambiaPassword.Text = "Cambia password:";
            // 
            // btnCambiaPassword
            // 
            this.btnCambiaPassword.Location = new System.Drawing.Point(141, 320);
            this.btnCambiaPassword.Name = "btnCambiaPassword";
            this.btnCambiaPassword.Size = new System.Drawing.Size(156, 23);
            this.btnCambiaPassword.TabIndex = 4;
            this.btnCambiaPassword.Text = "Cambia password";
            this.btnCambiaPassword.UseVisualStyleBackColor = true;
            this.btnCambiaPassword.Click += new System.EventHandler(this.btnCambiaPassword_Click);
            // 
            // btnInquadra
            // 
            this.btnInquadra.Location = new System.Drawing.Point(229, 576);
            this.btnInquadra.Name = "btnInquadra";
            this.btnInquadra.Size = new System.Drawing.Size(75, 23);
            this.btnInquadra.TabIndex = 7;
            this.btnInquadra.Text = "Inquadra";
            this.btnInquadra.UseVisualStyleBackColor = true;
            this.btnInquadra.Click += new System.EventHandler(this.btnInquadra_Click);
            // 
            // btnImpostazioni
            // 
            this.btnImpostazioni.Location = new System.Drawing.Point(25, 576);
            this.btnImpostazioni.Name = "btnImpostazioni";
            this.btnImpostazioni.Size = new System.Drawing.Size(75, 23);
            this.btnImpostazioni.TabIndex = 6;
            this.btnImpostazioni.Text = "Impostazioni";
            this.btnImpostazioni.UseVisualStyleBackColor = true;
            this.btnImpostazioni.Click += new System.EventHandler(this.btnImpostazioni_Click);
            // 
            // btnElenco
            // 
            this.btnElenco.Location = new System.Drawing.Point(126, 576);
            this.btnElenco.Name = "btnElenco";
            this.btnElenco.Size = new System.Drawing.Size(75, 23);
            this.btnElenco.TabIndex = 5;
            this.btnElenco.Text = "Elenco";
            this.btnElenco.UseVisualStyleBackColor = true;
            this.btnElenco.Click += new System.EventHandler(this.btnElenco_Click);
            // 
            // btnEsci
            // 
            this.btnEsci.Location = new System.Drawing.Point(247, 12);
            this.btnEsci.Name = "btnEsci";
            this.btnEsci.Size = new System.Drawing.Size(75, 23);
            this.btnEsci.TabIndex = 8;
            this.btnEsci.Text = "Esci";
            this.btnEsci.UseVisualStyleBackColor = true;
            this.btnEsci.Click += new System.EventHandler(this.btnEsci_Click);
            // 
            // Impostazioni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 611);
            this.Controls.Add(this.btnEsci);
            this.Controls.Add(this.btnInquadra);
            this.Controls.Add(this.btnImpostazioni);
            this.Controls.Add(this.btnElenco);
            this.Controls.Add(this.btnCambiaPassword);
            this.Controls.Add(this.lblCambiaPassword);
            this.Controls.Add(this.btnLoginAutomaticoNO);
            this.Controls.Add(this.btnLoginAutomaticoSI);
            this.Controls.Add(this.lblLoginAutomatico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Impostazioni";
            this.Text = "Impostazioni";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoginAutomatico;
        private System.Windows.Forms.Button btnLoginAutomaticoSI;
        private System.Windows.Forms.Button btnLoginAutomaticoNO;
        private System.Windows.Forms.Label lblCambiaPassword;
        private System.Windows.Forms.Button btnCambiaPassword;
        private System.Windows.Forms.Button btnInquadra;
        private System.Windows.Forms.Button btnImpostazioni;
        private System.Windows.Forms.Button btnElenco;
        private System.Windows.Forms.Button btnEsci;
    }
}