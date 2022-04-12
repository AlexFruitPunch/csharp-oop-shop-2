using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Csharp_Shop_2;

namespace Csharp_Shop_2
{
    internal class Elettrodomestico : Prodotto
    {
        private string LuogodiProduzione;


        public Elettrodomestico(int codiceElettrodomestico, string nomeElettrodomestico, string descrizioneElettrodomestico, double prezzoElettrodomestico, string categoriaElettrodomestico) : base(codiceElettrodomestico, nomeElettrodomestico, descrizioneElettrodomestico, prezzoElettrodomestico, categoriaElettrodomestico)
        {
        }
    }
}
