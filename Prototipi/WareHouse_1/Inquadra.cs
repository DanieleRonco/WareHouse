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
using AForge.Video.DirectShow;
using AForge.Video;
using ZXing;

namespace WareHouse
{
    public partial class Inquadra : Form
    {
        public Inquadra()
        {
            InitializeComponent();
        }

        CElenco ListaElencoPassata;

        public Inquadra(CElenco passata)
        {
            InitializeComponent();
            ListaElencoPassata = passata;
        }

        FilterInfoCollection FilterInfoCollection;
        VideoCaptureDevice VideoCaptureDevice;

        string ERRORECAMPO = "Campo " +
            "obbligatorio!";
        string ERRORENONPRESENTE = "Prodotto non presente!";

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

        private void Inquadra_Load(object sender, EventArgs e)
        {
            FilterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in FilterInfoCollection)
                cmbFotocamera.Items.Add(device.Name);
            cmbFotocamera.SelectedIndex = 0;

            //vedere se seleziona la fotocamera qui o se le tre righe vanno spostate in un bottone
            VideoCaptureDevice = new VideoCaptureDevice(FilterInfoCollection[cmbFotocamera.SelectedIndex].MonikerString);
            VideoCaptureDevice.NewFrame += VideoCaptureDevice_newFrame;
            VideoCaptureDevice.Start();
        }

        private void VideoCaptureDevice_newFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            BarcodeReader reader = new BarcodeReader();
            var result = reader.Decode(bitmap);
            if (result != null)
            {
                txtCodice.Invoke(new MethodInvoker(delegate ()
                {
                    txtCodice.Text = result.ToString();
                }));
                txtCodice.Text = result.ToString();
            }
            imgInquadra.Image = bitmap;
        }

        private void Inquadra_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (VideoCaptureDevice != null)
            {
                if (VideoCaptureDevice.IsRunning)
                {
                    VideoCaptureDevice.Stop();
                }
            }
        }

        void Pulisci()
        {
            txtCodice.Text = "";
            txtNome.Text = "";
            txtQuantita.Text = "1";

            lblErroreCodice.Text = "";
            lblErroreNome.Text = "";
            lblNonPresente.Text = "";
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "")
            {
                if (txtCodice.Text != "")
                {
                    CProdotto daAggiungere = new CProdotto(txtNome.Text, Convert.ToDouble(txtCodice.Text), Convert.ToInt32(txtQuantita.Text)); //cambia in caso di immagine

                    if (ListaElencoPassata.CercaPerCodice(daAggiungere.getCodice()))
                    {
                        ListaElencoPassata.AumentaQuantita(daAggiungere.getCodice(), daAggiungere.getQuantita());
                    }
                    else ListaElencoPassata.Aggiungi(daAggiungere);

                    Pulisci();
                }
                else lblErroreCodice.Text = ERRORECAMPO;
            }
            else lblErroreNome.Text = ERRORECAMPO;
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            if (txtCodice.Text != "")
            {
                if (ListaElencoPassata.RiduciPerCodice(Convert.ToDouble(txtCodice.Text), Convert.ToInt32(txtQuantita.Text))) Pulisci();
                else lblNonPresente.Text = ERRORENONPRESENTE;
            }
            else lblErroreCodice.Text = ERRORECAMPO;
        }

        private void btnCerca_Click(object sender, EventArgs e)
        {
            if (txtCodice.Text != "")
            {
                if (ListaElencoPassata.CercaPerCodice(Convert.ToDouble(txtCodice.Text)))
                {
                    Elenco FinestraElenco = new Elenco(ListaElencoPassata, Convert.ToDouble(txtCodice.Text));
                    FinestraElenco.Show();
                    this.Hide();

                    Pulisci();
                }
                else lblNonPresente.Text = ERRORENONPRESENTE;
            }
            else lblErroreCodice.Text = ERRORECAMPO;
        }

        private void btnQuantitaPiu_Click(object sender, EventArgs e)
        {
            txtQuantita.Text = (Convert.ToInt32(txtQuantita.Text) + 1).ToString();
        }

        private void btnQuantitaMeno_Click(object sender, EventArgs e)
        {
            txtQuantita.Text = (Convert.ToInt32(txtQuantita.Text) - 1).ToString();
            if (txtQuantita.Text == "0") txtQuantita.Text = "1";
        }
    }
}