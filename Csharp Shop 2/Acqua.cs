using Csharp_Shop_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Shop_2
{
    internal class Acqua : Prodotto
    {
        private double litri; //litri inseriti/bevuti dalla bottiglia 
        private double capienzaMassima;
        private double capienzaAttuale;
        private int ph;
        private string sorgente;

        public Acqua(int codiceAcqua, string nomeAcqua, string descrizioneAcqua, double prezzoAcqua, string categoriaAcqua, double litri, double capienzaMassima, int ph, string sorgente): base(codiceAcqua, nomeAcqua, descrizioneAcqua, prezzoAcqua, categoriaAcqua)
        {
            capienzaAttuale = 0;
            this.ph = ph;
            this.sorgente = sorgente;
            this.litri = litri;
            this.capienzaMassima = capienzaMassima;
            ControlloLitri();
        }

        //------ Metodi ------ 

        private void ControlloLitri()
        {
            if (litri < capienzaMassima )
            {
                capienzaAttuale = litri;
            }
            else if(litri == capienzaMassima)
            {
                capienzaAttuale = capienzaMassima;
            }else{
                Console.WriteLine("Hai sbordato la confezione");
                Console.WriteLine("la bottiglia verrà riempita al massimo ma ci sarà un esubero");
                capienzaAttuale = capienzaMassima;
            }
        }

        public void bevi(double litriBevuti)
        {
            capienzaAttuale = capienzaAttuale - litriBevuti;
            if(capienzaAttuale < 0)
            {
                capienzaAttuale = 0;
                Console.WriteLine("hai finito la bottiglia");
            }
            else
            {
                Console.WriteLine("ti rimangono: " + Math.Round(capienzaAttuale,2) + " litri");
            }
        }

        public void Riempi(double litriInseriti)
        {
            capienzaAttuale = capienzaAttuale + litriInseriti;
            if (capienzaAttuale > capienzaMassima)
            {
                double sbordo;
                sbordo = capienzaAttuale - capienzaMassima;
                capienzaAttuale = capienzaMassima;
                Console.WriteLine("la bottiglia è stata riempita al massimo ma hai avuto uno sbordo d'acqua di " + Math.Round(sbordo,2) + " litri");
            }
            else
            {
                Console.WriteLine("ti rimangono: " + Math.Round(capienzaAttuale, 2) + " litri");
            }
        }

        public void Svuota(double litriInseriti)
        {
            capienzaAttuale = 0;
        }

        //------ fine Metodi ------ 

        //------ Getters ------ 

        public double GetLitri()
        {
            return litri;
        }

        public double GetCapienzaAttuale()
        {
            return capienzaAttuale;
        }

        public int Getph()
        {
            return ph;
        }

        public string GetSorgente()
        {
            return sorgente;
        }

        public double GetCapienzaMax()
        {
            return capienzaMassima;
        }

        //------ fine Getters ------ 

        //------ Setters ------ 

        public void SetLitri(double nuovilitri)
        {
            this.litri = nuovilitri;
            ControlloLitri();
        }

        public void SetCapienzaMax(double capienzaMassima)
        {
            this.capienzaMassima = capienzaMassima;
        }

        public void SetCapienzaAttuale(double capienzaAttuale)
        {
            this.capienzaAttuale= capienzaAttuale;
        }

        //------ fine Setters ------ 
    }
}
