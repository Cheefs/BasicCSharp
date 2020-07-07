using System;

/**
 * 5. 
 *  а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или все в норме;
 *  б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
 */

namespace Task2_5
{
    class Program
    {
        const double IMT_MIN = 18.5;
        const double IMT_MAX = 24.9;
        static void Main()
        {
            GetWeightRecomendations();
        }

        static void GetWeightRecomendations()
        {
            Console.Write("Enter your height, sm: ");
            double height = double.Parse(Console.ReadLine()) / 100;
            Console.Write("Enter your weight, kg: ");
            double weight = double.Parse(Console.ReadLine());

            double imt = CalculateImt(height, weight);
            double etalonWeight = (height * 100) - 110;

            if (imt < IMT_MIN)
            {
                Console.WriteLine($"{(etalonWeight - weight):F2} кг, нужно набрать");
            }
            else if (imt > IMT_MAX)
            {
                Console.WriteLine($"{(weight - etalonWeight):F2} кг, нужно сбросить");
            }
            else
            {
                Console.WriteLine($"Ваш вес в пределах нормы");
            }
        }

        static double CalculateImt(double height, double weight)
        {
            return weight / Math.Pow(height, 2);
        }
    }
}
