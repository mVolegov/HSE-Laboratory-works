using System;

namespace Lab8var3.Model
{
    [Serializable]
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Group { get; set; }

        public Student(int id, string name, string surname, int  group)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Group = group;
        }
    }
}