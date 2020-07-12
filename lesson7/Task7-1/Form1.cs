using System;
using System.Collections;
using System.Windows.Forms;


/**
 * а) Добавить в программу «Удвоитель» подсчёт количества отданных команд удвоителю.
  б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число должен получить игрок. Игрок должен получить это число за минимальное количество ходов.
  в) *Добавить кнопку «Отменить», которая отменяет последние ходы. Используйте обобщенный класс Stack.
        Вся логика игры должна быть реализована в классе с удвоителем.
 */

namespace Task7_1
{
    public partial class Form1 : Form
    {
       
        Doubler doublerGame;

        public Form1()
        {
            InitializeComponent();
            doublerGame = new Doubler();

            GameStart();
        }

        private void GameStart()
        {
            doublerGame.Start();
       
            labelCurrentValue.Text = doublerGame.Current.ToString();
            goalValue.Text = doublerGame.Finish.ToString();
            perfectCount.Text = doublerGame.GetPerfectCount().ToString();
            commandsCount.Text = doublerGame.ActionsCount.ToString();
        }

        private void BtnNewGame_Click(object sender, EventArgs e)
        {
            GameStart();
            MessageBox.Show( $"you need get { doublerGame.Finish }", "Info" );
        }

        private void BtnAddOne_Click(object sender, EventArgs e)
        {
            int newValue = doublerGame.Add();
            Update(newValue);
        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            int value = doublerGame.Increase();
            Update(value);
        }

        private void BtnDropToStart_Click(object sender, EventArgs e)
        {
            int value = doublerGame.DropToStart();
            Update(value);
        }

        private void BtnPrev_Click(object sender, EventArgs e)
        {
            if (doublerGame.ActionsCount > 0)
            {
                string value = doublerGame.StepBack().ToString();
                doublerGame.Current = int.Parse(value);

                labelCurrentValue.Text = value.ToString();
                commandsCount.Text = doublerGame.ActionsCount.ToString();
            }
        }

        private void Update(int newValue)
        {
            labelCurrentValue.Text = newValue.ToString();
            commandsCount.Text = doublerGame.ActionsCount.ToString();
            CheckStatus();
        }

        private void CheckStatus()
        {
            if (doublerGame.End)
            {
                MessageBox.Show( doublerGame.GetResults(), "Info");
                GameStart();
            }
        }
    }
}
