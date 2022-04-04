using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using Lab8var3.Model;

namespace Lab8var3.Service
{
    public static class Helper
    {
        /* Сериализациия */
        public static void Serialize(List<Student> group, string filePath)
        {
            BinaryFormatter bf = new BinaryFormatter();

            using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write))
            {
                bf.Serialize(fs, group);
            }
        }
        
        /* Десериализация */
        public static void Deserialize(ref List<Student> studentsGroup1, ref List<Student> studentsGroup2, 
            ref List<Student> studentsGroup3)
        {
            BinaryFormatter bf = new BinaryFormatter();

            using (FileStream fsGroup1 = new FileStream(@"..\..\Database\Group1.bin", 
                       FileMode.OpenOrCreate, FileAccess.Read))
            {
                if (fsGroup1.Length != 0) studentsGroup1 = (List<Student>) bf.Deserialize(fsGroup1);
            }
            
            using (FileStream fsGroup2 = new FileStream(@"..\..\Database\Group2.bin", 
                       FileMode.OpenOrCreate, FileAccess.Read))
            {
                if (fsGroup2.Length != 0) studentsGroup2 = (List<Student>) bf.Deserialize(fsGroup2);
            }
            
            using (FileStream fsGroup3 = new FileStream(@"..\..\Database\Group3.bin", 
                       FileMode.OpenOrCreate, FileAccess.Read))
            {
                if (fsGroup3.Length != 0) studentsGroup3 = (List<Student>) bf.Deserialize(fsGroup3);
            }
        }

        /* Поиск максимального айди с прошлой сессии */
        public static int FindOldMaxId(List<Student> group1, List<Student> group2, List<Student> group3)
        {
            int maxId = 0;

            foreach (var student in group1)
            {
                if (student.Id > maxId) maxId = student.Id;
            }
            
            foreach (var student in group2)
            {
                if (student.Id > maxId) maxId = student.Id;
            }
            
            foreach (var student in group3)
            {
                if (student.Id > maxId) maxId = student.Id;
            }

            return maxId;
        }
        
        /* Поиск студента по ID */
        public static Student FindStudentById(int idToFind, 
            List<Student> group1, List<Student> group2, List<Student> group3)
        {
            Student studentToFind =  group1.Find(student => student.Id == idToFind) ?? 
                                     group2.Find(student => student.Id == idToFind) ??
                                     group3.Find(student => student.Id == idToFind);

            return studentToFind;
        }
        
        /* Поиск студента по группе и номеру записи */
        public static Student FindStudentByGroupAndIndex(int indexToFind, int groupToFind, 
            List<Student> group1, List<Student> group2, List<Student> group3)
        {
            if (groupToFind == 1) return group1.ElementAt(indexToFind);
            
            if (groupToFind == 2) return group2.ElementAt(indexToFind);
            
            if (groupToFind == 3) return group3.ElementAt(indexToFind);

            return null;
        }
    }
}