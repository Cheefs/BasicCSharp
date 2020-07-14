using System;
using System.Windows.Forms;


/**
 * Используя Windows Forms, разработать игру «Угадай число». Компьютер загадывает число от 1 до 100,
 * а человек пытается его угадать за минимальное число попыток.
 * Компьютер говорит, больше или меньше загаданное число введенного.  
    a) Для ввода данных от человека используется элемент TextBox;
    б) **Реализовать отдельную форму c TextBox для ввода числа.
 */

namespace Task7_2
{
    public partial class MainForm : Form
    {
        AnswerForm answerForm;
        GuesNumberGame game;

        public delegate void SetAnsewerCallBack(int x);


        public MainForm()
        {
            InitializeComponent();
            game = new GuesNumberGame();
            labelTryCount.Text = game.TryCount.ToString();

            answerForm = new AnswerForm(CallBack);
        }

        public void CallBack(int x)
        {
            string message = game.CheckAnswer(x);

            MessageBox.Show(message, "info");
            labelTryCount.Text = game.TryCount.ToString();

            if ( game.TryCount == 0)
            {
                answerForm.Hide();
            }
        }

        private void BtnEnterAnswer_Click(object sender, EventArgs e)
        {
            answerForm.ShowDialog();
        }
    }
}
