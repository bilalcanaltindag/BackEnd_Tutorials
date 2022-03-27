using System;

namespace ReferansTypes_ValueTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Customer customer = new Customer();
            Employee employee = new Employee();

            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Bilal";

            person2 = person1;
            person1.FirstName = "Derin";
            Console.WriteLine(person1.FirstName);

            customer.FirstName = "Salih";

            Person person3 = customer;
            customer.FirstName = "Ahmet";

            Console.WriteLine(person1.FirstName);
            Console.WriteLine(person3.FirstName);
            Console.WriteLine(customer.FirstName);

            Console.WriteLine(((Customer)person3).CreditCardNumber);

            PersonManager personManager = new PersonManager();
            personManager.Add(customer);

        }
    }

    class Person
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }

    class Customer:Person
    {
        public string CreditCardNumber { get; set; }
    }

    class Employee:Person
    {
        public int EmployeeNumber { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine("Bu" + person.FirstName);

        }
    }
}
