namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] fibonacci = new int[10];

            fibonacci[0] = 1;
            fibonacci[1] = 1;
            Console.Write("Eerste 10 fibonacci getallen: " + fibonacci[0] + " " + fibonacci[1] + " ");

            for (int i = 2; i < fibonacci.Length; i++)
            {
                fibonacci[i] = fibonacci[0] + fibonacci[1];
                Console.Write(fibonacci[i] + " ");
                fibonacci[0] = fibonacci[1];
                fibonacci[1] = fibonacci[i];
            }
            Console.ReadKey();

            Console.Clear();

            Console.Write("Hoeveel fibonacci getallen wil je uitdrukken: ");
            int uitdruk = Convert.ToInt32(Console.ReadLine());

            int[] nieuwFibonacci = new int[uitdruk];

            nieuwFibonacci[0] = 1;
            nieuwFibonacci[1] = 1;

            Console.Write($"De eerste {uitdruk} Fibonacci getallen: {nieuwFibonacci[0]} {nieuwFibonacci[1]} ");

            for (int i = 2; i < nieuwFibonacci.Length; i++)
            {
                nieuwFibonacci[i] = nieuwFibonacci[0] + nieuwFibonacci[1];
                Console.Write($"{nieuwFibonacci[i]} ");
                nieuwFibonacci[0] = nieuwFibonacci[1];
                nieuwFibonacci[1] = nieuwFibonacci[i];
            }
        }
    }
}
