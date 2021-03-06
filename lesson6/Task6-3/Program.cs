﻿using System;
using System.IO;
using System.Collections.Generic;

/**
 * Переделать программу Пример использования коллекций для решения следующих задач:
    а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
    б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся (*частотный массив);
    в) отсортировать список по возрасту студента;
    г) *отсортировать список по курсу и возрасту студента;
 */

namespace Task6_3
{

    class Student
    {
        public string lastName;
        public string firstName;
        public string university;
        public string faculty;
        public int course;
        public string department;
        public int group;
        public string city;
        public int age;
        // Создаем конструктор
        public Student(string firstName, string lastName, string university, string faculty, string department, int age, int course, int group, string city)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.university = university;
            this.faculty = faculty;
            this.department = department;
            this.course = course;
            this.age = age;
            this.group = group;
            this.city = city;
        }
    }
    class Program
    {
        const string FILE_NAME = "students_1.csv";

        static int MyDelegat(Student st1, Student st2)
        {
            return String.Compare(st1.firstName, st2.firstName);
        }

        static int SortByAge(Student st1, Student st2)
        {
            return st1.age.CompareTo(st2.age);
        }

        static int SortByAgeAndCourse(Student st1, Student st2)
        {
            int result = st1.course.CompareTo(st2.course);
            if (result == 0)
            {
                result = st1.age.CompareTo(st2.age);
            }
            return result;
        }

        static void Main(string[] args)
        {
            int bakalavr = 0;
            int magistr = 0;

            int countStudentsInFifthAndSixCourse = 0;

            List<Student> list = new List<Student>();                             // Создаем список студентов
            DateTime dt = DateTime.Now;
            StreamReader sr = new StreamReader(FILE_NAME);


            int[] studentsCourseStatistics = new int[ 7 ];

            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';');
                    // Добавляем в список новый экземпляр класса Student
                    Student student = new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]), int.Parse(s[7]), s[8]);
                    list.Add(student);
                    // Одновременно подсчитываем количество бакалавров и магистров
                    if (student.course < 5)
                    {
                        bakalavr++;
                    }
                    else
                    {
                        magistr++;
                    }


                    if ( student.age > 17 && student.age < 21 )
                    {
                        studentsCourseStatistics[student.course]++;
                    }
                    
                    countStudentsInFifthAndSixCourse += (student.course >= 5) ? 1 : 0;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Ошибка!ESC - прекратить выполнение программы");
                    // Выход из Main
                    if (Console.ReadKey().Key == ConsoleKey.Escape) return;
                }
            }
            sr.Close();
            list.Sort(new Comparison<Student>(MyDelegat));
            Console.WriteLine("Всего студентов:" + list.Count);
            Console.WriteLine("Магистров:{0}", magistr);
            Console.WriteLine("Бакалавров:{0}", bakalavr);
            // foreach (var v in list) Console.WriteLine(v.firstName);

            Console.WriteLine($"Count students in 5 and 6 course: { countStudentsInFifthAndSixCourse }");

            list.Sort(new Comparison<Student>(SortByAge));

            list.Sort(new Comparison<Student>(SortByAgeAndCourse));

            foreach (Student student in list)
            {
                Console.WriteLine($"{student.course } {student.age}");
            }

            for ( int i = 1; i < studentsCourseStatistics.Length; i++ )
            {
                Console.WriteLine($"course{ i }, count: { studentsCourseStatistics[i]} ");
            }

            Console.WriteLine(DateTime.Now - dt);
            Console.ReadKey();
        }
    }
}
