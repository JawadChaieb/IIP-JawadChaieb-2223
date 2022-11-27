class BMI
{


    static void Main(string[] args)
    {
        Console.WriteLine("BMI CALCULATOR");
        Console.WriteLine("==============");

        //Lengte tijpen
        Console.Write("Lengte (in cm): ");
        int lengteCm = Convert.ToInt32(Console.ReadLine());

        //Gewicht tijpen
        Console.Write("Gewicht (in kg):");
        int gewicht = Convert.ToInt32(Console.ReadLine());

        //omzetting cm naar m van Lengte
        double lengteM = Convert.ToDouble(lengteCm) / 100;


        //Berekening
        double BMI = Convert.ToDouble(gewicht) / (lengteM * lengteM);

        //resultaat
        Console.Write($"Je BMI bedraagt: " + (BMI = Math.Round(BMI, 2)));
    }
}
