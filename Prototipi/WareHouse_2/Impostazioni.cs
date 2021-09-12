using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;

namespace WareHouse
{
    public partial class Impostazioni : Form
    {
        public Impostazioni()
        {
            InitializeComponent();
        }

        CElenco ListaElencoPassata = new CElenco();

        public Impostazioni(CElenco passata)
        {
            InitializeComponent();
            ListaElencoPassata = passata;
        }

        string percorsoAccesso = Directory.GetCurrentDirectory() + "\\DatiApplicazione\\Accesso.txt";
        private void btnLoginAutomaticoSI_Click(object sender, EventArgs e)
        {
            File.WriteAllText(percorsoAccesso, "1");
        }
        private void btnLoginAutomaticoNO_Click(object sender, EventArgs e)
        {
            File.WriteAllText(percorsoAccesso, "0");
        }

        private void btnCambiaPassword_Click(object sender, EventArgs e)
        {
            CambioPassword FinestraCambioPassword = new CambioPassword(ListaElencoPassata);
            FinestraCambioPassword.Show();
            this.Hide();
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
    }
}