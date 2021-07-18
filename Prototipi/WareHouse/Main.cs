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

        private void btnAvvia_Click(object sender, EventArgs e)
        {
            string percorsoAccesso = Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 9) + "DatiApplicazione\\Accesso.txt";
            
            if(File.ReadAllText(percorsoAccesso) == "1")
            {
                Elenco FinestraElenco = new Elenco();
                FinestraElenco.Show();
                this.Hide();
            } else
            {
                Accesso FinestraAccesso = new Accesso();
                FinestraAccesso.Show();
                this.Hide();
            }
        }
    }
}