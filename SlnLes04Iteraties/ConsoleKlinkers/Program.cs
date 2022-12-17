// See https://aka.ms/new-console-template for more information
using System.Text;
class Klinkers
{
    static void Main(String[] args)
    {
        Console.Write("Geef een tekst: ");
        string tekst = Console.ReadLine();

        int aantalKlinkers = 0;
        int aantalMedeklinkers = 0;
        int aantalSpaties = 0;
        int aantalCijfers = 0;
        int aantalSymbolen = 0;

        for (int i = 0; i < tekst.Length; i++)
        {
            if (tekst[i] == 'a' || tekst[i] == 'e' || tekst[i] == 'i' || tekst[i] == 'o' || tekst[i] == 'u' ||
                tekst[i] == 'A' || tekst[i] == 'E' || tekst[i] == 'I' || tekst[i] == 'O' || tekst[i] == 'U')
            {
                aantalKlinkers++;
            }
            else if (tekst[i] == '1' || tekst[i] == '2' || tekst[i] == '3' || tekst[i] == '4' ||
                tekst[i] == '5' || tekst[i] == '6' || tekst[i] == '7' || tekst[i] == '8' ||
                tekst[i] == '9' || tekst[i] == '0')
            {
                aantalCijfers++;
            }
            else if (tekst[i] == ' ')
            {
                aantalSpaties++;
            }
            else if (tekst[i] == '.' || tekst[i] == '!' || tekst[i] == ';' || tekst[i] == ':' ||
                tekst[i] == '+' || tekst[i] == '-' || tekst[i] == '_' || tekst[i] == '(' ||
                tekst[i] == ')' || tekst[i] == '=' || tekst[i] == '%' || tekst[i] == '*' ||
                tekst[i] == '$' || tekst[i] == '€' || tekst[i] == '@' || tekst[i] == ',')
            {
                aantalSymbolen++;
            }
            else
            {
                aantalMedeklinkers++;
            }

        }

        Console.WriteLine($"Deze tekst bevat {aantalKlinkers} klinker, {aantalMedeklinkers} medeklinkers, " +
            $"{aantalCijfers} cijfers, {aantalSpaties} spaties en {aantalSymbolen} symbolen.");

        Console.Write("In het geheimschrift: ");

        foreach (char letters in tekst)
        {
            Console.Write((char)Convert.ToChar(letters + 1));
        }
        Console.ReadKey();
    }
}

