using System;
using System.Collections.Generic;
using System.Text;

namespace Academy
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        private static int _id = 0;

        public Student()
        {
            _id++;
            Id = _id;
        }

        public Student(string Name, string Surname) : this()
        {

            this.Name = Name;
            this.Surname = Surname;
        }

        public override string ToString()
        {
            return $"{Id} - {Name} {Surname}";
        }
    }
}
