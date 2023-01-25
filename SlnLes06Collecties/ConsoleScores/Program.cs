using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleScores
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = { 10, 15, 16, 5, 19, 12, 18, 16, 7, 7 };
            Console.WriteLine($"Scores test: {numbers[0]},{numbers[1]},{numbers[2]},{numbers[3]},{numbers[4]},{numbers[5]},{numbers[6]},{numbers[7]},{numbers[8]} en {numbers[9]}");
            double gem = numbers.Average();
            double highest = numbers.Max();
            double lowest = numbers.Min();

            Console.WriteLine("Het gemiddelde is " + gem);
            Console.WriteLine("de hoogste score is " + highest);
            Console.WriteLine("de laagste score is " + lowest);
            Console.Read();
        }
    }
}