using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Labs
{
    public class Classsomething
    {

        //public string FirstName { get; set; }
        //public string LastName { get; set; }
        //public int Age { get; set; }
        //public DateTime Birthdate { get; set; }



        public int AddNumbers(params int[] numbers)
        {
            var total = 0;
            foreach (var num in numbers) {
                total += num;
            }
            return total;
        }


        public int Calculator { get; set; }

        public int AddNumbers()
        {
            return AddNumbers(3);
        }

        public int AddNumbers(int num1)
        {
            return AddNumbers(3, 2);
        }

        public int AddNumbers(int num1, int num2)
        {
            return num1 + num2;

        }


    }
}
