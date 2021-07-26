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
    public partial class CambioPassword : Form
    {
        public CambioPassword()
        {
            InitializeComponent();
        }

        CElenco ListaElencoPassata;

        public CambioPassword(CElenco passata)
        {
            InitializeComponent();
            ListaElencoPassata = passata;
        }

        string ERROREVECCHIAPASSWORD = "La Password inserita non è uguale a quella vecchia!";
        string ERROREPASSWORD = "La Password deve avere tra i 5 e i 10 caratteri\n" +
            "La Password deve contenere almeno 3 numeri\n" +
            "La Password deve contenere almeno 1 lettera maiuscola\n" +
            "La Password può contenere solo maiuscole, minuscole e numeri\n";
        string ERROREPASSWORDDIVERSE = "La Password e la Conferma Password devono essere uguali!\n";

        private void btnConferma_Click(object sender, EventArgs e)
        {
            string percorsoDatiAccount = Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 9) + "DatiApplicazione\\Account.txt";
            string tutto = File.ReadAllText(percorsoDatiAccount);
            string[] linee = tutto.Split('\n');
            string[] campi = linee[1].Split(';');
            string vecchiaPasswordLetta = campi[1];
            string vecchiaPassword = txtVecchiaPassword.Text;
            string password = txtPassword.Text;
            string confermaPassword = txtConfermaPassword.Text;

            lblErroreVecchiaPassword.Text = "";
            lblErrorePassword.Text = "";

            if(vecchiaPassword == vecchiaPasswordLetta)
            {
                bool passwordCorretta = true;

                if (password.Length < 5 || password.Length > 10) passwordCorretta = false;
                int numeri = 0, maiuscole = 0;
                for (int i = 0; i < password.Length; i++)
                {
                    if (password.ElementAt(i) >= 48 && password.ElementAt(i) <= 57) numeri++;
                    else if (password.ElementAt(i) >= 65 && password.ElementAt(i) <= 90) maiuscole++;
                    else if (password.ElementAt(i) < 65 || (password.ElementAt(i) > 90 && password.ElementAt(i) < 97) || password.ElementAt(i) > 122) passwordCorretta = false;
                }
                if (numeri != 3) passwordCorretta = false;
                if (maiuscole == 0) passwordCorretta = false;
                if (!passwordCorretta) lblErrorePassword.Text = ERROREPASSWORD;
                else if (password != confermaPassword)
                {
                    passwordCorretta = false;
                    lblErrorePassword.Text += ERROREPASSWORDDIVERSE;
                }

                if (passwordCorretta)
                {
                    campi[1] = password;
                    File.WriteAllText(percorsoDatiAccount, linee[0] + "\n" + campi[0] + ";" + campi[1] + ";");

                    funzioneFinestraIndietro();
                }
            } else
            {
                lblErroreVecchiaPassword.Text = ERROREVECCHIAPASSWORD;
            }
        }

        private void btnIndietro_Click(object sender, EventArgs e)
        {
            funzioneFinestraIndietro();
        }

        void funzioneFinestraIndietro()
        {
            Impostazioni FinestraImpostazioni = new Impostazioni(ListaElencoPassata);
            FinestraImpostazioni.Show();
            this.Hide();
        }
    }
}