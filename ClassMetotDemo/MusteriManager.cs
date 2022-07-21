using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        public void CustomerAdd(Customer customer)
        {
            Console.WriteLine(customer.Name + " "+ customer.Surname+ " " + customer.AccountNumber +" eklendi."  );
        }
        public void CustomerList(Customer customer)
        {
            Console.WriteLine(customer.Name + " " + customer.Surname + " " + customer.AccountNumber + " listelendi.");

        }
        public void CustomerDelete(Customer customer)
        {
            Console.WriteLine(customer.Name + " " + customer.Surname + " " + customer.AccountNumber + " silindi.");

        }


    }
}
