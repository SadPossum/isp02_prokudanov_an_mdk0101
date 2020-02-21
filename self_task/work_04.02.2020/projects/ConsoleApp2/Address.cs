using System;

namespace ConsoleApp2
{
    class Address
    {
        private int PostalCode { get; set; }
        private string Town { get; set; }
        private string Street { get; set; }
        private int House { get; set; }
        private int Apartment { get; set; }

        public Address(int postalCode, string town, string street, int house, int apartment)
        {
            PostalCode = postalCode;
            Town = town;
            Street = street;
            House = house;
            Apartment = apartment;
        }

        public override string ToString() => $"Адресс: {PostalCode}, {Town}, {Street}, {House}, {Apartment}";
    }
}
