using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Lab8var3.Model;
using Lab8var3.Service;

namespace Lab8var3.GUI
{
    public partial class MainMenuForm : Form
    {
        /* Списки студентов по группам */
        private List<Student> studentsGroup1 = new List<Student>();
        private List<Student> studentsGroup2 = new List<Student>();
        private List<Student> studentsGroup3 = new List<Student>();

        public MainMenuForm()
        {
            InitializeComponent();
            
            // Загрузка данных из файла
            Helper.Deserialize(ref studentsGroup1, ref studentsGroup2, ref studentsGroup3); 
            
            // Вывод данных на форму
            PrintDataToListView();
        }

        /* Закрытие */
        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        /* Удаление студента */
        private void button3_Click(object sender, EventArgs e)
        {
            DeleteForm deleteForm = new DeleteForm(studentsGroup1, studentsGroup2, studentsGroup3);
            deleteForm.ShowDialog();
            
            // Чтение данных их файла и вывод в listView
            Helper.Deserialize(ref studentsGroup1, ref studentsGroup2, ref studentsGroup3); 
            PrintDataToListView(); // Вывод даных в listView's
        }

        /* Обновление информации о студенте */
        private void button4_Click(object sender, EventArgs e)
        {
            UpdateInformationForm updateInformationForm = 
                new UpdateInformationForm(studentsGroup1, studentsGroup2, studentsGroup3);
            updateInformationForm.ShowDialog();
            
            // Чтение данных их файла и вывод в listView
            Helper.Deserialize(ref studentsGroup1, ref studentsGroup2, ref studentsGroup3); 
            PrintDataToListView(); // Вывод даных в listView's
        }

        /* Добавление нового студента */
        private void button5_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm(studentsGroup1, studentsGroup2, studentsGroup3);
            addForm.ShowDialog();

            // Чтение данных их файла и вывод в listView
            Helper.Deserialize(ref studentsGroup1, ref studentsGroup2, ref studentsGroup3); 
            PrintDataToListView(); // Вывод даных в listView's
        }
        
        /* Общий список студентов, отсортированный по алфавиту */
        private void button1_Click(object sender, EventArgs e)
        {
            AllGroupsForm allGroupsForm = new AllGroupsForm(studentsGroup1, studentsGroup2, studentsGroup3);
            allGroupsForm.ShowDialog();
        }
        
        /* Общий список студентов, по убыванию номеров групп */
        private void button2_Click(object sender, EventArgs e)
        {
            AllGroupsFormDesc allGroupsFormDesc = new AllGroupsFormDesc(studentsGroup1, studentsGroup2, studentsGroup3);
            allGroupsFormDesc.ShowDialog();
        }

        /* Вывод списков студентов в нужный listView */
        private void PrintDataToListView()
        {
            listView1.Items.Clear();
            listView2.Items.Clear();
            listView3.Items.Clear();

            foreach (var student in studentsGroup1)
            {
                string id = student.Id.ToString();
                string name = student.Name;
                string surname = student.Surname;
            
                ListViewItem lvi = new ListViewItem(new string[] {studentsGroup1.IndexOf(student).ToString(), 
                    id, name, surname});
                listView1.Items.Add(lvi);
            }
            
            foreach (var student in studentsGroup2)
            {
                string id = student.Id.ToString();
                string name = student.Name;
                string surname = student.Surname;

                ListViewItem lvi = new ListViewItem(new string[] {studentsGroup2.IndexOf(student).ToString(), 
                    id, name, surname});
                listView2.Items.Add(lvi);
            }
            
            foreach (var student in studentsGroup3)
            {
                string id = student.Id.ToString();
                string name = student.Name;
                string surname = student.Surname;

                ListViewItem lvi = new ListViewItem(new string[] {studentsGroup3.IndexOf(student).ToString(), 
                    id, name, surname});
                listView3.Items.Add(lvi);
            }
        }
    }
}