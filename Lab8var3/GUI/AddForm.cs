using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Lab8var3.Model;
using Lab8var3.Service;

namespace Lab8var3.GUI
{
    public partial class AddForm : Form
    {
        private int group;
        
        /* списки студентов для каждой группы */
        private List<Student> studentsGroup1;
        private List<Student> studentsGroup2;
        private List<Student> studentsGroup3;
        
        public AddForm(List<Student> students1, List<Student> students2, List<Student> students3)
        {
            /* Внедрение списков студентов */
            studentsGroup1 = students1;
            studentsGroup2 = students2;
            studentsGroup3 = students3;
            
            InitializeComponent();
            
            button1.Enabled = false;
            radioButton1.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* Считывание данных с формы */
            string name = textBox2.Text;
            string surname = textBox3.Text;
            group = int.Parse(numericUpDown2.Text);
            
            Student studentToAdd = new Student(
                Helper.FindOldMaxId(studentsGroup1, studentsGroup2, studentsGroup3) + 1, name, surname, group);

            if (radioButton1.Checked) /* Запись в начало файла */
            {
                if (group == 1)
                {
                    /* Сериализация в файл с 1 группой */
                    studentsGroup1.Insert(0, studentToAdd);
                    Helper.Serialize(studentsGroup1, @"..\..\Database\Group1.bin");
                }
                else if (group == 2)
                {
                    /* Сериализация в файл с 2 группой */
                    studentsGroup2.Insert(0, studentToAdd);
                    Helper.Serialize(studentsGroup2, @"..\..\Database\Group2.bin");
                }
                else if (group == 3)
                {
                    /* Сериализация в файл с 3 группой */
                    studentsGroup3.Insert(0, studentToAdd);
                    Helper.Serialize(studentsGroup3, @"..\..\Database\Group3.bin");
                }
            }

            if (radioButton2.Checked) /* Запись в конец файла */
            {
                if (group == 1)
                {
                    /* Сериализация в файл с 1 группой */
                    studentsGroup1.Add(studentToAdd);
                    Helper.Serialize(studentsGroup1, @"..\..\Database\Group1.bin");
                }
                else if (group == 2)
                {
                    /* Сериализация в файл с 2 группой */
                    studentsGroup2.Add(studentToAdd);
                    Helper.Serialize(studentsGroup2, @"..\..\Database\Group2.bin");
                }
                else if (group == 3)
                {
                    /* Сериализация в файл с 3 группой */
                    studentsGroup3.Add(studentToAdd);
                    Helper.Serialize(studentsGroup3, @"..\..\Database\Group3.bin");
                }
            }

            if (radioButton3.Checked) /* Запись в место с заданным номером */
            {
                int index = int.Parse(numericUpDown1.Text);

                if (group == 1 && studentsGroup1.Count > index)
                {
                    /* Сериализация в файл с 1 группой */
                    studentsGroup1.Insert(index, studentToAdd);
                    Helper.Serialize(studentsGroup1, @"..\..\Database\Group1.bin");
                }
                else if (group == 2 && studentsGroup2.Count > index)
                {
                    /* Сериализация в файл с 2 группой */
                    studentsGroup2.Insert(index, studentToAdd);
                    Helper.Serialize(studentsGroup2, @"..\..\Database\Group2.bin");
                }
                else if (group == 3 && studentsGroup3.Count > index)
                {
                    /* Сериализация в файл с 3 группой */
                    studentsGroup3.Insert(index, studentToAdd);
                    Helper.Serialize(studentsGroup3, @"..\..\Database\Group3.bin");
                }
                else
                {
                    MessageBox.Show("Записи с таким номером не существует!");
                    return;
                }
            }

            Close();
        }
        
        /* Защита от "дурака" (конпка не активна, пока все полня не заполнены) */
        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox2.Text.Length != 0 && textBox3.Text.Length != 0) button1.Enabled = true;
        }
    }
}