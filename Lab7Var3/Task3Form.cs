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
    public partial class Task3Form : Form
    {
        public Task3Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        /* Создание рваного массива с клавиатуры */
        private void button2_Click(object sender, EventArgs e)
        {
            KeyboardMatrixInputForm keyboardMatrixInputForm = new KeyboardMatrixInputForm();
            keyboardMatrixInputForm.ShowDialog();

            /*Получение рваного массива из метода создания матрицы с клавиатуры и запись его в файл */
            int[][] jaggedArr = keyboardMatrixInputForm.GetMatrix();

            string jaggedArrToFile = "";

            for (int i = 0; i < jaggedArr.GetLength(0); i++)
            {
                jaggedArrToFile += string.Join(", ", jaggedArr[i]);
                jaggedArrToFile += ";";
            }

            using (StreamWriter streamWriter = new StreamWriter(@"..\..\Task3File.txt", false))
            {
                streamWriter.Write(jaggedArrToFile);
            }

            /* Чтение рваного массива из файла и вывод его на форму */
            string data = "";

            using (StreamReader streamReader = new StreamReader(@"..\..\Task3File.txt"))
            {
                data = streamReader.ReadLine();
            }

            string[] jaggedArrFromFile = data.Split(';');

            string outputData = "";

            for (int i = 0; i < jaggedArrFromFile.GetLength(0); i++)
            {
                outputData += string.Join(", ", jaggedArrFromFile[i]);
                outputData += "\n";
            }

            label2.Text = outputData;
        }

        /* Создание рваного массива с помощью ДСЧ */
        private void button3_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            int[][] jaggedArr = new int[random.Next(2, 4)][];

            for (int i = 0; i < jaggedArr.GetLength(0); i++)
            {
                jaggedArr[i] = new int[random.Next(3, 5)];

                for (int j = 0; j < jaggedArr[i].Length; j++)
                {
                    jaggedArr[i][j] = random.Next(0, 10);
                }
            }

            /* Запись рваного массива в файл */
            string jaggedArrToFile = "";

            for (int i = 0; i < jaggedArr.GetLength(0); i++)
            {
                jaggedArrToFile += string.Join(", ", jaggedArr[i]);
                jaggedArrToFile += ";";
            }

            using (StreamWriter streamWriter = new StreamWriter(@"..\..\Task3File.txt", false))
            {
                streamWriter.Write(jaggedArrToFile);
            }

            /* Вывод рваного массива на форму */
            string jaggedArrToForm = "";

            for (int i = 0; i < jaggedArr.GetLength(0); i++)
            {
                jaggedArrToForm += string.Join(", ", jaggedArr[i]);
                jaggedArrToForm += "\n";
            }

            label2.Text = jaggedArrToForm;
        }

        /* Удаление строк */
        private void button4_Click(object sender, EventArgs e)
        {
            /* Чтение рваного массива из файла */
            string dataFromFile = "";

            using (StreamReader stremReader = new StreamReader(@"..\..\Task3File.txt"))
            {
                dataFromFile = stremReader.ReadLine();
            }

            /* Деление строки (рваный массив в "сыром" виде) на массив строк по ";" */ 
            string[] jaggedArrAsArray = dataFromFile.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            string[][] jaggedArrFromFile = new string[jaggedArrAsArray.Length][];

            /* Проход по каждой строке и преобразование ее в массив строк (чисел в строковом предствалении) */
            for (int i = 0; i < jaggedArrAsArray.Length; i++)
            {
                string[] tempString = jaggedArrAsArray[i].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                jaggedArrFromFile[i] = new string[tempString.Length];

                for (int j = 0; j < tempString.Length; j++)
                {
                    jaggedArrFromFile[i][j] = tempString[j];
                }
            }

            /* Преобразование элементов их string в int */
            int[][] jaggedArr = new int[jaggedArrFromFile.GetLength(0)][];

            for (int i = 0; i < jaggedArr.GetLength(0); i++)
            {
                jaggedArr[i] = new int[jaggedArrFromFile[i].Length];

                for (int j = 0; j < jaggedArrFromFile[i].Length; j++)
                {
                    jaggedArr[i][j] = int.Parse(jaggedArrFromFile[i][j]);
                }
            }

            /* Удаление всех строк, в которых встречаются нули */
            int[][] temp = new int[jaggedArr.GetLength(0)][];
            int tempIndex = 0;

            for (int i = 0; i < jaggedArr.GetLength(0); i++)
            {
                if (!jaggedArr[i].Contains(0))
                {
                    temp[tempIndex] = jaggedArr[i];
                    tempIndex++;
                }
            }

            int[][] newJaggedArr = new int[tempIndex][];

            for (int i = 0; i < tempIndex; i++)
            {
                newJaggedArr[i] = temp[i];
            }

            /* Преобразавние из int в string для вывода в файл + запись в файл*/
            string newJaggedArrToFile = "";

            for (int i = 0; i < newJaggedArr.GetLength(0); i++)
            {
                newJaggedArrToFile += string.Join(", ", newJaggedArr[i]);
                newJaggedArrToFile += ";";
            }

            using (StreamWriter streamWriter = new StreamWriter(@"..\..\Task3File.txt", false))
            {
                streamWriter.Write(newJaggedArrToFile);
            }

            /* Преобразование из int в string для вывода на форму + вывод на форму */
            string newJaggedArrToForm = "";

            for (int i = 0; i < newJaggedArr.GetLength(0); i++)
            {
                newJaggedArrToForm += string.Join(", ", newJaggedArr[i]);
                newJaggedArrToForm += "\n";
            }

            label2.Text = newJaggedArrToForm;
        }
    }
}
