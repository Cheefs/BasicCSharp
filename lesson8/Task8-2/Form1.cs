using System;
using System.Windows.Forms;


/**
 * Создайте простую форму на котором свяжите свойство Text элемента TextBox со свойством Value элемента NumericUpDown
 */

namespace Task8_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numberInput_ValueChanged(object sender, EventArgs e)
        {
            textBoxValue.Text = numberInput.Value.ToString();
        }
    }
}
