namespace WareHouse
{
    partial class Elenco
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
            this.btnElenco = new System.Windows.Forms.Button();
            this.btnImpostazioni = new System.Windows.Forms.Button();
            this.btnInquadra = new System.Windows.Forms.Button();
            this.btnEsci = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnElenco
            // 
            this.btnElenco.Location = new System.Drawing.Point(124, 576);
            this.btnElenco.Name = "btnElenco";
            this.btnElenco.Size = new System.Drawing.Size(75, 23);
            this.btnElenco.TabIndex = 0;
            this.btnElenco.Text = "Elenco";
            this.btnElenco.UseVisualStyleBackColor = true;
            // 
            // btnImpostazioni
            // 
            this.btnImpostazioni.Location = new System.Drawing.Point(23, 576);
            this.btnImpostazioni.Name = "btnImpostazioni";
            this.btnImpostazioni.Size = new System.Drawing.Size(75, 23);
            this.btnImpostazioni.TabIndex = 1;
            this.btnImpostazioni.Text = "Impostazioni";
            this.btnImpostazioni.UseVisualStyleBackColor = true;
            this.btnImpostazioni.Click += new System.EventHandler(this.btnImpostazioni_Click);
            // 
            // btnInquadra
            // 
            this.btnInquadra.Location = new System.Drawing.Point(227, 576);
            this.btnInquadra.Name = "btnInquadra";
            this.btnInquadra.Size = new System.Drawing.Size(75, 23);
            this.btnInquadra.TabIndex = 2;
            this.btnInquadra.Text = "Inquadra";
            this.btnInquadra.UseVisualStyleBackColor = true;
            // 
            // btnEsci
            // 
            this.btnEsci.Location = new System.Drawing.Point(247, 4);
            this.btnEsci.Name = "btnEsci";
            this.btnEsci.Size = new System.Drawing.Size(75, 23);
            this.btnEsci.TabIndex = 3;
            this.btnEsci.Text = "Esci";
            this.btnEsci.UseVisualStyleBackColor = true;
            this.btnEsci.Click += new System.EventHandler(this.btnEsci_Click);
            // 
            // Elenco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 611);
            this.Controls.Add(this.btnEsci);
            this.Controls.Add(this.btnInquadra);
            this.Controls.Add(this.btnImpostazioni);
            this.Controls.Add(this.btnElenco);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Elenco";
            this.Text = "Elenco";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnElenco;
        private System.Windows.Forms.Button btnImpostazioni;
        private System.Windows.Forms.Button btnInquadra;
        private System.Windows.Forms.Button btnEsci;
    }
}