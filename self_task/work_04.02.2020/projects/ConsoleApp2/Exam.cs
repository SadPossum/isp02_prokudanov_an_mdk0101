using System;

namespace ConsoleApp2
{
    class Exam
    {
        private string fullNameOfTheExaminee;
        private string examinerFullName;
        private DateTime date;
        private int mark;

        public Exam(string fullNameOfTheExaminee, string examinerFullName, DateTime date, int mark)
        {
            FullNameOfTheExaminee = fullNameOfTheExaminee;
            ExaminerFullName = examinerFullName;
            Date = date;
            Mark = mark;
        }

        public string FullNameOfTheExaminee
        {
            set { fullNameOfTheExaminee = value; }
            get => fullNameOfTheExaminee;
        }

        public string ExaminerFullName
        {
            set { examinerFullName = value; }
            get => examinerFullName;
        }

        public DateTime Date
        {
            set { date = value; }
            get => date;
        }

        public int Mark
        {
            set 
            {
                if (value < 1 || value > 5)
                {
                    Console.WriteLine("Введено неверное значение.");
                    return;
                }
                else
                    mark = value;
            }

            get => mark;
        }

        public override string ToString() => $"Зачет: {FullNameOfTheExaminee}, {ExaminerFullName}, {Date.ToShortDateString()}, {Mark}";
    }
}
