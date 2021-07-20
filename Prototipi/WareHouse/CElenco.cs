using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Win32;

namespace WareHouse
{
    public class CElenco
    {
		private List<CProdotto> ListaElenco;
		private string percorso;

		public CElenco()
		{
			this.ListaElenco = new List<CProdotto>();
			this.percorso = "";
		}

		public CElenco(string percorso)
		{
			this.ListaElenco = new List<CProdotto>();
			this.percorso = percorso;
		}

		public void Importa()
		{
			ListaElenco.Clear();
			CProdotto pTemp;

			string linea = "";
			string tutto = File.ReadAllText(percorso);

			if(tutto != "")
			{
				string[] Linee = tutto.Split('\n');

				for (int i = 0; i < Linee.Length - 1; i++)
				{
					linea = Linee[i];
					string[] campi = linea.Split(';');

					pTemp = new CProdotto(campi[0], Convert.ToInt32(campi[1]), Convert.ToInt32(campi[2]), campi[3]); //cambia in caso di immagine
					ListaElenco.Add(pTemp);
				}
			}
		}

		public void Esporta()
		{
			File.WriteAllText(this.percorso, this.getAllCsv());
		}
		public string getAllCsv()
		{
			string ritorno = "";
			for (int i = 0; i < ListaElenco.Count(); i++) ritorno += ListaElenco.ElementAt(i).toCsv() + "\n";
			return ritorno;
		}

		public void Aggiungi(CProdotto passato)
		{
			this.ListaElenco.Add(passato);
			this.Esporta();
		}
	}
}