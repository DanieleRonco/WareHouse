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

        string percorsoAccesso = Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 9) + "DatiApplicazione\\Accesso.txt";
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
            CambioPassword FinestraCambioPassword = new CambioPassword();
            FinestraCambioPassword.Show();
            this.Hide();
        }

        private void btnElenco_Click(object sender, EventArgs e)
        {
            Elenco FinestraElenco = new Elenco();
            FinestraElenco.Show();
            this.Hide();
        }
    }
}