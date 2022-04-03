using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab7Var3
{
    public partial class Task2Form : Form
    {
        public Task2Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        /* Ввод матрицы с клавиатуры */
        private void button2_Click(object sender, EventArgs e)
        {
            KeyboardMatrixInputForm keyboardMatrixInputForm = new KeyboardMatrixInputForm();
            keyboardMatrixInputForm.ShowDialog();

            /* Получение массива из метода создания матрицы с клавиатуры и запись его в файл */
            int[][] matrix = keyboardMatrixInputForm.GetMatrix();

            string matrixToFile = "";

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                matrixToFile += string.Join(", ", matrix[i]);
                matrixToFile += ";";
            }

            using (StreamWriter streamWriter = new StreamWriter(@"..\..\Task2File.txt", false))
            {
                streamWriter.Write(matrixToFile);
            }

            /* Чтение матрицы из файла и вывод его на форму */
            string data = "";

            using (StreamReader streamReader = new StreamReader(@"..\..\Task2File.txt"))
            {
                data = streamReader.ReadLine();
            }

            string[] matrixFromFile = data.Split(';');

            string outputData = "";

            for (int i = 0; i < matrixFromFile.GetLength(0); i++)
            {
                outputData += string.Join(", ", matrixFromFile[i]);
                outputData += "\n";
            }

            label2.Text = outputData;
        }

        /* Создание матрицы с помощью ДСЧ */
        private void button3_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            int sizeCol = random.Next(3, 5);

            int[][] matrix = new int[random.Next(2, 4)][];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                matrix[i] = new int[sizeCol];

                for (int j = 0; j < matrix[i].Length; j++)
                {
                    matrix[i][j] = random.Next(0, 10);
                }
            }

            /* Запись матрицы в файл */
            string matrixToFile = "";

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                matrixToFile += string.Join(", ", matrix[i]);
                matrixToFile += ";";
            }

            using (StreamWriter streamWriter = new StreamWriter(@"..\..\Task2File.txt", false))
            {
                streamWriter.Write(matrixToFile);
            }

            /* Вывод матрицы на форму */
            string matrixToForm = ""; 

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                matrixToForm += string.Join(", ", matrix[i]);
                matrixToForm += "\n";
            }

            label2.Text = matrixToForm;
        }

        /* Добавление строки в конец матрицы  */
        private void button4_Click(object sender, EventArgs e)
        {
            /* Чтение матрицы из файла */
            string dataFromFile = "";

            using (StreamReader stremReader = new StreamReader(@"..\..\Task2File.txt"))
            {
                dataFromFile = stremReader.ReadLine();
            }

            /* Деление строки (матрица в "сыром" виде) на массив строк по ";" */
            string[] matrixAsArray = dataFromFile.Split(new char[] {';'}, StringSplitOptions.RemoveEmptyEntries);

            string[][] matrixFromFile = new string[matrixAsArray.Length][];

            /* Проход по каждой строке и преобразование ее в массив строк (чисел в строковом предствалении) */
            for (int i = 0; i < matrixAsArray.Length; i++)
            {
                string[] tempString = matrixAsArray[i].Split(new char[] {',', ' '}, StringSplitOptions.RemoveEmptyEntries);
                matrixFromFile[i] = new string[tempString.Length]; 

                for (int j = 0; j < tempString.Length; j++)
                {
                    matrixFromFile[i][j] = tempString[j];
                }
            }

            /* Добавление новой строки в конец матрицы */
            string[][] newMatrix = new string[matrixFromFile.GetLength(0) + 1][];

            for (int i = 0; i < matrixFromFile.GetLength(0); i++)
            {
                newMatrix[i] = new string[matrixFromFile[0].Length];

                for (int j = 0; j < matrixFromFile[0].Length; j++)
                {
                    newMatrix[i][j] = matrixFromFile[i][j];
                }
            }

            newMatrix[matrixFromFile.GetLength(0)] = new string[matrixFromFile[0].Length];

            Random random = new Random();

            for (int i = 0; i < newMatrix[0].Length; i++)
            {
                newMatrix[matrixFromFile.GetLength(0)][i] = random.Next(0, 10).ToString();
            }

            /* Запись матрицы в файл */
            string matrixToFile = "";

            for (int i = 0; i < newMatrix.GetLength(0); i++)
            {
                matrixToFile += string.Join(", ", newMatrix[i]);
                matrixToFile += ";";
            }

            using (StreamWriter streamWriter = new StreamWriter(@"..\..\Task2File.txt", false))
            {
                streamWriter.Write(matrixToFile);
            }

            /* Вывод матрицы на форму */
            string matrixToForm = "";

            for (int i = 0; i < newMatrix.GetLength(0); i++)
            {
                matrixToForm += string.Join(", ", newMatrix[i]);
                matrixToForm += "\n";
            }

            label2.Text = matrixToForm;
        }
    }
}
