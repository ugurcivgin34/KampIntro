using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using System;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager baseCustomerManager = new NeroCustomerManager();
            baseCustomerManager.Save(new Customer { DateOfBirth=new DateTime(1990,1,2),FirstName="Uğur Okan" , LastName="Çivgin" , NationalityId="29575929974"});
            Console.ReadLine();
        }
    }
}
