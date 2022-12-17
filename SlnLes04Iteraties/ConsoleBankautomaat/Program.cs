// See https://aka.ms/new-console-template for more information
class Bankautomaat
{
    static void Main(String[] args)
    {
        int saldo = 500;
        string gekozenKeuze = "";
        int invoer;
        char keuze;
        const string AFHALEN = "Welk bedrag wil je afhalen: ";
        const string STORTEN = "Welke Saldo wil je storten: ";
        const string STOP = "Bedankt en tot ziens.";

        Console.WriteLine(@"Bankautomaat
        ==========");
        do
        {
            Console.WriteLine(@"a. afhaling
            b. storting
            c. stoppen");
            Console.Write("je keuze: ");
            keuze = Convert.ToChar(Console.ReadLine());
            if (keuze == 'c' || keuze == 'a' || keuze == 'b')
            {
                switch (keuze)
                {
                    case 'a': gekozenKeuze = AFHALEN; break;
                    case 'b': gekozenKeuze = STORTEN; break;
                    case 'c': gekozenKeuze = STOP; break;
                }

                Console.Write($"{gekozenKeuze}");

                if (gekozenKeuze == AFHALEN)
                {
                    invoer = Convert.ToInt32(Console.ReadLine());

                    saldo -= invoer;
                    Console.WriteLine($"Het niewe saldo is {saldo}");
                    Console.ReadLine();
                }
                else if (gekozenKeuze == STORTEN)
                {
                    invoer = Convert.ToInt32(Console.ReadLine());

                    saldo += invoer;
                    Console.WriteLine($"Het niewe saldo is {saldo}");
                    Console.ReadLine();
                }
                else if (gekozenKeuze == STOP)
                {
                    Console.WriteLine($"{STOP}");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
            }
            else
            {
                Console.WriteLine("Ongeldige keuze");
                Console.ReadLine();
            }
        } while (keuze != 'c');
    }
}
