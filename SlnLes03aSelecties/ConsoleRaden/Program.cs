using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRaden
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///Getal dat moet geraad worden
            int getal = 3;

            Console.Write("Raad een getal tussen 1 en 10: ");

            ///Gok gebruiker
            int raad = Convert.ToInt32(Console.ReadLine());

            ///Als gok groter dan het getal is
            if (raad > getal)
            {
                Console.WriteLine("De gok was te hoog");
            }
            ///Als gok kleiner dan het getal is
            else if (raad < getal)
            {
                Console.WriteLine("De gok was te laag");
            }
            ///Anders dan de twee vorige
            else
            {
                Console.WriteLine("Je hebt het juiste getal geraden !! ");
            }

            Console.ReadKey();
        }
    }
}
