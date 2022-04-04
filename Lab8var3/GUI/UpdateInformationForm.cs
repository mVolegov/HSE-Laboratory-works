using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Lab8var3.Model;
using Lab8var3.Service;

namespace Lab8var3.GUI
{
    public partial class UpdateInformationForm : Form
    {
        /* списки студентов для каждой группы */
        private List<Student> studentsGroup1;
        private List<Student> studentsGroup2;
        private List<Student> studentsGroup3;
        public UpdateInformationForm(List<Student> students1, List<Student> students2, List<Student> students3)
        {
            /* Внедрение списков студентов */
            studentsGroup1 = students1;
            studentsGroup2 = students2;
            studentsGroup3 = students3;
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* Добавление старого-нового студента (обновление) */
            if (radioButton1.Checked) // Обновление по номеру записи
            {
                int index = int.Parse(numericUpDown4.Text); // Считывание номера записи
                int previousGroup = int.Parse(numericUpDown2.Text); // Считывание группы, из которой будет удаляться

                if (previousGroup == 1 && studentsGroup1.Count <= index || 
                    previousGroup == 2 && studentsGroup2.Count <= index || 
                    previousGroup == 3 && studentsGroup3.Count <= index)
                {
                    MessageBox.Show("Студента по такой записи не существует!");
                }
                else
                {
                    /* Считывание новых данных  */
                    string newName = textBox2.Text;
                    string newSurname = textBox3.Text;
                    int newGroup = int.Parse(numericUpDown3.Text);

                    // Поиск студента по группе и номеру записи в группе 
                    Student student = Helper.FindStudentByGroupAndIndex(index, previousGroup,
                        studentsGroup1, studentsGroup2, studentsGroup3);
                    int oldGroup = student.Group; // Поиск старой группы студента
                    int id = student.Id; // Поиск айди студента

                    Student updatedStudent = new Student(id, newName, newSurname, newGroup);

                    if (newGroup == oldGroup) // Группа не поменялась
                    {
                        if (newGroup == 1)
                        {
                            studentsGroup1.Remove(student);
                            studentsGroup1.Insert(index, updatedStudent);

                            Helper.Serialize(studentsGroup1, @"..\..\Database\Group1.bin");
                        }
                        else if (newGroup == 2)
                        {
                            studentsGroup2.Remove(student);
                            studentsGroup2.Insert(index, updatedStudent);

                            Helper.Serialize(studentsGroup2, @"..\..\Database\Group2.bin");
                        }
                        else if (newGroup == 3)
                        {
                            studentsGroup3.Remove(student);
                            studentsGroup3.Insert(index, updatedStudent);

                            Helper.Serialize(studentsGroup3, @"..\..\Database\Group3.bin");
                        }
                    }
                    else // Группа поменялась
                    {
                        /* Удаление студента из старой группы */
                        if (oldGroup == 1)
                        {
                            studentsGroup1.Remove(student);
                            Helper.Serialize(studentsGroup1, @"..\..\Database\Group1.bin");
                        }
                        else if (oldGroup == 2)
                        {
                            studentsGroup2.Remove(student);
                            Helper.Serialize(studentsGroup2, @"..\..\Database\Group2.bin");
                        }
                        else if (oldGroup == 3)
                        {
                            studentsGroup3.Remove(student);
                            Helper.Serialize(studentsGroup3, @"..\..\Database\Group3.bin");
                        }

                        /* Добавление студента в новую группу */
                        if (newGroup == 1)
                        {
                            studentsGroup1.Add(updatedStudent);
                            Helper.Serialize(studentsGroup1, @"..\..\Database\Group1.bin");
                        }
                        else if (newGroup == 2)
                        {
                            studentsGroup2.Add(updatedStudent);
                            Helper.Serialize(studentsGroup2, @"..\..\Database\Group2.bin");
                        }
                        else if (newGroup == 3)
                        {
                            studentsGroup3.Add(updatedStudent);
                            Helper.Serialize(studentsGroup3, @"..\..\Database\Group3.bin");
                        }
                    }
                    
                    Close();
                }
            }
            else if (radioButton2.Checked) // Обновление по ID
            {
                /* Считывание новых данных */
                int id = int.Parse(numericUpDown1.Text);
                string newName = textBox2.Text;
                string newSurname = textBox3.Text;
                int newGroup = int.Parse(numericUpDown3.Text);

                Student updatedStudent = new Student(id, newName, newSurname, newGroup); // Студент с новыми данными

                // Поиск студента по ID
                Student student = Helper.FindStudentById(id,
                    studentsGroup1, studentsGroup2, studentsGroup3);

                if (student != null)
                {
                    int oldGroup = student.Group; // Старая группа студента

                    if (oldGroup == newGroup) // Группа не поменялась
                    {
                        int index;

                        if (newGroup == 1)
                        {
                            index = studentsGroup1.IndexOf(student);
                            studentsGroup1.Remove(student);
                            studentsGroup1.Insert(index, updatedStudent);

                            Helper.Serialize(studentsGroup1, @"..\..\Database\Group1.bin");
                        }
                        else if (newGroup == 2)
                        {
                            index = studentsGroup2.IndexOf(student);
                            studentsGroup2.Remove(student);
                            studentsGroup2.Insert(index, updatedStudent);

                            Helper.Serialize(studentsGroup2, @"..\..\Database\Group2.bin");
                        }
                        else if (newGroup == 3)
                        {
                            index = studentsGroup3.IndexOf(student);
                            studentsGroup3.Remove(student);
                            studentsGroup3.Insert(index, updatedStudent);

                            Helper.Serialize(studentsGroup3, @"..\..\Database\Group3.bin");
                        }
                    }
                    else // Группа поменялась
                    {
                        /* Удаление студента из старой группы */
                        if (oldGroup == 1)
                        {
                            studentsGroup1.Remove(student);
                            Helper.Serialize(studentsGroup1, @"..\..\Database\Group1.bin");
                        }
                        else if (oldGroup == 2)
                        {
                            studentsGroup2.Remove(student);
                            Helper.Serialize(studentsGroup2, @"..\..\Database\Group2.bin");
                        }
                        else if (oldGroup == 3)
                        {
                            studentsGroup3.Remove(student);
                            Helper.Serialize(studentsGroup3, @"..\..\Database\Group3.bin");
                        }

                        /* Добавление студента в новую группу*/
                        if (newGroup == 1)
                        {
                            studentsGroup1.Add(updatedStudent);
                            Helper.Serialize(studentsGroup1, @"..\..\Database\Group1.bin");
                        }
                        else if (newGroup == 2)
                        {
                            studentsGroup2.Add(updatedStudent);
                            Helper.Serialize(studentsGroup2, @"..\..\Database\Group2.bin");
                        }
                        else if (newGroup == 3)
                        {
                            studentsGroup3.Add(updatedStudent);
                            Helper.Serialize(studentsGroup3, @"..\..\Database\Group3.bin");
                        }
                    }
                    
                    Close();
                }
                else
                {
                    MessageBox.Show("Студента с таким ID нет!");
                }
            }
        }
    }
}