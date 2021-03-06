using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonManager manager = new PersonManager();
            // manager.Add(new Customer { Id = 1, FirstName = "Bilal", LastName = "Altındağ", Address = "Kocaeli" });

            Customer customer1 = new Customer
            {
                Id = 1,
                FirstName = "Bilal",
                LastName = "Altındağ",
                Address = "Kocaeli"
            };

            Student student1 = new Student
            {
                Id = 2,
                FirstName = "Efe",
                LastName = "Altındağ",
                Departmant = "Yazılım"
            };
            manager.Add(customer1);
            manager.Add(student1);
            

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());
            customerManager.Add(new OracleCustomerDal());

            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal(),
                new MySqlCustomerDal()
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }

            Console.ReadLine();
        }
    }

    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }

    class Customer:IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Address { get; set; }
    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Departmant { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(" tamam" + person.FirstName);
        }
    }
}
