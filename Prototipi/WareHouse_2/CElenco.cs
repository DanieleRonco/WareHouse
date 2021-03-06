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

					pTemp = new CProdotto(campi[0], Convert.ToDouble(campi[1]), Convert.ToInt32(campi[2]), campi[3]);
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

		public bool RiduciPerNome(string nomePassato)
		{
			for(int i = 0; i < ListaElenco.Count(); i++)
			{
				if(nomePassato.IndexOf(ListaElenco.ElementAt(i).getNome()) != -1)
				{
					ListaElenco.ElementAt(i).setQuantita(ListaElenco.ElementAt(i).getQuantita() - 1);
					if (ListaElenco.ElementAt(i).getQuantita() == -1)
					{
						ListaElenco.ElementAt(i).setQuantita(0);
					}

					this.Esporta();

					return true;
				}
			}
			return false;
		}

		public bool RiduciPerCodice(double codicePassato, int quantita)
		{
			for (int i = 0; i < ListaElenco.Count(); i++)
			{
				if(ListaElenco.ElementAt(i).getCodice() == codicePassato)
				{
					ListaElenco.ElementAt(i).setQuantita(ListaElenco.ElementAt(i).getQuantita() - quantita);
					if (ListaElenco.ElementAt(i).getQuantita() < 0)
					{
						ListaElenco.ElementAt(i).setQuantita(0);
					}

					this.Esporta();

					return true;
				}
			}
			return false;
		}

		public bool DimenticaPerNome(string nomePassato)
		{
			for (int i = 0; i < ListaElenco.Count(); i++)
			{
				if (nomePassato.IndexOf(ListaElenco.ElementAt(i).getNome()) != -1)
				{
					ListaElenco.RemoveAt(i);

					this.Esporta();

					return true;
				}
			}
			return false;
		}

		public List<CProdotto> getLista()
		{
			return ListaElenco;
		} 

		public CProdotto getProdotto(int posizione)
		{
			return ListaElenco.ElementAt(posizione);
		}

		public List<CProdotto> getListaPerNome(string nomePassato)
		{
			List<CProdotto> listaNomi = new List<CProdotto>();

			for(int i = 0; i < ListaElenco.Count(); i++)
			{
				if (ListaElenco.ElementAt(i).getNome() == nomePassato) listaNomi.Add(ListaElenco.ElementAt(i));
			}

			return listaNomi;
		}

		public List<CProdotto> getListaPerCodice(double codicePassato)
		{
			List<CProdotto> listaCodici = new List<CProdotto>();

			for (int i = 0; i < ListaElenco.Count(); i++)
			{
				if (ListaElenco.ElementAt(i).getCodice() == codicePassato) listaCodici.Add(ListaElenco.ElementAt(i));
			}

			return listaCodici;
		}

		public bool CercaPerCodice(double codicePassato)
		{
			for(int i = 0; i < ListaElenco.Count(); i++)
			{
				if (ListaElenco.ElementAt(i).getCodice() == codicePassato) return true;
			}
			return false;
		}

		public void AumentaQuantita(double codicePassato, int quantitaPassata)
		{
			for (int i = 0; i < ListaElenco.Count(); i++)
			{
				if (ListaElenco.ElementAt(i).getCodice() == codicePassato)
					ListaElenco.ElementAt(i).setQuantita(ListaElenco.ElementAt(i).getQuantita() + quantitaPassata);
			}
		}
	}
}