using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Csharp_Shop_2;

namespace Csharp_Shop_2
{
    internal class CiboInScatola : Prodotto
    {
        private string luogodiProduzione;
        private double peso;
        private double capienzaMax;

        public CiboInScatola(int codiceCiboInScatola, string nomeCiboInScatola, string descrizioneCiboInScatola, double prezzoCiboInScatola, string categoriaCiboInScatola, double peso, string luogodiProduzione) : base(codiceCiboInScatola, nomeCiboInScatola, descrizioneCiboInScatola, prezzoCiboInScatola, categoriaCiboInScatola)
        {
            this.luogodiProduzione = luogodiProduzione;
            this.peso = peso;
            capienzaMax = 300;
            ControlloCapienza();
        }

        //------ Metodi ------

        private void ControlloCapienza()
        {
            bool ImputCorretto = false;
            while(ImputCorretto == false)
            {
                if (peso > capienzaMax)
                {
                    Console.WriteLine("non si può inserire più di 300 gr per lattina");
                    Console.WriteLine("reinserisci un una grammatura giusta");
                    peso = int.Parse(Console.ReadLine());
                }else if (peso < 0)
                {
                    Console.WriteLine("il peso non può essere negativo");
                    Console.WriteLine("reinserisci un una grammatura giusta");
                    peso = int.Parse(Console.ReadLine());
                }
                else
                {
                    ImputCorretto = true;
                }
            }
        }
    }
}
