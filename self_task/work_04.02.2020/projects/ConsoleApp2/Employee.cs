using System;

namespace ConsoleApp2
{
    class Employee
    {
        private string name;
        private string profession;
        private double workingExperience;

        public Employee(string name, string profession, double workingExperience)
        {
            Name = name;
            Profession = profession;
            WorkingExperience = workingExperience;
        }

        public string Name
        {
            set { name = value; }
            get => name;
        }

        public string Profession
        {
            set { profession = value; }
            get => profession;
        }

        public double WorkingExperience
        {
            set { workingExperience = value; }
            get => workingExperience;
        }

        public override string ToString() => $"Служащий: {Name}, {Profession}, {WorkingExperience}";
    }
}
