using System;

namespace firstBackEndHomeWork
{
    class Group
    {
        private  string name = "P210";

       public string getGroupName()
        {
            return name;
        }
    }
     
    class Student
    {
        private string Name;
        private string Surname;
        private string Group;

    public Student(string name, string surname, string group)
        {
            this.Name = name;
            this.Surname = surname;
            this.Group = group;
        }


        public string getStudentName()
        {
            return Name;
        }

        public string getStudentSurname()
        {
            return Surname;
        }

        public string getStudentGroup()
        {
            return Group;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter name");
            string studentName = Console.ReadLine();

            Console.WriteLine("Please enter surname");
            string studentSurname = Console.ReadLine();

            Group mygroup = new Group();
            Student ourstudent = new Student(studentName, studentSurname, mygroup.getGroupName());

            Console.WriteLine("Salam {0} {1}. Sizin qrupunuz {2}", ourstudent.getStudentName(), ourstudent.getStudentSurname(), ourstudent.getStudentGroup());


            Console.ReadLine();
        }
    }
}
