// See https://aka.ms/new-console-template for more information
class Tafels
{
    private static string DrukTafel(int get, int len)
    {
        // vervolledig hier
        string tekst = "";
        for (int i = 1; i <= len; i++)
        {
            tekst += $"{get} x {i} = {get * i}" + Environment.NewLine;
        }
        return tekst;
    }

    static void Main(String[] args)
    {
        Console.Write("Geef een getal: ");
        int getal = Convert.ToInt32(Console.ReadLine());

        Console.Write("Geef een lengte: ");
        int lengte = Convert.ToInt32(Console.ReadLine());

        string tafel = DrukTafel(getal, lengte);
        Console.WriteLine(tafel);
        Console.ReadKey();
    }
}
