using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            RealCustomer customer1 = new RealCustomer(); //Gerçek
            customer1.Id = 1;
            customer1.CustomerNumber = "12345";
            customer1.Name = "Atakan";
            customer1.Surname = "Çiğdem";
            customer1.TcNumber = "12345678910";

            CorporateCustomer customer2 = new CorporateCustomer(); //Tüzel
            customer2.Id = 2;
            customer2.CustomerNumber = "54321";
            customer2.CompanyName = "Jupiterus";
            customer2.TaxNumber = "1234567890";

            //Gerçek Müşteri - Tüzel Müşteri
            //SOLID - L 

            Customer customer3 = new RealCustomer();
            Customer customer4 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
        }
    }
}
