using System;
using System.Collections.Generic;
using System.Text;

namespace Academy
{
    class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }

        private static int _id = 0;
        public int MaxCount { get; set; }

        Student[] students = new Student[0];

        public Group()
        {
            _id++;
            Id = _id;
        }
        public Group(string name, int maxCount) : this()
        {
            Name = name;
            MaxCount = maxCount;
        }

        public override string ToString()
        {
            return Name;
        }

        public void AddStudent(Student stu)
        {
            if (students.Length >= MaxCount)
            {
                Console.WriteLine($"{Name} - qrupu doludur");
            }
            else
            {
                Array.Resize(ref students, students.Length + 1);
                students[students.Length - 1] = stu;
            }
        }

        public void StudentList()
        {
            foreach (var item in students)
            {
                Console.WriteLine(item);
            }
        }

        public void FindStudent(int id)
        {
            foreach (var item in students)
            {
                if (item.Id == id)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
