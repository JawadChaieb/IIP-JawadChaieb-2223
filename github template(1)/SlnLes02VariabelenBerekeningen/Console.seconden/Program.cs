using System;

class Program
{
    static void Main(string[] args)
    {
        // seconden invoegen
        Console.Write("Geef het aantal seconden: ");
        int aantalSeconden = Convert.ToInt32(Console.ReadLine());

        //uren berekening
        int uren = aantalSeconden / 3600;

        int restUren = aantalSeconden % 3600;

        //minuten berekening
        int minuten = restUren / 60;

        int restMinuten = restUren % 60;

        //seconden berekening
        int seconden = restMinuten / 1;

        int dagen = aantalSeconden / (24 * 60 * 60);

        //Het omzet van seconden naar uren minuten en seconden
        Console.Write($"Dit zijn ");
        Console.WriteLine(Convert.ToString(dagen).PadLeft(2, '0') +
            " dagen, " +
            Convert.ToString(uren).PadLeft(2, '0') +
            " uren, " +
            Convert.ToString(minuten).PadLeft(2, '0') +
            " minuten " +
            Convert.ToString(seconden).PadLeft(2, '0') +
            " en seconden ");
        Console.ReadKey();

    }
}
