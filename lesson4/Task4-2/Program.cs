using System;
using System.IO;

/**
 * 2. а) Дописать класс для работы с одномерным массивом.
 * Реализовать конструктор, создающий массив заданной размерности и заполняющий массив числами от начального значения с заданным шагом.
 * Создать свойство Sum, которые возвращают сумму элементов массива, метод Inverse, меняющий знаки у всех элементов массива,
 * Метод Multi, умножающий каждый элемент массива на определенное число, свойство MaxCount, возвращающее количество максимальных элементов
 * 
 * В Main продемонстрировать работу класса.
      б)*Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
 */

namespace Task4_2
{
    class MyArray
    {
        const string BASE_PATH = "./";
        const string FILE_NAME = "array.txt";
        const string DEVIDER = " ";

        int[] a;
        //  Создание массива и заполнение его одним значением el  
        public MyArray(int n, int el)
        {
            a = new int[n];
            for (int i = 0; i < n; i++)
                a[i] = el;
        }
        //  Создание массива и заполнение его случайными числами от min до max
        public MyArray(int n, int min, int max)
        {
            a = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                a[i] = rnd.Next(min, max);
        }

        public MyArray(int n, int min, int max, int step)
        {
            a = new int[n];
        
            for (int i = 0; i < n; i++)
            {
                if ( i == 0 )
                {
                    a[i] = min;
                    continue;
                }
                int newNumber = a[i - 1] + step;

                a[i] = newNumber > max ? max : newNumber;
            }
        }

        public int Max
        {
            get
            {
                int max = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] > max) max = a[i];
                return max;
            }
        }
        public int Min
        {
            get
            {
                int min = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] < min) min = a[i];
                return min;
            }
        }
        public int CountPositiv
        {
            get
            {
                int count = 0;
                for (int i = 0; i < a.Length; i++)
                    if (a[i] > 0) count++;
                return count;
            }
        }
        public override string ToString()
        {
            string s = "";
            foreach (int v in a)
                s = s + v + DEVIDER;
            return s;
        }

        public int Sum
        {
            get 
            {
                int result = 0;
                foreach (int item in a)
                {
                    result += item;
                }
                return result;
            }
        }

        public int MaxCount
        {
            get
            {
                int result = 0;
                int maxElement = Max;
                foreach (int item in a)
                {
                    result += item == maxElement ? 1 : 0;
                }
                return result;
            }
        }

        public void Multi( int myltyplyBy )
        {
            for( int i = 0; i < a.Length; i++ )
            {
                a[i] *= myltyplyBy;
            }
        }

        public void Inverse()
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] *= -1;
            }
        }

        public bool SaveToFile()
        {
            try
            {
                StreamWriter sw = new StreamWriter($"{ BASE_PATH }{ FILE_NAME }");
                foreach (int item in a)
                {
                    sw.WriteLine( item );
                }
               
                sw.Close();

                return true;
            }
            catch ( Exception )
            {
                return false;
            }
        }

        public bool ReadFile()
        {
            try
            {
                StreamReader sr = new StreamReader($"{ BASE_PATH }{ FILE_NAME }");

                for( int i = 0; i < a.Length; i ++)
                {
                    int newNumber;
                    bool isNumber = int.TryParse(sr.ReadLine(), out newNumber);

                    a[i] = isNumber ? newNumber : 0;
                }

                sr.Close();
                
                return true;
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Cant load data. File is not exists");
            }
            return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyArray a = new MyArray(10, 0, 30, 3);
            Console.WriteLine(a.ToString());
            Console.WriteLine(a.Max);
            Console.WriteLine(a.Min);
            Console.WriteLine(a.CountPositiv);

            Console.WriteLine(a.Sum);
            Console.WriteLine(a.MaxCount);

            Console.WriteLine($"Saved to file: { a.SaveToFile() }");

            a.Multi(2);
            Console.WriteLine(a.ToString());

            a.Inverse();
            Console.WriteLine(a.ToString());

            a.ReadFile();

            Console.WriteLine(a.ToString());
        }
    }
}