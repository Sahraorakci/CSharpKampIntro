using ClassMethodDemo;
using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Name = "Alihan";
            customer1.Surname = "Demirdas";
            customer1.Email = "alihan@gmail.com";
            customer1.PhoneNumber = 0141431414;

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Name = "İbrahim";
            customer2.Surname = "Demirdas";
            customer2.Email = "ibrahim@gmail.com";
            customer2.PhoneNumber = 0141431415;

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.Name = "Ferhan";
            customer3.Surname = "Demirdas";
            customer3.Email = "ferhan@gmail.com";
            customer3.PhoneNumber = 0141431416;

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);

            Console.WriteLine("\n---Registered Customers in System---\n");

            List<Customer> listedCustomers = new List<Customer> { customer1, customer2, customer3 };
            customerManager.List(listedCustomers);
            

           




        }
    }
}
