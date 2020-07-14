using System;

/**
 * С помощью рефлексии выведите все свойства структуры DateTime
 */

namespace Task8_1
{
    class Program
    {
        static void Main()
        {
            Type type = typeof(DateTime);

            foreach(var prop in type.GetProperties() )
            {
                Console.WriteLine( prop.Name );
            }
        }
    }
}
