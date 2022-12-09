// See https://aka.ms/new-console-template for more information
class Bestelling
{
    const int PRIJS_MARGHERITA = 8;
    const int PRIJS_FUNGHI = 10;
    const int PRIJS_DIABOLO = 11;
    const int PRIJS_BEZORGING = 3;


    static void Main(string[] agrs)
    {
        string pizzakeuze = "";
        string grootteKeuze = "";
        string bezorgingsKeuze = "";
        double totaal = 0;


        Console.Write(@"PIZZA BESTELLING
        ================

        Kies je pizza: 
        a) Margherita 8 euro
        b) Funghi 10 euro
        c) Diabolo 11 euro
        >>> Wat is je keuze? ");

        char pizza = Convert.ToChar(Console.ReadLine());


        Console.Write(@"Kies de grootte:
        a) 15 cm (klein; - 20%)
        b) 20 cm (normaal)
        c) 25 cm (groot + 20%)
        >>> Wat is je keuze? ");

        char grootte = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("Thuis bezorgen (3 euro extra)? ja/nee: ");
        string bezorging = Console.ReadLine();

        switch (pizza)
        {
            case 'a': pizzakeuze = "Margharita"; totaal += PRIJS_MARGHERITA; break;

            case 'b': pizzakeuze = "Funghi"; totaal += PRIJS_FUNGHI; break;

            case 'c': pizzakeuze = "Diabolo"; totaal += PRIJS_FUNGHI; break;

            default: break;
        }
        switch (grootte)
        {
            case 'a': grootteKeuze = "kleine"; totaal *= 0.8; break;

            case 'b': grootteKeuze = "normale"; totaal *= 1; break;
            case 'c': grootteKeuze = "grote"; totaal *= 1.2; break;

            default:; break;
        }

        switch (bezorging)
        {
            case "ja": bezorgingsKeuze = "thuis bezorging"; totaal += PRIJS_BEZORGING; break;

            case "nee": bezorgingsKeuze = "afhalen"; break;
            default: break;
        }
        Console.WriteLine($"Jouw bestelling: 1 {grootteKeuze} pizza {pizzakeuze} , voor  {totaal} euro, {bezorgingsKeuze}");

    }
}

