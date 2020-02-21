using System;

namespace ConsoleApp2
{
    class EducationGroup
    {
        public int Id { get; set; }
        public int NumberOfStudents { get; set; }
        public int YearOfFormation { get; set; }
        public string Speciality { get; set; }

        public EducationGroup(int id, int numberOfStudents, int yearOfFormation, string speciality)
        {
            Id = id;
            NumberOfStudents = numberOfStudents;
            YearOfFormation = yearOfFormation;
            Speciality = speciality;
        }

        public override string ToString() => $"Учебная группа: {Id}, {NumberOfStudents} студентов, {YearOfFormation} год, {Speciality}";
    }
}
