using System;
using System.IO;

/**
 *  **Модифицировать задачу “Сложную задачу” ЕГЭ так, чтобы она решала задачу с 10 000 000 элементов менее чем за минуту.
 */

namespace Task_6_4
{
    class Program
    {
        static void Save(string fileName, int n)
        {
            Random rnd = new Random();
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            for (int i = 1; i < n; i++)
            {
                bw.Write(rnd.Next(0, 100000));      // int занимает 4 байта
            }
            fs.Close();
            bw.Close();
        }
        static void Load(string fileName)
        {
            int max = 0;

            DateTime d = DateTime.Now;
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            int[] a = new int[fs.Length / 4];
            for (int i = 0; i < fs.Length / 4; i++)    // int занимает 4 байта
            {
                a[i] = br.ReadInt32();

                for (int j = 0; j < a.Length; j++)
                    if (Math.Abs(i - j) >= 8 && (long)(a[i] * a[j]) > max)
                    {
                        max = a[i] * a[j];
                    }

            }
            br.Close();
            fs.Close();
            //int max = 0;
            //for (int i = 0; i < a.Length; i++)
            //    for (int j = 0; j < a.Length; j++)
            //        if ( Math.Abs(i - j) >= 8 && (long)(a[i] * a[j]) > max )
            //        {
            //            max = a[i] * a[j];
            //        }
                           
            Console.WriteLine(max);
            Console.WriteLine(DateTime.Now - d);
        }
        static void Main(string[] args)
        {
            //Save("data.bin", 100000);
            Load("data.bin");
            Console.ReadKey();
        }
    }

}
