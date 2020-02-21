using System;

namespace ConsoleApp2
{
    class Product
    {
        public string ProductName { get; set; }
        public int NumberOfProduct { get; set;  }
        public int Price { get; set; }
        public int ShelfLife { get; set; }

        public Product(string productName, int numberOfProduct, int price, int shelfLife)
        {
            ProductName = productName;
            NumberOfProduct = numberOfProduct;
            Price = price;
            ShelfLife = shelfLife;
        }

        public override string ToString() => $"Товар: {ProductName}, {NumberOfProduct}, {Price} руб. {ShelfLife} Месяцев";
    }
}
