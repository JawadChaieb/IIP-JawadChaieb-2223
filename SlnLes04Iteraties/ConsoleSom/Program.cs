// See https://aka.ms/new-console-template for more information
class Som
{
    static void Main(String[] args)
    {
        string invoer;

        do
        {
            Console.Write("Voer een getal in (q om te stoppen): ");
            invoer = Console.ReadLine();

            int totaal = 0;

            if (invoer != "q")
            {
                int invoerGetal = Convert.ToInt32(invoer);
                totaal += invoerGetal;
            }
            else
                Console.WriteLine($"De som is {totaal}");
        }
        while (invoer != "q");
    }
}

