using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova
{
    public partial class Aggiunta : Form
    {
        public Aggiunta()
        {
            InitializeComponent();
        }

        public Aggiunta(string a)
        {
            InitializeComponent();
            MessageBox.Show(a);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            main.Show();
            this.Hide();
        }
    }
}