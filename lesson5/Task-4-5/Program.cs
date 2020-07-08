using System;
using System.Linq;

/**
 * 5. **Существует алгоритмическая игра “Удвоитель”.
 * В этой игре человеку предлагается какое-то число, а человек должен, управляя роботом “Удвоитель”, достичь этого числа за минимальное число шагов.
 * Робот умеет выполнять несколько команд: увеличить число на 1, умножить число на 2 и сбросить число до 1. Начальное значение удвоителя равно 1.
 *  
 *  Реализовать класс “Удвоитель”. Класс хранит в себе поле current - текущее значение, finish - число, которого нужно достичь,
 *   1) конструктор, в котором задается конечное число.
 *   2) Методы: увеличить число на 1, увеличить число в два раза, сброс текущего до 1,
 *   3) свойство Current, которое возвращает текущее значение,
 *   4) свойство Finish, которое возвращает конечное значение.
 *   
 *   Создать с помощью этого класса игру, в которой компьютер загадывает число,
 *   а человек. выбирая из меню на экране, отдает команды удвоителю и старается получить это число за наименьшее число ходов.
 *   Если человек получает число больше положенного, игра прекращается.
 */

namespace Task_4_5
{
    class Doubler
    {
        const int START_POSITION = 1;
        const int INCREASE_STEP = 2;
        const int ADD_STEP = 1;

        enum Commands { Add = 1, Increase, Reset };
        Commands[] commandsList = { Commands.Add, Commands.Increase, Commands.Reset };

        int current;
        int finish;

        bool gameBegin;

        public int Current { get; }
        public int Finish { get; }
        public bool GameBegin {
            get { return gameBegin; }
        }

        public Doubler( int finish )
        {
            this.finish = finish;
            current = START_POSITION;
            gameBegin = true;
        }

        void CheckSatus()
        {
            if (current > finish)
            {
              
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\tGame Ower! - Overflov");
                Console.ForegroundColor = ConsoleColor.White;
                gameBegin = false;
            } 
            else if ( current == finish)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\tYou Win!");
                Console.ForegroundColor = ConsoleColor.White;
                gameBegin = false;
            }
        }

        public void Add()
        {
            current += ADD_STEP;
        }

        public void Increase()
        {
            current *= INCREASE_STEP;
        }

        public void DropToStart()
        {
            current = START_POSITION;
        }

        public void PrintRules()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("\tRules");
            Console.WriteLine($"1. Press { Commands.Add } to add { ADD_STEP } point to your number");
            Console.WriteLine($"2. Press { Commands.Increase  } to increase { INCREASE_STEP } point to your number");
            Console.WriteLine($"3. Press { Commands.Reset } to reset point to: { START_POSITION }");
            Console.WriteLine($"5. To win you need get: { finish }");
            Console.WriteLine($"6. If you get overflow, -> game over");

            Console.ForegroundColor = ConsoleColor.White;
        }

        public void SwitchCommand( int command )
        {
            switch ( (Commands)command )
            {
                case Commands.Add:
                {
                    Add();
                    break;
                }
                case Commands.Increase:
                {
                    Increase();
                    break;
                }
                case Commands.Reset:
                {
                    DropToStart();
                    break;
                }
            }

            PrintStatus();

            CheckSatus();
        }

        void PrintStatus()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"\tCurrent: { current }");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public bool CheckCommand( int command )
        {

            bool contains = false;

            foreach ( int index in commandsList )
            {
                if ( index != command )
                {
                    continue;
                }
                contains = true;
            }

            return contains;
        }
    }

    class Game
    {
        static void Main()
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 100);

            Doubler game = new Doubler( randomNumber );

            game.PrintRules();

            while (game.GameBegin)
            {
                int command;
                Console.Write("Enter command: ");
                bool isNumber = int.TryParse(Console.ReadLine(), out command);

                if ( !isNumber || !game.CheckCommand( command ) )
                {
                    Console.WriteLine("Incorrect command!");
                    continue;
                }

                game.SwitchCommand(command);
            }
        }
    }
}
