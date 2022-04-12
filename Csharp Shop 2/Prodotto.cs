using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpShop
{
    public class Prodotto
    {
        private int codice;
        private string nome;
        private string descrizione;
        private double prezzo;
        private string categoria;
        private double iva = 22;

        public Prodotto(int codice, string nome, string descrizione, double prezzo, string categoria)
        {
            this.codice = codice;
            this.nome = nome;
            this.descrizione = descrizione;
            this.categoria = categoria;
            ControlloCategoria();
            this.prezzo = prezzo;
        }

        //--------------- Metodi ----------------

        public void StampaPrezzoBase()
        {
            Console.WriteLine("Prezzo Prodotto: " + prezzo + " (Iva esclusa)");
        }

        public void StampaNomeProdotto()
        {
            Console.WriteLine("prodotto: " + nome + " di Codice: " + codice);
        }

        public void ControlloCategoria()
        {
            bool ImputCorretto = false;

            while (ImputCorretto == false)
            {
                switch (categoria)
                {
                    case "alimentari":
                        //Iva al 4%
                        SetIva(4);
                        ImputCorretto = true;
                        break;
                    case "spezie":
                        //Iva al 5%
                        ImputCorretto = true;
                        SetIva(5);
                        break;
                    case "carni":
                        //Iva al 10%
                        ImputCorretto = true;
                        SetIva(10);
                        break;
                    case "altro":
                        //Iva al 22%
                        ImputCorretto = true;
                        break;
                    default:
                        Console.WriteLine("Imput non valido, reinserisci la categoria giusta");
                        Console.Write("Categoria - [alimentari/Spezie/Carni/altro]: ");
                        categoria = Console.ReadLine();
                        break;
                }
            }
        }

        public void StampaProdotto()
        {
            Console.WriteLine("\n----- Prodotto -----");
            Console.WriteLine("Codice: " + ApprossimaCodice8cifre());
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Descrizione: " + descrizione);
            Console.WriteLine("Prezzo: " + GetPrezzoConIva() + " EUR (iva inclusa)");    /*"\u20AC" è un codice esadecimale che permette di stampare il simbolo di "€" */
        }

        //------------- Fine Metodi -------------


        //------------- Metodi Getter -------------

        public int GetCodice()
        {
            return codice;
        }

        public string GetNome()
        {
            return nome;
        }

        public string GetDescrizione()
        {
            return descrizione;
        }

        public double GetPrezzo()
        {
            return prezzo;
        }

        public double GetIva()
        {
            return iva;
        }

        public string GetCategoria()
        {
            return categoria;
        }

        public double GetPrezzoConIva()
        {
            double tasse;
            double prezzoConIva;
            tasse = (prezzo * iva) / 100;
            prezzoConIva = prezzo + tasse;
            return Math.Round(prezzoConIva,2);
        }

        //------------- Fine Metodi Getter -------------

        //------------- Metodi Setter -------------

        private string ApprossimaCodice8cifre()
        {
            string MioCodice = codice.ToString("D8");
            //Console.WriteLine("{0,22} {1,22}", codice.ToString("D8"));
            return MioCodice;
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public void SetDescrizione(string descrizione)
        {
            this.descrizione = descrizione;
        }

        public void SetPrezzo(double prezzo)
        {
            this.prezzo = prezzo;
        }

        public void SetCategoria(string categoria)
        {
            this.categoria = categoria;
        }

        public void SetIva(int iva)
        {
            this.iva = iva;
        }

        //------------- Fine Metodi Setter -------------
    }
}
