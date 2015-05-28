using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Labs
{
    class Program
    {
        static void Main(string[] args)
        {


            //            var Sally = new Classsomething {
            //            FirstName = "Sally",
            //            LastName = "WIlliams",
            //            Age = 23,
            //            Birthdate = DateTime.Parse("8/4/2023")
            //            };
            //            Debug.Assert(Sally.Age == 23, "Sally is 23!");

            //            var Mike = new Classsomething
            //            {
            //                FirstName = "Mike",
            //                LastName = "Harrison",
            //                Age = 10,
            //                Birthdate = DateTime.Parse("3/17/2019")
            //            };
            //            Debug.Assert(Mike.Age == 10, "Mike is 10!");
            //            Debug.Assert(Mike.Age == 0, "Mike cannot be younger than 0.");
            //            Console.WriteLine(Sally);
            //            Console.WriteLine(Mike);
            //            Console.ReadLine();

            //var calculatorss = new Classsomething();


            //var total = calculatorss.AddNumbers(3, 2);

            //Console.WriteLine(total);
            //Console.ReadLine();

            //var customer = new Customer();

            //var customer = new Customer();


            //customer.BillingAddress.Street = "1 Main Street";
            //customer.BillingAddress.City = "Redmond";





            //var product = new Product("Coke", 2.7m, 30);

            //Console.Write("Please enter the product description");

            //product.Description = Console.ReadLine();

            //Debug.Assert(product.Name == "Coke", "No Coke");

            //Console.WriteLine("{0} {1} {2}",product.Name, product.Price, product.Description);
            //Console.ReadLine();

            var customer = new Customer();

            //Console.Write("Please enter the product description");

            //product.Description = Console.ReadLine();

            //Debug.Assert(customer.Name == "Coke", "No Coke");

            {
                customer.CheckingAccount.Name = "Alice";
                customer.CheckingAccount.ID = 1;
                customer.CheckingAccount.Type = "Checking";
                customer.CheckingAccount.Amount = 100.00m;
                customer.CheckingAccount.IsOpen = true;
                customer.CheckingAccount.Name = "Alice";
                customer.CheckingAccount.ID = 2;
                customer.CheckingAccount.Type = "Savings";
                customer.CheckingAccount.Amount = 0.00m;
                customer.CheckingAccount.IsOpen = false;
            
            
            }

            Console.WriteLine("{0} {1} {2} {3} {4}", customer.Name, customer.ID, customer.Type, customer.Amount, customer.IsOpen);
            Console.ReadLine();



        }
    }
}
