using System;

namespace Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu1 = new Student("Ali", "Alivev");
            Student stu2 = new Student("Ali", "Alivev");
            Student stu3 = new Student("Ali", "Alivev");
            Student stu4 = new Student("Ali", "Alivev");
            Student stu5 = new Student("Agil", "Bashirov");
            Student stu6 = new Student("Ali", "Alivev");
            Student stu7 = new Student("Ali", "Alivev");
            Student stu8 = new Student("Ali", "Alivev");
            Student stu9 = new Student("Ali", "Alivev");
            Student stu10 = new Student("Ali", "Alivev");
            Student stu11 = new Student("Ali", "Alivev");

            Group group = new Group("P512", 10);

            group.AddStudent(stu1);
            group.AddStudent(stu2);
            group.AddStudent(stu3);
            group.AddStudent(stu4);
            group.AddStudent(stu5);
            group.AddStudent(stu6);
            group.AddStudent(stu7);
            group.AddStudent(stu8);
            group.AddStudent(stu9);
            group.AddStudent(stu10);
            //group.AddStudent(stu11);

            //group.StudentList();

            group.FindStudent(5);
        }
    }
}
