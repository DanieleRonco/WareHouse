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
    public partial class Registrazione : Form
    {
        public Registrazione()
        {
            InitializeComponent();
        }

        CElenco ListaElencoPassata;

        public Registrazione(CElenco passata)
        {
            InitializeComponent();
            ListaElencoPassata = passata;
        }

        string ERROREOBBLIGATORI = "Attenzione! Nome e Cognome sono campi obbligatori!";
        string ERROREEMAIL = "Attenzione! Email non valida!";
        string ERROREPASSWORD = "La Password deve avere tra i 5 e i 10 caratteri\n" +
            "La Password deve contenere almeno 3 numeri\n" +
            "La Password deve contenere almeno 1 lettera maiuscola\n" +
            "La Password può contenere solo maiuscole, minuscole e numeri\n";
        string ERROREPASSWORDDIVERSE = "La Password e la Conferma Password devono essere uguali!\n";

        private void btnRegistrati_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string cognome = txtCognome.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string confermaPassword = txtConfermaPassword.Text;

            lblObbligatori.Text = "";
            lblErroreEmail.Text = "";
            lblErrorePassword.Text = "";

            bool nomeCognomeCorretti = true;
            bool emailCorretta = true;
            bool passwordCorretta = true;

            if (nome == "" || cognome == "")
            {
                nomeCognomeCorretti = false;
                lblObbligatori.Text = ERROREOBBLIGATORI;
            } 

            if (!IsValidEmail(email))
            {
                emailCorretta = false;
                lblErroreEmail.Text = ERROREEMAIL;
            }

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

            if (nomeCognomeCorretti && emailCorretta && passwordCorretta)
            {
                string percorsoDatiAccount = Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 9) + "DatiApplicazione\\Account.txt";
                File.WriteAllText(percorsoDatiAccount, nome + ";" + cognome + ";\n" + email + ";" + password + ";");

                Elenco FinestraElenco = new Elenco(ListaElencoPassata);
                FinestraElenco.Show();
                this.Hide();
            }
        }
        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void btnIndietro_Click(object sender, EventArgs e)
        {
            Accesso FinestraAccesso = new Accesso(ListaElencoPassata);
            FinestraAccesso.Show();
            this.Hide();
        }
    }
}