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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Elenco));
            this.btnElenco = new System.Windows.Forms.Button();
            this.btnInquadra = new System.Windows.Forms.Button();
            this.lstElenco = new System.Windows.Forms.ListView();
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Codice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantita = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtCerca = new System.Windows.Forms.TextBox();
            this.btnCerca = new System.Windows.Forms.Button();
            this.btnElimina = new System.Windows.Forms.Button();
            this.btnDimentica = new System.Windows.Forms.Button();
            this.btnEsci = new System.Windows.Forms.Button();
            this.btnImpostazioni = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnElenco
            // 
            this.btnElenco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnElenco.FlatAppearance.BorderSize = 0;
            this.btnElenco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElenco.Image = ((System.Drawing.Image)(resources.GetObject("btnElenco.Image")));
            this.btnElenco.Location = new System.Drawing.Point(109, 564);
            this.btnElenco.Name = "btnElenco";
            this.btnElenco.Size = new System.Drawing.Size(120, 48);
            this.btnElenco.TabIndex = 0;
            this.btnElenco.UseVisualStyleBackColor = false;
            this.btnElenco.Click += new System.EventHandler(this.btnElenco_Click);
            // 
            // btnInquadra
            // 
            this.btnInquadra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnInquadra.FlatAppearance.BorderSize = 0;
            this.btnInquadra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInquadra.Image = ((System.Drawing.Image)(resources.GetObject("btnInquadra.Image")));
            this.btnInquadra.Location = new System.Drawing.Point(222, 564);
            this.btnInquadra.Name = "btnInquadra";
            this.btnInquadra.Size = new System.Drawing.Size(114, 48);
            this.btnInquadra.TabIndex = 2;
            this.btnInquadra.UseVisualStyleBackColor = false;
            this.btnInquadra.Click += new System.EventHandler(this.btnInquadra_Click);
            // 
            // lstElenco
            // 
            this.lstElenco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstElenco.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nome,
            this.Codice,
            this.Quantita});
            this.lstElenco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lstElenco.HideSelection = false;
            this.lstElenco.Location = new System.Drawing.Point(12, 41);
            this.lstElenco.Name = "lstElenco";
            this.lstElenco.Size = new System.Drawing.Size(310, 451);
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
            this.btnCerca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnCerca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerca.Font = new System.Drawing.Font("Bahnschrift Condensed", 10F);
            this.btnCerca.ForeColor = System.Drawing.Color.White;
            this.btnCerca.Location = new System.Drawing.Point(118, 8);
            this.btnCerca.Name = "btnCerca";
            this.btnCerca.Size = new System.Drawing.Size(75, 27);
            this.btnCerca.TabIndex = 6;
            this.btnCerca.Text = "Cerca";
            this.btnCerca.UseVisualStyleBackColor = false;
            this.btnCerca.Click += new System.EventHandler(this.btnCerca_Click);
            // 
            // btnElimina
            // 
            this.btnElimina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnElimina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElimina.Font = new System.Drawing.Font("Bahnschrift Condensed", 10F);
            this.btnElimina.ForeColor = System.Drawing.Color.White;
            this.btnElimina.Location = new System.Drawing.Point(55, 498);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(225, 27);
            this.btnElimina.TabIndex = 7;
            this.btnElimina.Text = "Riduci";
            this.btnElimina.UseVisualStyleBackColor = false;
            this.btnElimina.Click += new System.EventHandler(this.btnElimina_Click);
            // 
            // btnDimentica
            // 
            this.btnDimentica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnDimentica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDimentica.Font = new System.Drawing.Font("Bahnschrift Condensed", 10F);
            this.btnDimentica.ForeColor = System.Drawing.Color.White;
            this.btnDimentica.Location = new System.Drawing.Point(55, 531);
            this.btnDimentica.Name = "btnDimentica";
            this.btnDimentica.Size = new System.Drawing.Size(225, 27);
            this.btnDimentica.TabIndex = 11;
            this.btnDimentica.Text = "Dimentica";
            this.btnDimentica.UseVisualStyleBackColor = false;
            this.btnDimentica.Click += new System.EventHandler(this.btnDimentica_Click);
            // 
            // btnEsci
            // 
            this.btnEsci.BackColor = System.Drawing.Color.Transparent;
            this.btnEsci.FlatAppearance.BorderSize = 0;
            this.btnEsci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEsci.Image = global::WareHouse.Properties.Resources.ezgif2;
            this.btnEsci.Location = new System.Drawing.Point(311, -1);
            this.btnEsci.Name = "btnEsci";
            this.btnEsci.Size = new System.Drawing.Size(25, 25);
            this.btnEsci.TabIndex = 3;
            this.btnEsci.UseVisualStyleBackColor = false;
            this.btnEsci.Click += new System.EventHandler(this.btnEsci_Click);
            // 
            // btnImpostazioni
            // 
            this.btnImpostazioni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnImpostazioni.FlatAppearance.BorderSize = 0;
            this.btnImpostazioni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImpostazioni.Image = ((System.Drawing.Image)(resources.GetObject("btnImpostazioni.Image")));
            this.btnImpostazioni.Location = new System.Drawing.Point(0, 564);
            this.btnImpostazioni.Name = "btnImpostazioni";
            this.btnImpostazioni.Size = new System.Drawing.Size(112, 48);
            this.btnImpostazioni.TabIndex = 1;
            this.btnImpostazioni.UseVisualStyleBackColor = false;
            this.btnImpostazioni.Click += new System.EventHandler(this.btnImpostazioni_Click);
            // 
            // Elenco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Elenco";
            this.Text = "Elenco";
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