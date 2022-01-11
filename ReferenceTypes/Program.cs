using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Uğur Okan";

            person2 = person1;
            person1.FirstName = "Çivgin";

            //Console.WriteLine(person2.FirstName);


            Customer customer = new Customer();

            customer.CreditNumber = "asdas21321";
            customer.FirstName = "Sait";

            Employee employee = new Employee();

            Person person3 = customer;
            //Console.WriteLine(((Customer)person3).CreditNumber);

            PersonManager personManager = new PersonManager();
            personManager.Add(person3);
        }
    }


    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

    //base class:Person
    class Customer:Person
    {
        public string CreditNumber { get; set; }
    }
    class Employee:Person
    {
        public int EmployeeNumber { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(((Customer)person).CreditNumber);
        }
    }
}
