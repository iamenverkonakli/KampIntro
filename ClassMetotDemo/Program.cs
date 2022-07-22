using System;

namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Name = "Enver";
            customer1.Surname = "Konakli";
            customer1.AccountNumber = 123456;

            Customer customer2 = new Customer();
            customer2.Name = "Eren";
            customer2.Surname = "Konakli";
            customer2.AccountNumber = 123789;

            Customer customer3 = new Customer();
            customer3.Name = "Coskun";
            customer3.Surname = "Konakli";
            customer3.AccountNumber = 456789;

            Customer[] customers = new Customer[] { customer1, customer2 ,customer3};
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Name);
                Console.WriteLine(customer.Surname);
                Console.WriteLine(customer.AccountNumber);
                Console.WriteLine("-----------------");

            }

            MusteriManager musteri = new MusteriManager();
            musteri.CustomerAdd(customer1);
            musteri.CustomerDelete(customer2);
            musteri.CustomerList(customer3);


        }
    }
}
