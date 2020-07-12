
using System;
using System.Collections;

namespace Task7_1
{
    class Doubler
    {
        const int START_POSITION = 1;
        const int INCREASE_STEP = 2;
        const int ADD_STEP = 1;

        int current;
        int finish;
        bool end;

        Stack history;

        public int Finish { get => finish; }
        public int Current { get => current; set => current = value; }
        public bool End { get => end; }
        public int ActionsCount { get => history.Count; }

        public Doubler()
        {
            history = new Stack();

            Start();
            current = START_POSITION;
        }

        int SetRandomNumber()
        {
            Random rnd = new Random();
            return rnd.Next(3, 100);
        }

        public void Start()
        {
            this.finish = SetRandomNumber();
            current = 1;
            history.Clear();
        } 

        public int Add()
        {
            history.Push(current);
            current += ADD_STEP;
            CheckStatus();
            return current;
        }

        public int Increase()
        {
            history.Push(current);
            current *= INCREASE_STEP;
            CheckStatus();
            return current;
        }

        public int DropToStart()
        {
            current = START_POSITION;
            history.Clear();
            return current;
        }

        public Object StepBack()
        {
            return history.Pop();
        }

        private void CheckStatus()
        {
            end = ( current > finish || current == finish );
        }

        public int GetPerfectCount()
        {
            int finishValue = finish;
            int comandsCount = 0;
        
            while( finishValue > 1 )
            {
                comandsCount++;
                if (finishValue % INCREASE_STEP == 0)
                {
                    finishValue /= INCREASE_STEP;
                }
                else
                {
                    finishValue -= ADD_STEP;
                }
            }
            return comandsCount;
        }

        public string GetResults()
        {
            return (current > finish) ? "You lose" : "You Win";
        }
    }
}
