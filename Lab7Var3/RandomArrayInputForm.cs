using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7Var3
{
    public partial class RandomArrayInputForm : Form
    {
        private int length;

        public int GetLength()
        {
            return length;
        }

        public RandomArrayInputForm()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            bool isValidInput = int.TryParse(textBox1.Text, out length);

            if (!isValidInput)
            {
                MessageBox.Show("Вы ввели некорректные данные!");
            }
            else if (length <= 0)
            {
                MessageBox.Show("Размер массива не должен иметь отрицательную или нулевую длину!");
            }
            else
            {
                Close();
            }
        }
    }
}
