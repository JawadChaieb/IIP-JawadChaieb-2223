class ConsoleFaculteit
{
    private static int Faculteit(int n)
    {
        int i = (n - 1);
        do
        {
            n *= i;
            i--;
        } while (i >= 1);
        return n;
    }

    static void Main(String[] args)
    {
        Console.WriteLine("FACULTEIT BEREKENEN" + Environment.NewLine);

        Console.Write("Geef een geheel getal: ");
        int getal = Convert.ToInt32(Console.ReadLine());

        int faculteit = Faculteit(getal);

        Console.WriteLine($"De faculteit is {faculteit}");
    }
}
