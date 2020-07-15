using System;
using System.Drawing;
using System.Windows.Forms;

/**
 *  а) Создать приложение, показанное на уроке, добавив в него защиту от возможных ошибок (не создана база данных, обращение к несуществующему вопросу, открытие слишком большого файла и т.д.).
    б) Изменить интерфейс программы, увеличив шрифт, поменяв цвет элементов и добавив другие «косметические» улучшения на свое усмотрение.
    в) Добавить в приложение меню «О программе» с информацией о программе (автор, версия, авторские права и др.).
    г)* Добавить пункт меню Save As, в котором можно выбрать имя для сохранения базы данных (элемент SaveFileDialog).
 */

namespace Task8_3
{
    public partial class Form1 : Form
    {
        DataBase db;
        string filename;
        int activeQuestionIndex = 0;
        int score = 0;

        public Form1()
        {
            InitializeComponent();
            db = new DataBase();

            btnSelectTrue.Visible = false;
            btnSelectFalse.Visible = false;
        }

        #region game

        private void BtnStartGame_Click(object sender, EventArgs e)
        {
            if ( filename == null )
            {
                MessageBox.Show("Load Questions before Play!");
                return;
            }
            SwapScreens();
            gameQuestionText.Text = db[activeQuestionIndex].Text;

        }

        private void BtnSelectTrue_Click(object sender, EventArgs e)
        {
            CheckAnswer(true);
        }

        private void BtnSelectFalse_Click(object sender, EventArgs e)
        {
            CheckAnswer(false);
        }

        private void CheckAnswer(bool answer)
        {
            bool isCorrect = db[activeQuestionIndex].TrueFalse  == answer;

            if (isCorrect)
            {
                score++;
                correctAnswersCount.Text = score.ToString();
            }

            answerCheck.Text = isCorrect.ToString();
            answerCheck.ForeColor = isCorrect ? Color.Green : Color.Red;

            NextQuestion();
        }

        private void NextQuestion()
        {
            ++activeQuestionIndex;

            if(activeQuestionIndex < db.Count)
            {
                gameQuestionText.Text = db[activeQuestionIndex].Text;
                return;
            }

            gameQuestionText.Text = $"Game Ower!\n Your score is { score }/{ db.Count }\n Press Start to restart game";
  
            SwapScreens();
        }

        private void SwapScreens()
        {
            btnStartGame.Visible = !btnStartGame.Visible;
            btnSelectTrue.Visible = !btnSelectTrue.Visible;
            btnSelectFalse.Visible = !btnSelectFalse.Visible;

            answerCheck.Text = String.Empty;
            correctAnswersCount.Text = "0";
            activeQuestionIndex = 0;
        }

        #endregion

        #region questionsEditor

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string text = questionText.Text;
            bool answer = btnTrueOrFalse.Checked;

            if ( text.Trim() == String.Empty )
            {
                MessageBox.Show("Question cant be Empty", "Warning");
                return;
            }

            db.Add(text, answer);
            Clear();

            MessageBox.Show("New Question add Succesful", "Success");
        }

        private void QuestionIndex_ValueChanged(object sender, EventArgs e)
        {
            if (db.Count == 0)
            {
                questionText.Text = String.Empty;
                return;
            }

            int maxIndex = db.Count - 1;
            int selectedIndex = (int)questionIndex.Value;

            Question question = (selectedIndex <= maxIndex) ? db[selectedIndex] : new Question();
            questionText.Text = question.Text;
            btnTrueOrFalse.Checked = question.TrueFalse;
        }

        private void DtnDelete_Click(object sender, EventArgs e)
        {
            int selectedIndex = (int)questionIndex.Value;
            bool canDelete = selectedIndex <= db.Count - 1;

            if ( canDelete )
            {
                db.Remove(selectedIndex);
                Clear();

                MessageBox.Show("Deleted Succesful", "Success");
            }
        }

        private void BtnTrueOrFalse_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = btnTrueOrFalse.Checked;
            btnTrueOrFalse.ForeColor = isChecked ? Color.Green : Color.Red;
            btnTrueOrFalse.Text = isChecked.ToString();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if ( filename.Trim() != String.Empty )
            {
                db.Save(filename);
            }
            else
            {
                SaveFile();
            }

        }

        private void SaveAs_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            int selectedIndex = (int)questionIndex.Value;

            bool canUpdate = selectedIndex <= db.Count - 1;

            if (canUpdate)
            {
                db[selectedIndex].Text = questionText.Text;
                db[selectedIndex].TrueFalse = btnTrueOrFalse.Checked;

                MessageBox.Show("Updated Succesful", "Success");
            }
        }
        private void about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("True Or False Game\n Created by noob Cheef", "About");
        }

        private void SaveFile()
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.DefaultExt = "xml";
            dialog.Filter = "XML файл|*.xml|Все файлы|*.*";

            DialogResult res = dialog.ShowDialog();

            if (res == DialogResult.OK)
            {
                db.Save(dialog.FileName);
                MessageBox.Show("Saved", "Success");
            }
        }

        private void Clear()
        {
            questionIndex.Value = (decimal)db.Count;
            questionText.Text = String.Empty;
            questionsCount.Text = db.Count.ToString();
        }

        private void LoadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            DialogResult res = dialog.ShowDialog();

            if ( res == DialogResult.OK )
            {
                filename = dialog.FileName;

                loadedFilename.Text = filename;

                db.Load(filename);
                questionsCount.Text = db.Count.ToString();
            }
        }
        #endregion

    }
}
