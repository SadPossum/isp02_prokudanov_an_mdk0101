using System;

namespace ConsoleApp2
{
    class ComputerGame
    {
        public string Name { get; set; }
        public string CompanyDeveloper { get; set; }
        public int YearOfBublishing { get; set; }
        public string Genre { get; set; }

        public ComputerGame(string name, string companyDeveloper, int yearOfBublishing, string genre)
        {
            Name = name;
            CompanyDeveloper = companyDeveloper;
            YearOfBublishing = yearOfBublishing;
            Genre = genre;
        }

        public override string ToString() => $"Компьютерная игра: {Name}, {CompanyDeveloper}, {YearOfBublishing}, {Genre}";
    }
}
