using System;

namespace ReferanceTypes2
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            

            IPersonManager employeeManager = new EmployeeManager();
            employeeManager.Update();

            ProjectManager projectManager = new ProjectManager();
            //  projectManager.AddCustomer(customerManager);

            IPersonManager personManager = new ProjectManager();
            personManager.Add();

            NewManager newManager = new NewManager();
            newManager.Add(new ProjectManager());
            newManager.Add(new CustomerManager());


        }
    }

    //class - inherits --- interface - implements

    interface IPersonManager
    {
        void Add();

        void Update();
    }

    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Müşteri Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Müşteri Güncellendi");
        }
    }

    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Personel Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Müşteri Güncellendi");
        }
    }

    class ProjectManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("PersonManager gidildi eklendi");
        }

        public void Update()
        {
        }
    }

    class NewManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }
    }
        
}
