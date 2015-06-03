using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var states = new List<String>();
            states.Add("ca");
            states.Add(23);

            string result = states[1];

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
