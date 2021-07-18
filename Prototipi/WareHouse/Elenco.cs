using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WareHouse
{
    public partial class Elenco : Form
    {
        public Elenco()
        {
            InitializeComponent();
        }

        private void btnImpostazioni_Click(object sender, EventArgs e)
        {
            Impostazioni FinestraImpostazioni = new Impostazioni();
            FinestraImpostazioni.Show();
            this.Hide();
        }

        private void btnEsci_Click(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i != -1; i = Application.OpenForms.Count - 1)
            {
                Application.OpenForms[i].Close();
            }
        }
    }
}