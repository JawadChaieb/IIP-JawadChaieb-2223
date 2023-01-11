namespace PaswoordenSorteren
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] paswoorden = new string[6];
            List<string> paswoordOk = new List<string>();
            List<string> paswoordNietOk = new List<string>();

            Console.WriteLine("Volledige lijst: ");

            for (int i = 0; i < paswoorden.Length; i++)
            {
                Console.Write($"{i + 1}: ");
                paswoorden[i] = Console.ReadLine();
                if (paswoorden[i].Contains("@") || paswoorden[i].Length < 9 || paswoorden[i].Contains("paswoord"))
                {
                    paswoordNietOk.Add(paswoorden[i]);
                }
                else
                {
                    paswoordOk.Add(paswoorden[i]);
                }
            }

            Console.WriteLine("Niet ok: " + String.Join(", ", paswoordNietOk));

            Console.WriteLine("Ok: " + String.Join(", ", paswoordOk));
        }
    }
}