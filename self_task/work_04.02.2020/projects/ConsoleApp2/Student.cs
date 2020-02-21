using System;

namespace ConsoleApp2
{
    class Student
    {
        private string name;
        private string course;
        public string Gender { get; }

        public Student(string name, string course, string gender)
        {
            Name = name;
            Course = course;
            Gender = gender;
        }

        public string Name
        {
            set { name = value; }
            get => name;
        }

        public string Course
        {
            set { course = value; }
            get => course;
        }

        public override string ToString() => $"Студент: {Name}, {Course}, {Gender}";
    }
}
