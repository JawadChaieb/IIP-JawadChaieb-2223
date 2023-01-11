class ConsoleSchrikkeljaar
{
    private static string Schrikkeljaar(int jaar)
    {
        string antwoord = "";
        if (jaar <= 0)
        {
            antwoord += "De programma zal sluiten";
        }
        else if (jaar % 4 == 0 && jaar % 100 != 0 || jaar % 400 == 0)
        {
            antwoord += $"Het jaar {jaar} is een schrikkeljaar";
        }
        else
        {
            antwoord += $"Het jaar {jaar} is geen schrikkeljaar";
        }
        return antwoord;
    }

    private static void DrukMenu()
    {
        int invoer;
        do
        {
            Console.Write("Geef een jaartal: ");
            invoer = Convert.ToInt32(Console.ReadLine());

            string resultaat = Schrikkeljaar(invoer);
            Console.WriteLine(resultaat);
        } while (invoer != 0);

        return;
    }
    static void Main(String[] Args)
    {
        Console.WriteLine(@"SCHRIKKELJAAR============");

        DrukMenu();

        Console.ReadKey();
    }
}