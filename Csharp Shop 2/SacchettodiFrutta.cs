using Csharp_Shop_2;

namespace Csharp_Shop_2
{
    internal class SacchettodiFrutta : Prodotto
    {
        private int capienzaMax;
        private int pezziDiFrutta;
        private int capienzaAttuale;
        public SacchettodiFrutta(int codiceFrutta, string nomeFrutta, string descrizioneFrutta, double prezzoFrutta, string categoriaFrutta, int pezziDiFrutta) : base(codiceFrutta, nomeFrutta, descrizioneFrutta, prezzoFrutta, categoriaFrutta)
        {
            capienzaMax = 5;
            capienzaAttuale = 0;
            this.pezziDiFrutta = pezziDiFrutta;
            ControlloCapienza();
        }

        //----- Metodi -----

        private void ControlloCapienza()
        {
            bool imputCorretto = false;
            while(imputCorretto == false) { 
                if (pezziDiFrutta > capienzaMax)
                {
                    imputCorretto = true;
                    int pezziCaduti;
                    pezziCaduti = pezziDiFrutta - capienzaMax;
                    capienzaAttuale = capienzaMax;
                    Console.WriteLine("il sacchetto è pieno e alcuni pezzi di frutta sono caduti a terra");
                    Console.WriteLine("ti sono caduti " + pezziCaduti + "pezzi di " + base.GetNome() + " a terra");
                }else if (pezziDiFrutta == capienzaMax)
                {
                    imputCorretto = true;
                    capienzaAttuale = capienzaMax;
                }
                else
                {
                    Console.WriteLine("non puoi mettere dei pezzi di frutta in negativo");
                    Console.WriteLine("reinserisci il numero di pezzi necessario");
                    pezziDiFrutta = int.Parse(Console.ReadLine());
                }
            }
        }

        public void SvuotaSacchetto()
        {
            capienzaAttuale = 0;
            Console.WriteLine("il sacchetto ora è vuoto");
        }

        public void RiempiSacchetto(int pezziDiFrutta)
        {
            this.pezziDiFrutta = pezziDiFrutta;
            ControlloCapienza();
        }

        public void MangiaFrutta(int pezziDiFrutta)
        {
            bool imputCorretto = false;
            int fruttaRimasta = capienzaAttuale;
            capienzaAttuale = capienzaAttuale - pezziDiFrutta;
            while (imputCorretto == false) { }
            if (pezziDiFrutta > capienzaAttuale)
            {
                Console.WriteLine("non c'è abbastanza frutta per soddisfare la tua richiesta");
                Console.WriteLine("ti lascio " + fruttaRimasta + "pezzi di " + base.GetNome() + "che sono avanzati");
                Console.WriteLine("il sacchetto ora è vuoto");
                capienzaAttuale = 0;
                imputCorretto = true;
            }
            else if (pezziDiFrutta == capienzaMax)
            {
                imputCorretto = true;
                capienzaAttuale = 0;
                Console.WriteLine("hai mangiato tutti i pezzi di frutta");
            }
            else
            {
                Console.WriteLine("non puoi mettere dei pezzi di frutta in negativo");
                Console.WriteLine("reinserisci il numero di pezzi necessario");
                pezziDiFrutta = int.Parse(Console.ReadLine());
            }
        }

        public override void StampaProdotto()
        {
            base.StampaProdotto();
            Console.WriteLine("--- Informazioni aggiuntive ---");
            Console.WriteLine("Frutta attualmente nel sacchetto: " + capienzaAttuale + "/" + capienzaMax + "\n");
        }

        //----- Fine Metodi -----

        //----- Getters -----

        public int GetCapienzaMax()
        {
            return capienzaMax;
        }

        public double GetpezziDiFrutta()
        {
            return pezziDiFrutta;
        }

        public double GetcapienzaAttuale()
        {
            return capienzaAttuale;
        }

        //----- Fine Getters -----
    }
}