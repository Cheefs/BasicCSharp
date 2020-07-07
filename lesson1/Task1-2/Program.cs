using System;

/**
 * 2. Ввести вес и рост человека. Рассчитать и вывести индекс массы тела(ИМТ) по формуле I=m/(h*h); где m-масса тела в килограммах, h - рост в метрах
 **/

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your height, metrs: ");
            double height = double.Parse(Console.ReadLine());
            Console.Write("Enter your weight, kg: ");
            double weight = double.Parse(Console.ReadLine());

            Console.WriteLine($"Your IMT is: { CalculateImt( height, weight ) }");

        }

       static double CalculateImt(double height, double weight )
       {
            return weight / Math.Pow( height, 2 );
       }
    }
}
