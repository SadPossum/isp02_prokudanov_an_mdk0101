using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Артем", "ИСП", "Муж.");
            Console.WriteLine(student1.ToString());

            Employee employee1 = new Employee("Виктор", "геймдизайнер", 2.3);
            Console.WriteLine(employee1.ToString());

            Workshop workshop1 = new Workshop("икпт", 21);
            Console.WriteLine(workshop1.ToString());

            string[] books1Authors = { "Гитерелл Ауфолд" };
            Book book1 = new Book("МаиндКайф", books1Authors, 300);
            Console.WriteLine(book1.ToString());

            DateTime date = new DateTime(2020, 2, 25);
            Exam math = new Exam("Иванов Иван Георгиевич", "Опушкин Игнат Олегович", date, 5);
            Console.WriteLine(math.ToString());

            Address address1 = new Address(12235, "Волжский", "Мира", 6, 65);
            Console.WriteLine(address1.ToString());

            Product milk = new Product("Русское Молоко", 2457, 34, 4);
            Console.WriteLine(milk.ToString());

            EducationGroup group1 = new EducationGroup(56, 20, 2020, "ИСП-5");
            Console.WriteLine(group1.ToString());

            Banknote banknote1 = new Banknote(34647568, 10, "десять рублей");
            Console.WriteLine(banknote1.ToString());

            ComputerGame computerGame1 = new ComputerGame("Ведьмак 3: Дикая Охота", "CD Project", 2015, "action/RPG");
            Console.WriteLine(computerGame1.ToString());

            Console.ReadKey();
        }
    }
}
