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
    public partial class KeyboardMatrixInputForm : Form
    {
        private int[][] matrix;

        public int[][] GetMatrix()
        {
            return matrix;
        }

        public KeyboardMatrixInputForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isValidInput = false;

            string input = textBox1.Text;

            string[] stringArray = input.Split(new char[] {';'}, StringSplitOptions.RemoveEmptyEntries);
            string[][] matrixTemp = new string[stringArray.Length][];

            int sizeCol = 0;

            for (int i = 0; i < stringArray.Length; i++)
            {
                matrixTemp[i] = stringArray[i].Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                sizeCol++;
            }

            int _a;

            matrix = new int[matrixTemp.Length][];

            for (int i = 0; i < matrixTemp.Length; i++)
            {
                matrix[i] = new int[matrixTemp[i].Length];

                for (int j = 0; j < matrixTemp[i].Length; j++)
                {
                    isValidInput = int.TryParse(matrixTemp[i][j], out _a);

                    if (!isValidInput)
                    {
                        MessageBox.Show("Вы ввели некорретные данные!");
                        break;
                    }
                    else
                    {
                        matrix[i][j] = _a;
                    }
                }
            }

            if (isValidInput) Close();
        }
    }
}
