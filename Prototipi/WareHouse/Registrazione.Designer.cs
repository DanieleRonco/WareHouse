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
            this.btnRegistrati = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblErrorePassword = new System.Windows.Forms.Label();
            this.lblErroreEmail = new System.Windows.Forms.Label();
            this.txtConfermaPassword = new System.Windows.Forms.TextBox();
            this.lblConfermaPassword = new System.Windows.Forms.Label();
            this.btnIndietro = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCognome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.lblObbligatori = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRegistrati
            // 
            this.btnRegistrati.Location = new System.Drawing.Point(123, 475);
            this.btnRegistrati.Name = "btnRegistrati";
            this.btnRegistrati.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrati.TabIndex = 0;
            this.btnRegistrati.Text = "Registrati";
            this.btnRegistrati.UseVisualStyleBackColor = true;
            this.btnRegistrati.Click += new System.EventHandler(this.btnRegistrati_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(46, 229);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(46, 309);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(46, 245);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(228, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(46, 325);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(228, 20);
            this.txtPassword.TabIndex = 4;
            // 
            // lblErrorePassword
            // 
            this.lblErrorePassword.AutoSize = true;
            this.lblErrorePassword.Location = new System.Drawing.Point(46, 401);
            this.lblErrorePassword.Name = "lblErrorePassword";
            this.lblErrorePassword.Size = new System.Drawing.Size(22, 13);
            this.lblErrorePassword.TabIndex = 5;
            this.lblErrorePassword.Text = "-----";
            // 
            // lblErroreEmail
            // 
            this.lblErroreEmail.AutoSize = true;
            this.lblErroreEmail.Location = new System.Drawing.Point(46, 268);
            this.lblErroreEmail.Name = "lblErroreEmail";
            this.lblErroreEmail.Size = new System.Drawing.Size(22, 13);
            this.lblErroreEmail.TabIndex = 6;
            this.lblErroreEmail.Text = "-----";
            // 
            // txtConfermaPassword
            // 
            this.txtConfermaPassword.Location = new System.Drawing.Point(46, 378);
            this.txtConfermaPassword.Name = "txtConfermaPassword";
            this.txtConfermaPassword.PasswordChar = '•';
            this.txtConfermaPassword.Size = new System.Drawing.Size(228, 20);
            this.txtConfermaPassword.TabIndex = 8;
            // 
            // lblConfermaPassword
            // 
            this.lblConfermaPassword.AutoSize = true;
            this.lblConfermaPassword.Location = new System.Drawing.Point(46, 362);
            this.lblConfermaPassword.Name = "lblConfermaPassword";
            this.lblConfermaPassword.Size = new System.Drawing.Size(103, 13);
            this.lblConfermaPassword.TabIndex = 7;
            this.lblConfermaPassword.Text = "Conferma password:";
            // 
            // btnIndietro
            // 
            this.btnIndietro.Location = new System.Drawing.Point(247, 576);
            this.btnIndietro.Name = "btnIndietro";
            this.btnIndietro.Size = new System.Drawing.Size(75, 23);
            this.btnIndietro.TabIndex = 9;
            this.btnIndietro.Text = "Indietro";
            this.btnIndietro.UseVisualStyleBackColor = true;
            this.btnIndietro.Click += new System.EventHandler(this.btnIndietro_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(46, 83);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 10;
            this.lblNome.Text = "Nome:";
            // 
            // lblCognome
            // 
            this.lblCognome.AutoSize = true;
            this.lblCognome.Location = new System.Drawing.Point(46, 134);
            this.lblCognome.Name = "lblCognome";
            this.lblCognome.Size = new System.Drawing.Size(55, 13);
            this.lblCognome.TabIndex = 11;
            this.lblCognome.Text = "Cognome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(46, 99);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(228, 20);
            this.txtNome.TabIndex = 12;
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(46, 150);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(228, 20);
            this.txtCognome.TabIndex = 13;
            // 
            // lblObbligatori
            // 
            this.lblObbligatori.AutoSize = true;
            this.lblObbligatori.Location = new System.Drawing.Point(46, 173);
            this.lblObbligatori.Name = "lblObbligatori";
            this.lblObbligatori.Size = new System.Drawing.Size(22, 13);
            this.lblObbligatori.TabIndex = 14;
            this.lblObbligatori.Text = "-----";
            // 
            // Registrazione
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Name = "Registrazione";
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