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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        CElenco ListaElencoPassata;

        private void Main_Load(object sender, EventArgs e)
        {
            string percorsoElenco = Directory.GetCurrentDirectory() + "\\DatiApplicazione\\Elenco.txt";
            ListaElencoPassata = new CElenco(percorsoElenco);

            ListaElencoPassata.Importa();
        }

        private void btnAvvia_Click(object sender, EventArgs e)
        {
            string percorsoAccesso = Directory.GetCurrentDirectory() + "\\DatiApplicazione\\Accesso.txt";

            if (File.ReadAllText(percorsoAccesso) == "1")
            {
                Elenco FinestraElenco = new Elenco(ListaElencoPassata);
                FinestraElenco.Show();
                this.Hide();
            }
            else
            {
                Accesso FinestraAccesso = new Accesso(ListaElencoPassata);
                FinestraAccesso.Show();
                this.Hide();
            }
        }
    }
}