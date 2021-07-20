using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouse
{
    public class CProdotto
    {
        private string nome;
        private int codice;
        private int quantita;
        private string immagine;

        public CProdotto()
        {
            this.nome = "";
            this.codice = 0;
            this.quantita = 0;
            this.immagine = "";
        }

        public CProdotto(string nome, int codice, int quantita, string immagine)
        {
            this.nome = nome;
            this.codice = codice;
            this.quantita = quantita;
            this.immagine = immagine;
        }

        public CProdotto(string nome, int codice, int quantita)
        {
            this.nome = nome;
            this.codice = codice;
            this.quantita = quantita;
            this.immagine = "";
        }

        public string getNome()
        {
            return this.nome;
        }

        public int getCodice()
        {
            return this.codice;
        }

        public int getQuantita()
        {
            return this.quantita;
        }

        public string getImmagine()
        {
            return this.immagine;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public void setCodice(int codice)
        {
            this.codice = codice;
        }

        public void setQuantita(int quantita)
        {
            this.quantita = quantita;
        }

        public void setImmagine(string immagine)
        {
            this.immagine = immagine;
        }

        public string toCsv()
        {
            return this.nome + ";" + this.codice + ";" + this.quantita + ";" + this.immagine + ";"; //cambia in caso di immagine
        }
    }
}