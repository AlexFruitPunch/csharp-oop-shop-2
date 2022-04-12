using Csharp_Shop_2;
using System.Globalization;

Console.WriteLine("----------- Shop -----------");
Console.WriteLine("\nInserisci i dati del prodotto");

Console.WriteLine("------ Bottiglia acqua ------");

//Codice
Random r = new Random();
int mioCodice = r.Next(0, 100000000);

//Nome
Console.Write("Nome: ");
string mioNome = (Console.ReadLine());

//descrizione
Console.Write("Descrizione: ");
string miaDescrizione = (Console.ReadLine());

//prezzo
Console.Write("Prezzo: ");
double mioPrezzo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//categoria
Console.Write("Categoria - [alimentari/Spezie/Carni/Altro]: ");
string miaCategoria = Console.ReadLine().ToLower();

//Litri massimi della bottiglia
Console.Write("Inserisci la capienza massima in litri: ");
double miaCapienza = double.Parse(Console.ReadLine());

//Litri da inserire
Console.Write("Inserisci i litri da inserire nella bottiglia: ");
double mieiLitri = double.Parse(Console.ReadLine());

//Sorgente d'origine
Console.Write("Inserisci la sorgente di provenienza: ");
string miaSorgente = Console.ReadLine();

//ph
Console.Write("Inserisci il pH dell'acqua: ");
int mioPh = int.Parse(Console.ReadLine());

Acqua miaAcqua = new Acqua(mioCodice, mioNome, miaDescrizione, mioPrezzo, miaCategoria, mieiLitri, miaCapienza, mioPh, miaSorgente);


Console.WriteLine("------ Sacchetto di Frutta ------");

//Codice
Random r2 = new Random();
int mioCodice2 = r2.Next(0, 99999999);

//Nome
Console.Write("Nome: ");
string mioNome2 = (Console.ReadLine());

//descrizione
Console.Write("Descrizione: ");
string mioDescrizione2 = (Console.ReadLine());

//prezzo
Console.Write("Prezzo: ");
double mioPrezzo2 = double.Parse(Console.ReadLine());

//categoria
Console.Write("Categoria - [alimentari/Spezie/Carni/Altro]: ");
string miaCategoria2 = Console.ReadLine().ToLower();

//prezzo
Console.Write("Inserisci i pezzi di frutta da insacchettare[max 5]: ");
int pezziDiFrutta = int.Parse(Console.ReadLine());

SacchettodiFrutta miaFrutta = new SacchettodiFrutta(mioCodice2, mioNome2, mioDescrizione2, mioPrezzo2, miaCategoria2, pezziDiFrutta);



Console.WriteLine("------ Elettrodomestico ------");

//Codice
Random r3 = new Random();
int mioCodice3 = r3.Next(0, 99999999);

//Nome
Console.Write("Nome: ");
string mioNome3 = (Console.ReadLine());

//descrizione
Console.Write("Descrizione: ");
string mioDescrizione3 = (Console.ReadLine());

//prezzo
Console.Write("Prezzo: ");
double mioPrezzo3 = double.Parse(Console.ReadLine());

//categoria
Console.Write("Categoria - [alimentari/Spezie/Carni/Altro]: ");
string miaCategoria3 = Console.ReadLine().ToLower();

//luogo di produzione
Console.Write("Inserisci il luogo di produzione: ");
string luogodiProduzione = Console.ReadLine().ToLower();

//categoria
Console.Write("Classe Energetica: ");
string miaClasseEnergetica = Console.ReadLine().ToLower();

Elettrodomestico mioElettrodomestico = new Elettrodomestico(mioCodice3, mioNome3, mioDescrizione3, mioPrezzo3, miaCategoria3, luogodiProduzione, miaClasseEnergetica);

Console.WriteLine("------ Cibo in Scatola ------");

//Codice
Random r4 = new Random();
int mioCodice4 = r.Next(0, 100000000);

//Nome
Console.Write("Nome: ");
string mioNome4 = (Console.ReadLine());

//descrizione
Console.Write("Descrizione: ");
string mioDescrizione4 = (Console.ReadLine());

//prezzo
Console.Write("Prezzo: ");
double mioPrezzo4 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//categoria
Console.Write("Categoria - [alimentari/Spezie/Carni/Altro]: ");
string miaCategoria4 = Console.ReadLine().ToLower();

//peso
Console.Write("Inserisci il peso della lattina: ");
double Pesolattina = double.Parse((Console.ReadLine()));

//Luogo di produzione
Console.Write("Inserisci il luogo di produzione: ");
string LuogoProduzione = Console.ReadLine().ToLower();

//Scadenza
Console.Write("Inserisci la data di scadenza: ");
string Scadenza = Console.ReadLine().ToLower();


CiboInScatola mioCiboScatola = new CiboInScatola(mioCodice4, mioNome4, mioDescrizione4, mioPrezzo4, miaCategoria4, Pesolattina, LuogoProduzione, Scadenza);

//Stampa dei 4 prodotti

Console.WriteLine("Ecco i 4 prodotti che hai inserito:");
miaAcqua.StampaProdotto();
miaFrutta.StampaProdotto();
mioElettrodomestico.StampaProdotto();
mioCiboScatola.StampaProdotto();

Console.WriteLine("Vuoi vedere il prezzo del prodotto(senza iva)? [si/no]");
string scelta = Console.ReadLine().ToLower();
bool imputcorretto = false;

while (imputcorretto == false)
{
    if (scelta == "si")
    {
        imputcorretto = true;
        int numeroDelProdotto;
        Console.WriteLine("quale dei 4 prodotti vuoi vedere ? [ 1 - acqua / 2 - frutta / 3 - elettrodomestico / 4 - cibo in scatola]");
        numeroDelProdotto = int.Parse(Console.ReadLine());
        double PrezzoInquestione;

        switch (numeroDelProdotto)
        {
            case 1:
                PrezzoInquestione = miaAcqua.GetPrezzo();
                Console.WriteLine("il prezzo senza iva di" + miaAcqua.GetNome() + " è: " + PrezzoInquestione);
                break;
            case 2:
                PrezzoInquestione = miaFrutta.GetPrezzo();
                Console.WriteLine("il prezzo senza iva di" + miaFrutta.GetNome() + " è: " + PrezzoInquestione);
                break;
            case 3:
                PrezzoInquestione = mioElettrodomestico.GetPrezzo();
                Console.WriteLine("il prezzo senza iva di" + mioElettrodomestico.GetNome() + " è: " + PrezzoInquestione);
                break;
            case 4:
                PrezzoInquestione = mioCiboScatola.GetPrezzo();
                Console.WriteLine("il prezzo senza iva di" + mioCiboScatola.GetNome() + " è: " + PrezzoInquestione);
                break;
            default:
                Console.WriteLine("imput errato");
                break;
        }
    }
    else if (scelta == "no")
    {
        imputcorretto = true;
        Console.WriteLine("Grazie per aver scelto il nostro programma");
    }
    else
    {
        Console.WriteLine("imput errato, ti prego di inserire un imput corretto");
    }
}






