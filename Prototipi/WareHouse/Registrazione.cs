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

        string ERROREEMAIL = "Attenzione! Email non valida!";
        string ERROREPASSWORD = "La Password deve essere lunga tra i 5 e i 10 caratteri\n" +
            "La Password deve contenere almeno 3 numeri\n" +
            "La Password deve contenere almeno 1 lettera maiuscola\n" +
            "La Password può contenere solo lettere maiuscole e minuscole e numeri\n";

        private void btnRegistrati_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string confermaPassword = txtConfermaPassword.Text;

            bool emailCorretta = true;
            bool passwordCorretta = true;

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

            if (password != confermaPassword) passwordCorretta = false;

            if (emailCorretta && passwordCorretta)
            {
                string percorsoDatiAccount = Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 9) + "DatiApplicazione\\Account.txt";
                File.WriteAllText(percorsoDatiAccount, email + ";" + password + ";");

                Elenco FinestraElenco = new Elenco();
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
            Accesso FinestraAccesso = new Accesso();
            FinestraAccesso.Show();
            this.Hide();
        }
    }
}