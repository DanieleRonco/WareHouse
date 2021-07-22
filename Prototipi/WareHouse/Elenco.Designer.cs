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
            this.lstElenco = new System.Windows.Forms.ListView();
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Codice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantita = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtCerca = new System.Windows.Forms.TextBox();
            this.btnCerca = new System.Windows.Forms.Button();
            this.btnElimina = new System.Windows.Forms.Button();
            this.btnDimentica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnElenco
            // 
            this.btnElenco.Location = new System.Drawing.Point(130, 576);
            this.btnElenco.Name = "btnElenco";
            this.btnElenco.Size = new System.Drawing.Size(75, 23);
            this.btnElenco.TabIndex = 0;
            this.btnElenco.Text = "Elenco";
            this.btnElenco.UseVisualStyleBackColor = true;
            this.btnElenco.Click += new System.EventHandler(this.btnElenco_Click);
            // 
            // btnImpostazioni
            // 
            this.btnImpostazioni.Location = new System.Drawing.Point(29, 576);
            this.btnImpostazioni.Name = "btnImpostazioni";
            this.btnImpostazioni.Size = new System.Drawing.Size(75, 23);
            this.btnImpostazioni.TabIndex = 1;
            this.btnImpostazioni.Text = "Impostazioni";
            this.btnImpostazioni.UseVisualStyleBackColor = true;
            this.btnImpostazioni.Click += new System.EventHandler(this.btnImpostazioni_Click);
            // 
            // btnInquadra
            // 
            this.btnInquadra.Location = new System.Drawing.Point(233, 576);
            this.btnInquadra.Name = "btnInquadra";
            this.btnInquadra.Size = new System.Drawing.Size(75, 23);
            this.btnInquadra.TabIndex = 2;
            this.btnInquadra.Text = "Inquadra";
            this.btnInquadra.UseVisualStyleBackColor = true;
            this.btnInquadra.Click += new System.EventHandler(this.btnInquadra_Click);
            // 
            // btnEsci
            // 
            this.btnEsci.Location = new System.Drawing.Point(247, 12);
            this.btnEsci.Name = "btnEsci";
            this.btnEsci.Size = new System.Drawing.Size(75, 23);
            this.btnEsci.TabIndex = 3;
            this.btnEsci.Text = "Esci";
            this.btnEsci.UseVisualStyleBackColor = true;
            this.btnEsci.Click += new System.EventHandler(this.btnEsci_Click);
            // 
            // lstElenco
            // 
            this.lstElenco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstElenco.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nome,
            this.Codice,
            this.Quantita});
            this.lstElenco.HideSelection = false;
            this.lstElenco.Location = new System.Drawing.Point(12, 41);
            this.lstElenco.Name = "lstElenco";
            this.lstElenco.Size = new System.Drawing.Size(310, 471);
            this.lstElenco.TabIndex = 4;
            this.lstElenco.UseCompatibleStateImageBehavior = false;
            this.lstElenco.View = System.Windows.Forms.View.Details;
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.Width = 125;
            // 
            // Codice
            // 
            this.Codice.Text = "Codice";
            this.Codice.Width = 131;
            // 
            // Quantita
            // 
            this.Quantita.Text = "Quantita";
            this.Quantita.Width = 52;
            // 
            // txtCerca
            // 
            this.txtCerca.Location = new System.Drawing.Point(12, 12);
            this.txtCerca.Name = "txtCerca";
            this.txtCerca.Size = new System.Drawing.Size(100, 20);
            this.txtCerca.TabIndex = 5;
            this.txtCerca.Text = "Nome";
            // 
            // btnCerca
            // 
            this.btnCerca.Location = new System.Drawing.Point(118, 12);
            this.btnCerca.Name = "btnCerca";
            this.btnCerca.Size = new System.Drawing.Size(75, 23);
            this.btnCerca.TabIndex = 6;
            this.btnCerca.Text = "Cerca";
            this.btnCerca.UseVisualStyleBackColor = true;
            this.btnCerca.Click += new System.EventHandler(this.btnCerca_Click);
            // 
            // btnElimina
            // 
            this.btnElimina.Location = new System.Drawing.Point(130, 518);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(75, 23);
            this.btnElimina.TabIndex = 7;
            this.btnElimina.Text = "Elimina";
            this.btnElimina.UseVisualStyleBackColor = true;
            this.btnElimina.Click += new System.EventHandler(this.btnElimina_Click);
            // 
            // btnDimentica
            // 
            this.btnDimentica.Location = new System.Drawing.Point(130, 547);
            this.btnDimentica.Name = "btnDimentica";
            this.btnDimentica.Size = new System.Drawing.Size(75, 23);
            this.btnDimentica.TabIndex = 11;
            this.btnDimentica.Text = "Dimentica";
            this.btnDimentica.UseVisualStyleBackColor = true;
            this.btnDimentica.Click += new System.EventHandler(this.btnDimentica_Click);
            // 
            // Elenco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 611);
            this.Controls.Add(this.btnDimentica);
            this.Controls.Add(this.btnElimina);
            this.Controls.Add(this.btnCerca);
            this.Controls.Add(this.txtCerca);
            this.Controls.Add(this.lstElenco);
            this.Controls.Add(this.btnEsci);
            this.Controls.Add(this.btnInquadra);
            this.Controls.Add(this.btnImpostazioni);
            this.Controls.Add(this.btnElenco);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Elenco";
            this.Text = "Elenco";
            this.Load += new System.EventHandler(this.Elenco_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnElenco;
        private System.Windows.Forms.Button btnImpostazioni;
        private System.Windows.Forms.Button btnInquadra;
        private System.Windows.Forms.Button btnEsci;
        private System.Windows.Forms.ListView lstElenco;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader Quantita;
        private System.Windows.Forms.ColumnHeader Codice;
        private System.Windows.Forms.TextBox txtCerca;
        private System.Windows.Forms.Button btnCerca;
        private System.Windows.Forms.Button btnElimina;
        private System.Windows.Forms.Button btnDimentica;
    }
}