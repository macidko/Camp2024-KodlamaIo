using Intro_2024.Business;
using Intro_2024.Entities;

namespace Intro_2024
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string message = "Krediler";
            int term = 12;
            double amount = 100000;

            //variables -->camelCase
            bool isAuthenticated = false;//backend'ten gelen data.
            Console.WriteLine(message);

            //condition
            if (isAuthenticated == true)
            {
                Console.WriteLine("Hoşgeldin Engin");
            }
            else
            {
                Console.WriteLine("Sisteme giriş yap");
            }

            //string kredi1 = "Kredi 1";
            //string kredi2 = "Kredi 2";
            //string kredi3 = "Kredi 3";
            //string kredi4 = "Kredi 4";
            //string kredi5 = "Kredi 5";

            //array
            string[] loans = { "Kredi1", "Kredi2", "Kredi3", "Kredi4", "Kredi5" };

            //string[] loans2 = new string[6];
            //loans2[0] = "Kredi1";

            //start     //condition    //increment
            for (int i = 0; i < loans.Length; i++)
            {
                Console.WriteLine(loans[i]);
            }

            foreach (var loan in loans)
            {
                Console.WriteLine(loan);
            }



            //Course[] courses = { course1, course2, course3 };



            CourseManager courseManager = new();
            Course[] courses2 = courseManager.GetAll();

            for (int i = 0; i < courses2.Length; i++)
            {
                Console.WriteLine(courses2 + " / " + courses2[i].Price);
            }

            Console.WriteLine("kod bitti");

            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.NationalIdentity = "1234567234";
            customer1.FirstName = "Eren";
            customer1.LastName = "Macit";
            customer1.CustomerNumber = "22";

            IndividualCustomer customer2 = new IndividualCustomer();
            customer2.Id = 2;
            customer2.NationalIdentity = "2313412512";
            customer2.FirstName = "Macit";
            customer2.LastName = "Eren";
            customer2.CustomerNumber = "222";

            CoorperateCustomer customer3 = new CoorperateCustomer();
            customer3.Id = 3;
            customer3.Name = "Kodlamaio";
            customer3.CustomerNumber = "123";
            customer3.TaxNumber = "1234";

            CoorperateCustomer customer4 = new CoorperateCustomer();
            customer4.Id = 4;
            customer4.Name = "Abc";
            customer4.CustomerNumber = "2345";
            customer4.TaxNumber = "5345123";

            int number1 = 10;//20
            int number2 = 20;
            number1 = number2;
            number2 = 30;
            Console.WriteLine(number1);

            string[] cities1 = { "Ankara", "İstanbul", "İzmir" };
            string[] cities2 = { "Bursa", "Bolu", "Edirne" };

            cities2 = cities1;
            cities1[0] = "Adana";

            Console.WriteLine(cities2[0]);

            //valuetypes => int, bool, double...
            //ref rypes => array, class, interface...

            //Polymorphism
                            //101       //102       //103       //104     
            BaseCustomer[] customers = { customer1, customer2, customer3, customer4 };

            foreach (BaseCustomer customer in customers)
            {
                Console.WriteLine(customer.CustomerNumber);
            }

        }
    }
}