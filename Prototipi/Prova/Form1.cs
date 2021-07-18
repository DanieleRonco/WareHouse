using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using System.IO;
using Microsoft.Win32;

namespace Prova
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        FilterInfoCollection FilterInfoCollection;
        VideoCaptureDevice VideoCaptureDevice;

        private void label1_Click(object sender, EventArgs e)
        {
            f.Clear();
            f pTemp;
            string linea = "";
            string tutto = File.ReadAllText(f);
            string[] Linee = tutto.Split('\n');
            for (int i = 0; i < Linee.Length; i++)
            {
                linea = Linee[i];
                string[] campi = linea.Split(';');
                pTemp = new f(campi[0], Convert.ToInt32(campi[1]));
                f.Add(pTemp);
            }


        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            VideoCaptureDevice = new VideoCaptureDevice(FilterInfoCollection[Cmb1.SelectedIndex].MonikerString);
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
                Txt1.Invoke(new MethodInvoker(delegate ()
                {
                    Txt1.Text = result.ToString();
                }));
                Txt1.Text = result.ToString();
            }
            Img1.Image = bitmap;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FilterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in FilterInfoCollection)
                Cmb1.Items.Add(device.Name);
            Cmb1.SelectedIndex = 0;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (VideoCaptureDevice != null)
            {
                if (VideoCaptureDevice.IsRunning)
                {
                    VideoCaptureDevice.Stop();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Aggiunta a = new Aggiunta(Txt2.Text);
            a.Show();
            this.Hide();
        }
    }
}