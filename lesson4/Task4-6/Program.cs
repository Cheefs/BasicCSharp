using System;
using System.IO;

/**
 * 6. ***Написать игру “Верю. Не верю”.
 *      В файле хранятся некоторые данные и правда это или нет. Например: “Шариковую ручку изобрели в древнем Египте”, “Да”.
 *      
        Компьютер загружает эти данные, случайным образом выбирает 5 вопросов и задает их игроку.
        Игрок пытается ответить правда или нет, то что ему загадали и набирает баллы. Список вопросов ищите во вложении или можно воспользоваться Интернетом.
 */

namespace Task4_6
{

    class TrueOrFalse
    {
        const int MAX_QUESTIONS = 5;
        const string FILE_PATH = "./questions.txt";
        const string QUESTION_AND_ANSVER_DEVIDER = ";";

        string[] gameConamds = { "y", "n" };
        string[,] questions = new string[MAX_QUESTIONS, 2];
        int[] questionsInGame = new int[ MAX_QUESTIONS ];
        string[] buffer;

        public int ActiveQuestion { get; private set; } = 0;
        public int Score { get; private set; } = 0;


        public TrueOrFalse()
        {
            Load();
        }

        void Load()
        {
            if (File.Exists(FILE_PATH))
            {
                buffer = File.ReadAllLines(FILE_PATH);
                PrepareQuestions();
            }
            else
            {
                Console.WriteLine($"Error File { FILE_PATH } not found in bin directory");
            }
        }

        void PrepareQuestions()
        {
            for ( int i = 0; i < questions.GetLength(0); i++ )
            {
                string[] question = GetRandomQuestion( i );
                questions[i, 0] = question[0];
                questions[i, 1] = question[1];
            }
        }

        string[] GetRandomQuestion( int index )
        {
            Random rnd = new Random();

            int randomIndex = rnd.Next(0, buffer.Length);
            
            if ( Array.IndexOf( questionsInGame, randomIndex) != -1 )
            {
                return GetRandomQuestion( index );
            }

            questionsInGame[index] = randomIndex;

            return buffer[ randomIndex ].Split( QUESTION_AND_ANSVER_DEVIDER );
        }

        public bool IsGameActive()
        {
            return ActiveQuestion < MAX_QUESTIONS;
        }

        public string GeQuestion()
        {
            return questions[ActiveQuestion, 0];
        }

        public bool IsGameCommand( string command )
        {
            return ( Array.IndexOf(gameConamds, command) != -1 );
        }

        public string ChaeckAnswer(string answer)
        {
            string questionAnwer = questions[ActiveQuestion, 1];
            ActiveQuestion++;
            if (answer == questionAnwer)
            {
                Score += 1;
                return "Correkt!";
            }
            return "Incorrect";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TrueOrFalse game = new TrueOrFalse();
            Console.WriteLine("Enter \"y\" if True or \"n\" if false");

            while ( game.IsGameActive() )
            {
                Console.WriteLine( game.GeQuestion() );
                Console.Write("Your answer: ");
                string command = Console.ReadLine().Trim();

                if ( !game.IsGameCommand(command) )
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine( "is Not game command! Try Again!" );
                    Console.ForegroundColor = ConsoleColor.White;

                    continue;
                }
                game.ChaeckAnswer(command);
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine( $"Your score is: {game.Score}" );
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
