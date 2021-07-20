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

        CElenco ListaElencoPassata;

        public Elenco(CElenco passata)
        {
            InitializeComponent();
            ListaElencoPassata = passata;
        }

        private void btnImpostazioni_Click(object sender, EventArgs e)
        {
            Impostazioni FinestraImpostazioni = new Impostazioni(ListaElencoPassata);
            FinestraImpostazioni.Show();
            this.Hide();
        }

        private void btnElenco_Click(object sender, EventArgs e)
        {
            Elenco FinestraElenco = new Elenco(ListaElencoPassata);
            FinestraElenco.Show();
            this.Hide();
        }

        private void btnInquadra_Click(object sender, EventArgs e)
        {
            Inquadra FinestraInquadra = new Inquadra(ListaElencoPassata);
            FinestraInquadra.Show();
            this.Hide();
        }

        private void btnEsci_Click(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i != -1; i = Application.OpenForms.Count - 1)
            {
                Application.OpenForms[i].Close();
            }
        }

        private void Elenco_Load(object sender, EventArgs e)
        {

        }
    }
}