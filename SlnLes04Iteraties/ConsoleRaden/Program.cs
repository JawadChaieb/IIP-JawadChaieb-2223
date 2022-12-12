// See https://aka.ms/new-console-template for more information
class Raden
{
    static void Main(String[] args)
    {
        Random rnd = new Random();
        int geheimGetal = (rnd.Next(0, 10));
        Console.WriteLine("Raad een getal tussen 0 en 10");

        int pogingNr = 0;
        int poging;

        do
        {
            pogingNr++;

            if (pogingNr > 3)
            {
                Console.WriteLine("Volgende keer beter");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else
                Console.Write($"Poging {pogingNr}: ");
            poging = Convert.ToInt32(Console.ReadLine());
        }
        while (poging != geheimGetal);
        Console.WriteLine("Geraden!");
    }
}
