// See https://aka.ms/new-console-template for more information
class Lancering
{
    static void Main(string[] args)
    {
        Console.Write("Hoeveel seconden tot lancering? ");
        int seconden = Convert.ToInt32(Console.ReadLine());

        for (int i = seconden; i > 0; i--)
        {
            Console.WriteLine($"{i} ...");
        }
        Console.WriteLine("Lift off!");
        Console.ReadKey();
    }
}
