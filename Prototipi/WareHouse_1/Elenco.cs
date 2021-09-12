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

            CaricaSuListView(ListaElencoPassata.getLista());
        }

        public Elenco(CElenco passata, double codice)
        {
            InitializeComponent();
            ListaElencoPassata = passata;

            CaricaSuListView(ListaElencoPassata.getListaPerCodice(codice));
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

        private void btnCerca_Click(object sender, EventArgs e)
        {
            CaricaSuListView(ListaElencoPassata.getListaPerNome(txtCerca.Text));
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            if (ListaElencoPassata.RiduciPerNome(lstElenco.SelectedItems[0].ToString())) 
                CaricaSuListView(ListaElencoPassata.getLista());
        }

        void CaricaSuListView(List<CProdotto> listaPassata)
        {
            lstElenco.Items.Clear();
            
            //imageListLarge.Images.Add(Bitmap.FromFile("C:\\MyLargeImage2.bmp"));
            for (int i = 0; i < listaPassata.Count(); i++)
            {
                var item = new ListViewItem(new[] { listaPassata.ElementAt(i).getNome(), listaPassata.ElementAt(i).getCodice().ToString(), listaPassata.ElementAt(i).getQuantita().ToString() });
                lstElenco.Items.Add(item);
            }
        }

        private void btnDimentica_Click(object sender, EventArgs e)
        {
            ListaElencoPassata.DimenticaPerNome(lstElenco.SelectedItems[0].ToString());
            CaricaSuListView(ListaElencoPassata.getLista());
        }
    }
}