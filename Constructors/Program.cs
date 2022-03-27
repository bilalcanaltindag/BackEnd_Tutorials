using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { Id = 1, FirstName = "Bilal", LastName = "Altındağ", City = "Antalya" };

            Customer customer2 = new Customer(2, "Ali", "Ömercik", "Kocaeli");

            Method(3, "asada", "asdad", "adqew");
        }

        static void Method(int id, string firstName, string lastName, string city)
        {
            
        }
    }

    class Customer
    {
        public Customer()
        {

        }

        //default constructor

        public Customer(int id, string firstName, string lastName, string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }


        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string City { get; set; }
    }
}
