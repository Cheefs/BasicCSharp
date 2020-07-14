using System;

namespace Task7_2
{
    public class GuesNumberGame
    {
        const int MIN = 1;
        const int MAX = 2;

        int secretNumber;
        int tryCount = 0;

        public int TryCount { get => tryCount; }

        public GuesNumberGame()
        {
            SetSecretNumber();
        }

        void SetSecretNumber()
        {
            Random rnd = new Random();
            secretNumber = rnd.Next( MIN, MAX );
        }

        public string CheckAnswer( int number )
        {
            tryCount++;
            int comare = number.CompareTo(secretNumber);

            if ( comare == 0 )
            {
                Restart();
                return "You Win\n Game is Restarted!";
            }
            else if ( comare == 1 )
            {
                return "Your number to big !";
            } 
            else
            {
                return "Your number to small !";
            }
        }

        void Restart()
        {
            SetSecretNumber();
            tryCount = 0;
        }
    }
}
