class ConsoleTemperatuur
{
    private static string TempOmzet(char optie)
    {
        string resultaat = "";
        double invoer;
        if (optie == 'a')
        {
            Console.Write($"Celsius: ");
            invoer = Convert.ToDouble(Console.ReadLine());

            double cNaarf = (invoer * 1.8) + 32;

            resultaat += "Fahrenheit: " + Math.Round(cNaarf, 2);
        }
        else if (optie == 'b')
        {
            Console.Write($"Fahrenheit: ");
            invoer = Convert.ToDouble(Console.ReadLine());

            double fNaarc = (invoer - 32) / 1.8;

            resultaat += "Celsius: " + Math.Round(fNaarc, 2);
        }
        else if (optie == 'c')
        {
            Console.Write($"Celsius: ");
            invoer = Convert.ToDouble(Console.ReadLine());

            double cNaark = invoer + 237.15;

            resultaat += "Kelvin: " + Math.Round(cNaark, 2);
        }
        else if (optie == 'd')
        {
            Console.Write("Kelvin: ");
            invoer = Convert.ToDouble(Console.ReadLine());

            double kNaarc = invoer - 237.15;

            resultaat += "Celsius: " + Math.Round(kNaarc, 2);
        }
        else if (optie == 'x')
        {
            Environment.Exit(0);
        }
        else
        {
            resultaat += "Voer een van de gevraagde letters.";
        }
        return resultaat;
    }
    private static void DrukKeuze()
    {
        do
        {
            Console.Write(Environment.NewLine + "Maak je keuze: ");
            char keuze = Convert.ToChar(Console.ReadLine());

            string uitkomst = TempOmzet(keuze);
            Console.WriteLine(uitkomst);
        } while (true);

    }
    static void Main(String[] Args)
    {
        Console.WriteLine(@"TEMPERATUUR CONVERSIE=====================
        a. Celsius naar Fahrenheit
        b. Fahrenheit naar Celsius
        c. Celsius naar Kelvin
        d. Kelvin naar Celsius
        x. Afskuiten");

        DrukKeuze();

    }
}
