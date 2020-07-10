using System;
using System.IO;

/**
 *  На вход программе подаются сведения о сдаче экзаменов учениками 9-х классов некоторой средней школы. 
 *  
    В первой строке сообщается количество учеников N, которое не меньше 10, но не превосходит 100,
        каждая из следующих N строк имеет следующий формат: <Фамилия> <Имя> <оценки>,
    где <Фамилия> — строка, состоящая не более чем из 20 символов,
        <Имя> — строка, состоящая не более чем из 15 символов,
        <оценки> — через пробел три целых числа, соответствующие оценкам по пятибалльной системе.
    <Фамилия> и <Имя>, а также <Имя> и <оценки> разделены одним пробелом.

    Пример входной строки:
    Иванов Петр 4 5 3
    Требуется написать как можно более эффективную программу, которая будет выводить на экран
    фамилии и имена трёх худших по среднему баллу учеников. Если среди остальных есть ученики,
    набравшие тот же средний балл, что и один из трёх худших, то следует вывести и их фамилии и
    имена.

 */

namespace Task5_4
{
    class Student
    {
        const int FIRSTNAME_MAX_LENGHT = 15;
        const int LASTNAME_MAX_LENGHT = 20;

        string firstName;
        string lastName;

        int[] marks;

        public Student(string firstName, string lastName, int[] marks )
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.marks = marks;
        }

        public int MiddleMark()
        {
            int result = 0;
         
            foreach ( int mark in marks )
            {
                result += mark;
            }
            return result/marks.Length;
        }
        public string FullName()
        {
            return $"{ firstName } { lastName }";
        }

        static bool ValidataFirstaName( string firstname )
        {
            return firstname.Length > 0 && firstname.Length <= FIRSTNAME_MAX_LENGHT;
        }

        static bool ValidataLastName(string lastname)
        {
            return lastname.Length > 0 && lastname.Length <= LASTNAME_MAX_LENGHT;
        }

        public static void Validate(string firstname, string lastname)
        {
            if (!ValidataFirstaName(firstname))
            {
                throw new Exception($"firstname must be more then 0 and less then { FIRSTNAME_MAX_LENGHT } symbols!");
            }

            if (!ValidataLastName(lastname))
            {
                throw new Exception($"lastname must be more then 0 and less then { LASTNAME_MAX_LENGHT } symbols!");
            }
        }
    }

    class FileParser
    {
        static Student[] students;

        public static Student[] Students { get => students; set => students = value; }

        public static bool Load( string fileName )
        {
            if ( !File.Exists( fileName ) )
            {
                return false;
            }

            StreamReader sr = new StreamReader(fileName);
            int rowsCount = -1;
            int index = 0;

            while ( !sr.EndOfStream )
            {
                if(rowsCount == -1 )
                {
                    rowsCount = int.Parse(sr.ReadLine());
                    students = new Student[ rowsCount ];
                }

                students[index++] = ParseStudentData( sr.ReadLine() );
            }
            return students.Length > 0;
        }

        static Student ParseStudentData( string data )
        {
            string[] dataParts = data.Split(" ");
            string firstName = dataParts[0];
            string lastName = dataParts[1];

            Student.Validate(firstName, lastName);

            int marksLength = dataParts.Length - 2;

            int[] marks = new int[marksLength];
            for( int i = 2; i < dataParts.Length; i++ )
            {
                int currentIndex = (i - 2);
                marks[currentIndex] = int.Parse(dataParts[i]);
            }

            Student student = new Student(firstName, lastName, marks);

            return student;
        }
    }

    class Program
    {
        const int MAX_COUNT = 3;
        const string FILE_PATH = "students.txt";
        static void Main()
        {
            try
            {
                if (FileParser.Load(FILE_PATH))
                {
                    ShowStudentsStatistics();
                }
                else
                {
                    Console.WriteLine($"File not found in: '{ FILE_PATH }'");
                }
            } 
            catch( Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine( ex.Message );
                Console.ForegroundColor = ConsoleColor.White;
            }
        
        }
        static void ShowStudentsStatistics()
        {
            Student[] studentsList = FileParser.Students;

            int minMarksCount = 0;
            for (int i = 0; i < 5; i++)
            {

                if (minMarksCount == MAX_COUNT)
                {
                    break;
                }

                string studentsFio = "";
                foreach (Student el in FileParser.Students)
                {
                    if (el.MiddleMark() == i)
                    {
                        studentsFio += el.FullName() + ", ";
                    }
                }

                if (studentsFio.Length > 0)
                {
                    Console.WriteLine($"{ i }: { studentsFio }");
                    minMarksCount++;
                }
                else
                {
                    continue;
                }
            }
        }
    }
}
