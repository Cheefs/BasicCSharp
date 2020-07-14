using System;
using System.Windows.Forms;

namespace Task7_2
{
    public partial class AnswerForm : Form
    {
        MainForm.SetAnsewerCallBack setAnsewerCallBack;
        public AnswerForm(MainForm.SetAnsewerCallBack setAnsewerCallBack)
        {
            InitializeComponent();

            this.setAnsewerCallBack = setAnsewerCallBack;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            int answer;
            bool isNumber = int.TryParse(answerText.Text, out answer); 
            if ( !isNumber )
            {
                MessageBox.Show("Enter a number!");
            } else
            {
                setAnsewerCallBack(answer);
            }
        }
    }
}
