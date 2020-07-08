using System;
using System.IO;

/**
 * 4. *а) Реализовать класс для работы с двумерным массивом.
 *      Реализовать конструктор, заполняющий массив случайными числами.
 *      Создать методы, которые возвращают сумму всех элементов массива,
 *      сумму всех элементов массива больше заданного,
 *      свойство, возвращающее минимальный элемент массива,
 *      свойство, возвращающее максимальный элемент массива,
 *      
 *      метод, возвращающий номер максимального элемента массива (через параметры, используя модификатор ref или out)
    **б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
 */

namespace Task4_4
{
    class TwoDimensionsArray
    {
        const int MAX = 10;
        const int MIN = 0;

        const string FILE_PATH = "./data.txt";
        const string SEPARATOR = ";";
        const string NEW_LINE = "!n";


        int[,] data;

        public int[,] Data { get; }

        public TwoDimensionsArray()
        {
           data = Load();
        }

        public TwoDimensionsArray( int rows, int cells )
        {
            Random rnd = new Random();

            data = new int[rows, cells];

            for( int i = 0; i < rows; i++ )
            {
                for (int j = 0; j < cells; j++)
                {
                    data[i, j] = rnd.Next( MIN, MAX);
                }
            }
        }

        public void Print()
        {
            for (int i = 0; i < data.GetLength( 0 ); i++)
            {
                string row = "";
                for (int j = 0; j < data.GetLength( 1 ); j++)
                {
                    row += $" { data[i, j] } ";
                }
                Console.WriteLine(row);
            }
        }

        public int Sum()
        {
            int sum = 0;
            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    sum +=  data[i, j];
                }
            }
            return sum;
        }

        public int Sum( int moreThen )
        {
            int sum = 0;
            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    int number = data[i, j];
                    sum += number > moreThen ? number : 0;
                }
            }
            return sum;
        }

        public int Max
        {
            get
            {
                int maxNumber = data[ 0, 0 ];
                for (int i = 0; i < data.GetLength(0); i++)
                {
                    for (int j = 0; j < data.GetLength(1); j++)
                    {
                        int number = data[i, j];

                        maxNumber = maxNumber < number ? number : maxNumber;
                    }
                }
                return maxNumber;
            }
        }

        public int Min
        {
            get
            {
                int minNumber = data[0, 0];
                for (int i = 0; i < data.GetLength(0); i++)
                {
                    for (int j = 0; j < data.GetLength(1); j++)
                    {
                        int number = data[i, j];

                        minNumber = minNumber > number ? number : minNumber;
                    }
                }
                return minNumber;
            }
        }

        public void SetMaxItemsIndex(out string coordsString, string separator = SEPARATOR )
        {
            int maxNumber = data[0, 0];
            string maxNumberCoords = $"0{separator}0";
            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    int number = data[i, j];

                    if ( maxNumber < number )
                    {
                        maxNumberCoords = $"{i}{separator}{j}";
                    }
                }
            }
            coordsString = maxNumberCoords;
        } 

        public void Save( string filePath = FILE_PATH )
        {
            StreamWriter sw = new StreamWriter( filePath );

            for (int i = 0; i < data.GetLength(0); i++)
            {
                string row = "";
                int cellLength = data.GetLength(1);
                for (int j = 0; j < cellLength; j++)
                {
                    string separator = (j != cellLength - 1) ? SEPARATOR : "";
                    row += $"{ data[i, j] }{ separator }";
                }
                sw.WriteLine(row);
            }
            sw.Close();
        }

        public int[,] Load(string filePath = FILE_PATH)
        {
            StreamReader sr = new StreamReader(filePath);

            string tmpRow = "";
            int cellsLength = 0;
            while ( !sr.EndOfStream )
            {
                string row = sr.ReadLine();
                if ( cellsLength == 0 )
                {
                    cellsLength = row.Split(SEPARATOR).Length;
                }
                tmpRow += row + NEW_LINE;
            }

            string[] rowsString = tmpRow.Split( NEW_LINE );

            int rowLenght = rowsString.Length - 1;

            int[,] result = new int[rowLenght, cellsLength ];

            for (int i = 0; i < rowLenght; i++)
            {
                string [] numbers = rowsString[ i ].Split(SEPARATOR);
                for (int j = 0; j < numbers.Length; j++)
                {
                    result[i, j] = int.Parse(numbers[j]);
                }
            }

            sr.Close();
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TwoDimensionsArray arr = new TwoDimensionsArray(3, 3);
   

            Console.WriteLine($"Sum items: {arr.Sum()}");
            Console.WriteLine($"Sum items more then: {arr.Sum(7)}");
            Console.WriteLine($"MinItem: {arr.Min}");
            Console.WriteLine($"MaxItem: {arr.Max}");

            string coordsString;
            arr.SetMaxItemsIndex(out coordsString);

            Console.WriteLine($"Max Item coord: { coordsString }");

            arr.Save();

            TwoDimensionsArray arr2 = new TwoDimensionsArray();

            arr2.Print();
        }
    }
}
