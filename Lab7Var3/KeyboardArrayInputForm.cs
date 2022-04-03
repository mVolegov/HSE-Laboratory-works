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
    public partial class KeyboardArrayInputForm : Form
    {
        private int[] arr;

        public int[] GetArr()
        {
            return arr;
        }

        public KeyboardArrayInputForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isValidInput = false;

            string input = textBox1.Text;

            string[] inputArray = input.Split(new char[] {' ', ',', ';'}, StringSplitOptions.RemoveEmptyEntries);

            arr = new int[inputArray.Length];

            int a_;

            for (int i = 0; i < inputArray.Length; i++)
            {
                isValidInput = int.TryParse(inputArray[i], out a_);
                
                if (!isValidInput)
                {
                    MessageBox.Show("Вы ввели некорретные данные!");
                    break;
                }
                else
                {
                    arr[i] = a_;
                }
            }

            if (isValidInput) Close();
        }
    }
}
