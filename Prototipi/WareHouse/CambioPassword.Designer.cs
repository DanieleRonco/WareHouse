﻿namespace WareHouse
{
    partial class CambioPassword
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
            this.lblVecchiaPassword = new System.Windows.Forms.Label();
            this.txtConfermaPassword = new System.Windows.Forms.TextBox();
            this.lblConfermaPassword = new System.Windows.Forms.Label();
            this.lblErrorePassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblErroreVecchiaPassword = new System.Windows.Forms.Label();
            this.txtVecchiaPassword = new System.Windows.Forms.TextBox();
            this.btnConferma = new System.Windows.Forms.Button();
            this.btnIndietro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblVecchiaPassword
            // 
            this.lblVecchiaPassword.AutoSize = true;
            this.lblVecchiaPassword.Location = new System.Drawing.Point(53, 184);
            this.lblVecchiaPassword.Name = "lblVecchiaPassword";
            this.lblVecchiaPassword.Size = new System.Drawing.Size(98, 13);
            this.lblVecchiaPassword.TabIndex = 0;
            this.lblVecchiaPassword.Text = "Vecchia Password:";
            // 
            // txtConfermaPassword
            // 
            this.txtConfermaPassword.Location = new System.Drawing.Point(53, 322);
            this.txtConfermaPassword.Name = "txtConfermaPassword";
            this.txtConfermaPassword.PasswordChar = '•';
            this.txtConfermaPassword.Size = new System.Drawing.Size(228, 20);
            this.txtConfermaPassword.TabIndex = 13;
            // 
            // lblConfermaPassword
            // 
            this.lblConfermaPassword.AutoSize = true;
            this.lblConfermaPassword.Location = new System.Drawing.Point(53, 306);
            this.lblConfermaPassword.Name = "lblConfermaPassword";
            this.lblConfermaPassword.Size = new System.Drawing.Size(103, 13);
            this.lblConfermaPassword.TabIndex = 12;
            this.lblConfermaPassword.Text = "Conferma password:";
            // 
            // lblErrorePassword
            // 
            this.lblErrorePassword.AutoSize = true;
            this.lblErrorePassword.Location = new System.Drawing.Point(53, 345);
            this.lblErrorePassword.Name = "lblErrorePassword";
            this.lblErrorePassword.Size = new System.Drawing.Size(22, 13);
            this.lblErrorePassword.TabIndex = 11;
            this.lblErrorePassword.Text = "-----";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(53, 269);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(228, 20);
            this.txtPassword.TabIndex = 10;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(53, 253);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.Text = "Password:";
            // 
            // lblErroreVecchiaPassword
            // 
            this.lblErroreVecchiaPassword.AutoSize = true;
            this.lblErroreVecchiaPassword.Location = new System.Drawing.Point(53, 223);
            this.lblErroreVecchiaPassword.Name = "lblErroreVecchiaPassword";
            this.lblErroreVecchiaPassword.Size = new System.Drawing.Size(22, 13);
            this.lblErroreVecchiaPassword.TabIndex = 14;
            this.lblErroreVecchiaPassword.Text = "-----";
            // 
            // txtVecchiaPassword
            // 
            this.txtVecchiaPassword.Location = new System.Drawing.Point(53, 200);
            this.txtVecchiaPassword.Name = "txtVecchiaPassword";
            this.txtVecchiaPassword.PasswordChar = '•';
            this.txtVecchiaPassword.Size = new System.Drawing.Size(228, 20);
            this.txtVecchiaPassword.TabIndex = 15;
            // 
            // btnConferma
            // 
            this.btnConferma.Location = new System.Drawing.Point(125, 427);
            this.btnConferma.Name = "btnConferma";
            this.btnConferma.Size = new System.Drawing.Size(75, 23);
            this.btnConferma.TabIndex = 16;
            this.btnConferma.Text = "Conferma";
            this.btnConferma.UseVisualStyleBackColor = true;
            this.btnConferma.Click += new System.EventHandler(this.btnConferma_Click);
            // 
            // btnIndietro
            // 
            this.btnIndietro.Location = new System.Drawing.Point(247, 576);
            this.btnIndietro.Name = "btnIndietro";
            this.btnIndietro.Size = new System.Drawing.Size(75, 23);
            this.btnIndietro.TabIndex = 17;
            this.btnIndietro.Text = "Indietro";
            this.btnIndietro.UseVisualStyleBackColor = true;
            this.btnIndietro.Click += new System.EventHandler(this.btnIndietro_Click);
            // 
            // CambioPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 611);
            this.Controls.Add(this.btnIndietro);
            this.Controls.Add(this.btnConferma);
            this.Controls.Add(this.txtVecchiaPassword);
            this.Controls.Add(this.lblErroreVecchiaPassword);
            this.Controls.Add(this.txtConfermaPassword);
            this.Controls.Add(this.lblConfermaPassword);
            this.Controls.Add(this.lblErrorePassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblVecchiaPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CambioPassword";
            this.Text = "CambioPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVecchiaPassword;
        private System.Windows.Forms.TextBox txtConfermaPassword;
        private System.Windows.Forms.Label lblConfermaPassword;
        private System.Windows.Forms.Label lblErrorePassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblErroreVecchiaPassword;
        private System.Windows.Forms.TextBox txtVecchiaPassword;
        private System.Windows.Forms.Button btnConferma;
        private System.Windows.Forms.Button btnIndietro;
    }
}