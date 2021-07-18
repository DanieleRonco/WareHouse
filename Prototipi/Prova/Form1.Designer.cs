namespace Prova
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.Img1 = new System.Windows.Forms.PictureBox();
            this.Lbl1 = new System.Windows.Forms.Label();
            this.Cmb1 = new System.Windows.Forms.ComboBox();
            this.Txt1 = new System.Windows.Forms.TextBox();
            this.Btn1 = new System.Windows.Forms.Button();
            this.Txt2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Img1)).BeginInit();
            this.SuspendLayout();
            // 
            // Img1
            // 
            this.Img1.Location = new System.Drawing.Point(125, 100);
            this.Img1.Name = "Img1";
            this.Img1.Size = new System.Drawing.Size(396, 210);
            this.Img1.TabIndex = 0;
            this.Img1.TabStop = false;
            // 
            // Lbl1
            // 
            this.Lbl1.AutoSize = true;
            this.Lbl1.Location = new System.Drawing.Point(92, 37);
            this.Lbl1.Name = "Lbl1";
            this.Lbl1.Size = new System.Drawing.Size(35, 13);
            this.Lbl1.TabIndex = 1;
            this.Lbl1.Text = "label1";
            this.Lbl1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Cmb1
            // 
            this.Cmb1.FormattingEnabled = true;
            this.Cmb1.Location = new System.Drawing.Point(324, 53);
            this.Cmb1.Name = "Cmb1";
            this.Cmb1.Size = new System.Drawing.Size(121, 21);
            this.Cmb1.TabIndex = 2;
            // 
            // Txt1
            // 
            this.Txt1.Location = new System.Drawing.Point(95, 348);
            this.Txt1.Name = "Txt1";
            this.Txt1.Size = new System.Drawing.Size(100, 20);
            this.Txt1.TabIndex = 3;
            // 
            // Btn1
            // 
            this.Btn1.Location = new System.Drawing.Point(401, 370);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(75, 23);
            this.Btn1.TabIndex = 4;
            this.Btn1.Text = "button1";
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // Txt2
            // 
            this.Txt2.AccessibleName = "Txt2";
            this.Txt2.Location = new System.Drawing.Point(614, 100);
            this.Txt2.Name = "Txt2";
            this.Txt2.Size = new System.Drawing.Size(100, 20);
            this.Txt2.TabIndex = 5;
            this.Txt2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.AccessibleName = "btnProva";
            this.button1.Location = new System.Drawing.Point(614, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Txt2);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.Txt1);
            this.Controls.Add(this.Cmb1);
            this.Controls.Add(this.Lbl1);
            this.Controls.Add(this.Img1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Img1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Img1;
        private System.Windows.Forms.Label Lbl1;
        private System.Windows.Forms.ComboBox Cmb1;
        private System.Windows.Forms.TextBox Txt1;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.TextBox Txt2;
        private System.Windows.Forms.Button button1;
    }
}

