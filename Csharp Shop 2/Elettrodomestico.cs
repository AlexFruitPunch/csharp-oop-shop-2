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
        private string luogodiProduzione;
        private string classeEnergetica;

        public Elettrodomestico(int codiceElettrodomestico, string nomeElettrodomestico, string descrizioneElettrodomestico, double prezzoElettrodomestico, string categoriaElettrodomestico, string luogodiProduzione, string classeEnergetica) : base(codiceElettrodomestico, nomeElettrodomestico, descrizioneElettrodomestico, prezzoElettrodomestico, categoriaElettrodomestico)
        {
            this.luogodiProduzione = luogodiProduzione;
            this.classeEnergetica = classeEnergetica;
        }

        //----- Metodi -----

        public override void StampaProdotto()
        {
            base.StampaProdotto();
            Console.WriteLine("--- Informazioni aggiuntive ---");
            Console.WriteLine("Luogo di Produzione: " + luogodiProduzione);
            Console.WriteLine("classe Energetica: " + classeEnergetica + "\n");
        }

        //------ Getters ------ 

        public string GetluogodiProduzione()
        {
            return luogodiProduzione;
        }

        public string GetclasseEnergetica()
        {
            return classeEnergetica;
        }


        //------ fine Getters ------ 

        //------ Setters ------ 

        public void SetluogodiProduzione(string luogodiProduzione)
        {
            this.luogodiProduzione = luogodiProduzione;
        }

        public void SetclasseEnergetica(string classeEnergetica)
        {
            this.classeEnergetica = classeEnergetica;
        }

        //------ fine Setters ------ 
    }
}
