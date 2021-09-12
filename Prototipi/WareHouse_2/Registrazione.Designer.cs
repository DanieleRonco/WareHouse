namespace WareHouse
{
    partial class Registrazione
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registrazione));
            this.btnRegistrati = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblErrorePassword = new System.Windows.Forms.Label();
            this.lblErroreEmail = new System.Windows.Forms.Label();
            this.txtConfermaPassword = new System.Windows.Forms.TextBox();
            this.lblConfermaPassword = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCognome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.lblObbligatori = new System.Windows.Forms.Label();
            this.btnIndietro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegistrati
            // 
            this.btnRegistrati.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnRegistrati.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrati.Font = new System.Drawing.Font("Bahnschrift Condensed", 13F);
            this.btnRegistrati.ForeColor = System.Drawing.Color.White;
            this.btnRegistrati.Location = new System.Drawing.Point(24, 508);
            this.btnRegistrati.Name = "btnRegistrati";
            this.btnRegistrati.Size = new System.Drawing.Size(287, 34);
            this.btnRegistrati.TabIndex = 0;
            this.btnRegistrati.Text = "Registrati";
            this.btnRegistrati.UseVisualStyleBackColor = false;
            this.btnRegistrati.Click += new System.EventHandler(this.btnRegistrati_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Bahnschrift Condensed", 10F);
            this.lblEmail.Location = new System.Drawing.Point(47, 218);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(36, 17);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Bahnschrift Condensed", 10F);
            this.lblPassword.Location = new System.Drawing.Point(47, 310);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(55, 17);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(50, 238);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(228, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(50, 330);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(228, 20);
            this.txtPassword.TabIndex = 4;
            // 
            // lblErrorePassword
            // 
            this.lblErrorePassword.AutoSize = true;
            this.lblErrorePassword.Font = new System.Drawing.Font("Bahnschrift Condensed", 9F);
            this.lblErrorePassword.Location = new System.Drawing.Point(47, 396);
            this.lblErrorePassword.Name = "lblErrorePassword";
            this.lblErrorePassword.Size = new System.Drawing.Size(0, 14);
            this.lblErrorePassword.TabIndex = 5;
            // 
            // lblErroreEmail
            // 
            this.lblErroreEmail.AutoSize = true;
            this.lblErroreEmail.Font = new System.Drawing.Font("Bahnschrift Condensed", 10F);
            this.lblErroreEmail.Location = new System.Drawing.Point(47, 261);
            this.lblErroreEmail.Name = "lblErroreEmail";
            this.lblErroreEmail.Size = new System.Drawing.Size(0, 17);
            this.lblErroreEmail.TabIndex = 6;
            // 
            // txtConfermaPassword
            // 
            this.txtConfermaPassword.Location = new System.Drawing.Point(50, 373);
            this.txtConfermaPassword.Name = "txtConfermaPassword";
            this.txtConfermaPassword.PasswordChar = '•';
            this.txtConfermaPassword.Size = new System.Drawing.Size(228, 20);
            this.txtConfermaPassword.TabIndex = 8;
            // 
            // lblConfermaPassword
            // 
            this.lblConfermaPassword.AutoSize = true;
            this.lblConfermaPassword.Font = new System.Drawing.Font("Bahnschrift Condensed", 10F);
            this.lblConfermaPassword.Location = new System.Drawing.Point(47, 353);
            this.lblConfermaPassword.Name = "lblConfermaPassword";
            this.lblConfermaPassword.Size = new System.Drawing.Size(103, 17);
            this.lblConfermaPassword.TabIndex = 7;
            this.lblConfermaPassword.Text = "Conferma password:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Bahnschrift Condensed", 10F);
            this.lblNome.Location = new System.Drawing.Point(47, 95);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 17);
            this.lblNome.TabIndex = 10;
            this.lblNome.Text = "Nome:";
            // 
            // lblCognome
            // 
            this.lblCognome.AutoSize = true;
            this.lblCognome.Font = new System.Drawing.Font("Bahnschrift Condensed", 10F);
            this.lblCognome.Location = new System.Drawing.Point(47, 138);
            this.lblCognome.Name = "lblCognome";
            this.lblCognome.Size = new System.Drawing.Size(52, 17);
            this.lblCognome.TabIndex = 11;
            this.lblCognome.Text = "Cognome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(50, 115);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(228, 20);
            this.txtNome.TabIndex = 12;
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(50, 158);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(228, 20);
            this.txtCognome.TabIndex = 13;
            // 
            // lblObbligatori
            // 
            this.lblObbligatori.AutoSize = true;
            this.lblObbligatori.Font = new System.Drawing.Font("Bahnschrift Condensed", 10F);
            this.lblObbligatori.Location = new System.Drawing.Point(47, 181);
            this.lblObbligatori.Name = "lblObbligatori";
            this.lblObbligatori.Size = new System.Drawing.Size(0, 17);
            this.lblObbligatori.TabIndex = 14;
            // 
            // btnIndietro
            // 
            this.btnIndietro.BackColor = System.Drawing.Color.Transparent;
            this.btnIndietro.FlatAppearance.BorderSize = 0;
            this.btnIndietro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIndietro.Image = global::WareHouse.Properties.Resources.ezgif1;
            this.btnIndietro.Location = new System.Drawing.Point(12, 12);
            this.btnIndietro.Name = "btnIndietro";
            this.btnIndietro.Size = new System.Drawing.Size(25, 25);
            this.btnIndietro.TabIndex = 9;
            this.btnIndietro.UseVisualStyleBackColor = false;
            this.btnIndietro.Click += new System.EventHandler(this.btnIndietro_Click);
            // 
            // Registrazione
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(334, 611);
            this.Controls.Add(this.lblObbligatori);
            this.Controls.Add(this.txtCognome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblCognome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnIndietro);
            this.Controls.Add(this.txtConfermaPassword);
            this.Controls.Add(this.lblConfermaPassword);
            this.Controls.Add(this.lblErroreEmail);
            this.Controls.Add(this.lblErrorePassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.btnRegistrati);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registrazione";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrazione";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrati;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblErrorePassword;
        private System.Windows.Forms.Label lblErroreEmail;
        private System.Windows.Forms.TextBox txtConfermaPassword;
        private System.Windows.Forms.Label lblConfermaPassword;
        private System.Windows.Forms.Button btnIndietro;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCognome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.Label lblObbligatori;
    }
}