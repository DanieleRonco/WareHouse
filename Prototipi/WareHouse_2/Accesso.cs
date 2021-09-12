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
    public partial class Accesso : Form
    {
        public Accesso()
        {
            InitializeComponent();
        }

        CElenco ListaElencoPassata;

        public Accesso(CElenco passata)
        {
            InitializeComponent();
            ListaElencoPassata = passata;
        }

        string ERRORE = "Errore! Dati inseriti non corretti!";

        private void btnRegistrati_Click(object sender, EventArgs e)
        {
            Registrazione FinestraRegistrazione = new Registrazione(ListaElencoPassata);
            FinestraRegistrazione.Show();
            this.Hide();
        }

        private void btnAccedi_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            string percorsoDatiAccount = Directory.GetCurrentDirectory() + "\\DatiApplicazione\\Account.txt";
            string tutto = File.ReadAllText(percorsoDatiAccount);
            string[] linee = tutto.Split('\n');
            string[] campi = linee[1].Split(';');
            string emailLetta = campi[0];
            string passwordLetta = campi[1];

            if (email == emailLetta && password == passwordLetta)
            {
                Elenco FinestraElenco = new Elenco(ListaElencoPassata);
                FinestraElenco.Show();
                this.Hide();
            }
            else lblErrore.Text = ERRORE;
        }
    }
}