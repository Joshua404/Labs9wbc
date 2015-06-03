using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var chicken1 = new Chicken
            {
                Name = "Dinner"

            };

            var bear1 = new Bear
            {
                Name = "Run"

            };

            var eagle1 = new Eagle
            {
                Name = "Pretty"

            };


            AnimalUtility.DoSomething(chicken1);
            AnimalUtility.DoSomething(bear1);
            AnimalUtility.DoSomething(eagle1);
            Console.ReadLine();

            var email = StringUtilities.CleanInput("espjgwjp@jfep.com");

            StringUtilities.DoSomething();

        }
    }
}
