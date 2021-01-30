using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {

            Console.WriteLine("Added Customer: \n\n" + customer.Id + "\n" + customer.Name + "\n" + customer.Surname + "\n" + customer.Email + "\n" +customer.PhoneNumber);

        }

        public void List(List<Customer> listedcustomers)
        {

            foreach(Customer customer in listedcustomers)
            {

                Console.WriteLine("Listed Customer: \n\n" + customer.Id + "\n" + customer.Name + "\n" + customer.Surname + "\n" + customer.Email + "\n" + customer.PhoneNumber);

            }


        }




    }
}
