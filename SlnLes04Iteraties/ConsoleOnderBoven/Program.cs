// See https://aka.ms/new-console-template for more information
internal class OnderBoven
{
    private static void Main(String[] args)
    {
        int bovenGrens;
        int onderGrens;

        Console.Write("Geef een ondergrens: ");
        onderGrens = Convert.ToInt32(Console.ReadLine());

        Console.Write("Geef een bovengrens: ");
        bovenGrens = Convert.ToInt32(Console.ReadLine());

        while (bovenGrens < onderGrens)
        {
            Console.Write("Bovengrens mag niet kleiner zijn dan ondergrens. Geef een bovengrens: ");
            bovenGrens = Convert.ToInt32(Console.ReadLine());
        }
        while (bovenGrens == onderGrens)
        {
            Console.Write("Bovengrens mag niet gelijk zijn aan ondergrens. Geef een bovengrens: ");
            bovenGrens = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine($"Bereik: van {onderGrens} tot {bovenGrens}");
        Console.ReadKey();
    }
}