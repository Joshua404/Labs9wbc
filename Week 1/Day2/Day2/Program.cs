using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Program
    {

        public static void BuildMessage(params string[] words)
        { 
        foreach (var word in words) {
            Console.Write(word + " ");
        }

        BuildMessage("Hi", "How", "are", "You");
        }



        static void Main(string[] args)
        {

                    //var product1 = new Product();

                    //product1.Name = "Pizza";
                    //product1.Price = 78.999m;

            //var product1 = new Product
            //{
            //    Name = "Ice Cream",
            //    Price = 23.888m
            //};


            var product = new Product
            {
                Price = 3.44m
            };

            var total = product.GetTotalPrice(taxRate: .99m, discount: 2.50m);

                    Console.WriteLine(total);
                    Console.ReadLine();
        }
    }
}
