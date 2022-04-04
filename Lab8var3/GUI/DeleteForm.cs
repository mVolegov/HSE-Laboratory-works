using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Lab8var3.Model;
using Lab8var3.Service;

namespace Lab8var3.GUI
{
    public partial class DeleteForm : Form
    {
        /* списки студентов для каждой группы */
        private List<Student> studentsGroup1;
        private List<Student> studentsGroup2;
        private List<Student> studentsGroup3;
        public DeleteForm(List<Student> students1, List<Student> students2, List<Student> students3)
        {
            /* Внедрение списков студентов */
            studentsGroup1 = students1;
            studentsGroup2 = students2;
            studentsGroup3 = students3;
            
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            /* Выбор типа удаления */
            if (radioButton1.Checked) // Удаление по номеру записи
            {
                int group = int.Parse(numericUpDown2.Text);
                
                if (group == 1 && studentsGroup1.Count > int.Parse(numericUpDown1.Text)) // Удаление из файла 1 группы
                {
                    studentsGroup1.RemoveAt(int.Parse(numericUpDown1.Text));
                    Helper.Serialize(studentsGroup1, @"..\..\Database\Group1.bin");
                }
                else if (group == 2 && studentsGroup2.Count > int.Parse(numericUpDown1.Text)) // Удаление из файла 2 группы
                {
                    studentsGroup2.RemoveAt(int.Parse(numericUpDown1.Text));
                    Helper.Serialize(studentsGroup2, @"..\..\Database\Group2.bin");
                }
                else if (group == 3 && studentsGroup3.Count > int.Parse(numericUpDown1.Text)) // Удаление из файла 3 группы
                {
                    studentsGroup3.RemoveAt(int.Parse(numericUpDown1.Text));
                    Helper.Serialize(studentsGroup3, @"..\..\Database\Group3.bin");
                }
                else
                {
                    MessageBox.Show("Такой записи не существует!");
                    return; // Метод завершает роботу, не доходя до Close();
                }
                
                Close();
            }
            else if (radioButton2.Checked) // Удаление по ID
            {
                int id = int.Parse(numericUpDown3.Text);
                
                Student studentToDelete =
                        Helper.FindStudentById(id, studentsGroup1, studentsGroup2, studentsGroup3);
                
                if (studentToDelete != null)
                {
                    int group = studentToDelete.Group;

                    if (group == 1) // Удаление из файла 1 группы
                    {
                        studentsGroup1.Remove(studentToDelete);
                        Helper.Serialize(studentsGroup1, @"..\..\Database\Group1.bin");
                    }
                    else if (group == 2) // Удаление из файла 2 группы
                    {
                        studentsGroup2.Remove(studentToDelete);
                        Helper.Serialize(studentsGroup2, @"..\..\Database\Group2.bin");
                    }
                    else if (group == 3) // Удаление из файла 3 группы
                    {
                        studentsGroup3.Remove(studentToDelete);
                        Helper.Serialize(studentsGroup3, @"..\..\Database\Group3.bin");
                    }
                    
                    Close();
                }
                else
                {
                    MessageBox.Show("Студента с таким ID не существует!");
                }
            }
        }
    }
}