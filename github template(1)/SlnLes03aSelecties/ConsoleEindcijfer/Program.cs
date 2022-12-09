// See https://aka.ms/new-console-template for more information
internal class Eindcijfer
{
    private static void Main(string[] Args)
    {
        Console.WriteLine(@"Berekening eindcijfer
        =====================");

        Console.Write("Geef het cijfer dagelijks werk (op 20): ");
        double dagelijksWerk = Convert.ToDouble(Console.ReadLine());

        Console.Write("Geef het ccijfer op het project (op 20): ");
        double project = Convert.ToDouble(Console.ReadLine());

        Console.Write("Geef het cijfer op het examen (op 20): ");
        double examen = Convert.ToDouble(Console.ReadLine());

        double percentageDagelijks = (dagelijksWerk / 2) * 3;

        double percentageProject = project;

        double percentageExamen = (examen / 2) * 5;
        double eindcijfer;

        if (examen >= 8)
        {
            eindcijfer = percentageDagelijks + percentageProject + percentageExamen;
        }
        else
        {
            eindcijfer = Math.Min((percentageDagelijks + percentageProject + percentageExamen), percentageExamen) +
                Math.Min((percentageDagelijks + percentageProject + percentageExamen), percentageExamen);
        }

        Console.WriteLine($"Je eindcijfer is {Math.Round(eindcijfer, 1)}%");

        if (eindcijfer < 50)
        {
            Console.WriteLine("-> Onvoldoende");
        }
        else if (eindcijfer >= 50 && eindcijfer < 67.5)
        {
            Console.WriteLine("-> Voldoende");
        }
        else if (eindcijfer >= 67.5 && eindcijfer < 75)
        {
            Console.WriteLine("-> Onderscheiding");
        }
        else if (eindcijfer >= 75 && eindcijfer < 82.5)
        {
            Console.WriteLine("-> Grote onderscheiding");
        }
        else
        {
            Console.WriteLine("-> Hoogste onderscheiding");
        }
    }
}