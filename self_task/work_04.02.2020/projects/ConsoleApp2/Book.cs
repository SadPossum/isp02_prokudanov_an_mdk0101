using System;

namespace ConsoleApp2
{
    class Book
    {
        private string bookName;
        private string[] authors;
        public double price;

        public Book(string bookName, string[] authors, double price)
        {
            BookName = bookName;
            Authors = authors;
            Price = price;
        }

        public string BookName
        {
            set { bookName = value; }
            get => bookName;
        }

        public string[] Authors
        {
            set { authors = value; }
            get => authors;
        }

        public double Price
        {
            set { price = value; }
            get => price;
        }

        public override string ToString() => $"Студент: {BookName}, {String.Join(", ", Authors)}, {Price} руб.";
    }
}
