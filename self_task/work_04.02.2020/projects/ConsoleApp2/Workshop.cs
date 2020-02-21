using System;

namespace ConsoleApp2
{
    class Workshop
    {
        private string id;
        private int numberOfEmployees;

        public Workshop(string id, int numberOfEmployees)
        {
            Id = id;
            NumberOfEmployees = numberOfEmployees;
        }

        public string Id
        {
            set { id = value; }
            get => id;
        }

        public int NumberOfEmployees
        {
            set { numberOfEmployees = value; }
            get => numberOfEmployees;
        }

        public override string ToString() => $"Цех: {Id}, {NumberOfEmployees}";
    }
}
