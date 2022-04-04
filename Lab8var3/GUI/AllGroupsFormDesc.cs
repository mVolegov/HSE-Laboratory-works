using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Lab8var3.Model;
using Lab8var3.Service;

namespace Lab8var3.GUI
{
    public partial class AllGroupsFormDesc : Form
    {
        private List<Student> studentsGroup1;
        private List<Student> studentsGroup2;
        private List<Student> studentsGroup3;
        
        public AllGroupsFormDesc(List<Student> students1, List<Student> students2, List<Student> students3)
        {
            /* Внедрение списков студентов */
            studentsGroup1 = students1;
            studentsGroup2 = students2;
            studentsGroup3 = students3;
            
            InitializeComponent();
            
            PrintAllStudents(); // Вывод данных на форму (при создании объекта)
        }

        /* Закрытие формы */
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        /* Вывод данных на форму и сериализация */
        private void PrintAllStudents()
        {
            listView1.Items.Clear();
            
            // Соединение списков групп в полный список групп
            List<Student> allGroups = studentsGroup1.Concat(studentsGroup2).Concat(studentsGroup3).ToList();

            // Сортировка
            var sortedStudents = allGroups.OrderByDescending(student => student.Group); 
            
            /* Вывод в listView */
            foreach (var student in sortedStudents)
            {
                ListViewItem lvi = new ListViewItem(new string[] {student.Id.ToString(), student.Name, 
                    student.Surname, student.Group.ToString()});
                listView1.Items.Add(lvi);
            }

            /* Сериализация */
            Helper.Serialize(sortedStudents.ToList(), @"..\..\Database\AllGroups(groups_desc).bin");
        }
    }
}