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
    public partial class Task1Form : Form
    {
        public Task1Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        /* Создание массива с клавиатуры */
        private void button2_Click(object sender, EventArgs e) 
        {
            KeyboardArrayInputForm keyboardArrayInputForm = new KeyboardArrayInputForm();
            keyboardArrayInputForm.ShowDialog();

            /* Получение массива из метода создания массива с клавиатуры и запись его в файл */
            int[] array = keyboardArrayInputForm.GetArr();
            string str = string.Join(", ", array);

            using (StreamWriter streamWriter = new StreamWriter(@"..\..\Task1File.txt", false))
            {
                streamWriter.WriteLine(str);
            }

            /* Чтение массива из файла и вывод его на форму*/
            string data = "";

            using (StreamReader streamReader = new StreamReader(@"..\..\Task1File.txt"))
            {
                data = streamReader.ReadLine();
            }

            label2.Text = data;
        }

        /* Создание массива через ДСЧ */
        private void button3_Click(object sender, EventArgs e)
        {
            RandomArrayInputForm randomArrayInputForm = new RandomArrayInputForm();
            randomArrayInputForm.ShowDialog();

            /* Создание массива через ДСЧ и запись его в файл */ 
            int arraySize = randomArrayInputForm.GetLength();
            string str = Task1Form.CreateArray(arraySize);

            using (StreamWriter streamWriter = new StreamWriter(@"..\..\Task1File.txt", false))
            {
                streamWriter.WriteLine(str);
            }

            /* Чтение массива из файла и вывод его на форму */
            string data = "";

            using (StreamReader streamReader = new StreamReader(@"..\..\Task1File.txt"))
            {
                data = streamReader.ReadLine();
            }

            label2.Text = data;
        }

        /* Удаление элемента из массива */
        private void button4_Click(object sender, EventArgs e)
        {
            DeleteFromArrayForm deleteFromArrayForm = new DeleteFromArrayForm();
            deleteFromArrayForm.ShowDialog();

            int key = deleteFromArrayForm.GetKey();  // Чтение ключа на удаление

            /* Чтение массива из файла */
            string data = "";

            using (StreamReader streamReader = new StreamReader(@"..\..\Task1File.txt"))
            {
                data = streamReader.ReadLine();
            }

            string[] stringArray = data.Split(new char[] {','}, StringSplitOptions.RemoveEmptyEntries);
           
            List<int> list = new List<int>();

            /* Конвертирование элементов из string в int для дальнейшей работы + удаление элеметна */
            bool isDeleted = false;

            for (int i = 0; i < stringArray.Length; i++)
            {
                int tmp = Convert.ToInt32(stringArray[i]);

                if (tmp == key)
                {
                    isDeleted = true;
                    continue;
                }

                list.Add(Convert.ToInt32(stringArray[i]));
            }

            if (!isDeleted)
            {
                MessageBox.Show("Элемента нет в массиве!");
            }

            /* Запись массива в файл */
            using (StreamWriter streamWriter = new StreamWriter(@"..\..\Task1File.txt", false))
            {
                streamWriter.WriteLine(string.Join(", ", list));
            }

            label2.Text = string.Join(", ", list);
        }

        /* Создание массива с помощью ДСЧ */
        private static string CreateArray(int size)
        {
            Random rnd = new Random();

            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = rnd.Next(-10, 10);
            }

            return string.Join(", ", array);
        }
    }
}
