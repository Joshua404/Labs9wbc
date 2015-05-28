using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace ConsoleApplication1
{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var rnd = new Random();

//            var num = rnd.Next(10) + 1;

//            Console.WriteLine(num);

//            Console.ReadLine();


//        }
//    }
//}

//   class Program
//    {
//        static void Main(string[] args)
//        {

//            var num1 = 2;
//            var num2 = 0;

//            //Debug.Assert(num2 > 0, "num2 is zero");

//            var num3 = num1 / num2;

//            Console.WriteLine(DateTime.Now.ToLongDateString());
//            Console.ReadLine();


//        }
//    }
//}

//class Program
//    {
//        static void Main(string[] args)
//        {

//            string message = "Hello World";

//            var unitsinstock = 89;
            
//            Console.WriteLine(message);
//            Console.ReadLine();


//        }
//    }
//}

//class Program
//    {
//        static void Main(string[] args)
//        {

//            var price = 3444.4365346m;
//            var letter = 'a';
            
//            Console.WriteLine(price.ToString("c"));
//            Console.ReadLine();


//        }
//    }
//}

//class Program
//    {
//        static void Main(string[] args)
//        {

//            int result;
//            bool isInt = int.TryParse(899, out, result);
           
//            Console.WriteLine(message);
//            Console.ReadLine();


//        }
//    }
//}


//class Program
//    {
//        static void Main(string[] args)
//        {
//            var input = Console.ReadLine();
//            var someDate = DateTime.Parse(input);

//            Console.WriteLine(someDate.ToString("D"));
//            Console.ReadLine();
//        }
//    }
//}

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var dollars = 10;
//            var cents = 12;

//            var message = String.Format("It costs {0} and {1}" ,dollars, cents);

//            Console.WriteLine(message);
//            Console.ReadLine();
//        }
//    }
//}

//    class Program
//    {
//        static void Main(string[] args)
//        {
////            var filepath = @"c:\someDir\someText.txt";

////            var script = @"<script>
////
////                </script>"


//                //var sb = new StringBuilder();
//                //for(int i = 0; i < 1000; i++) {
//                //    sb.Append("Hello");

//                //}

//            //var input = Console.ReadLine();
//            //if(Regex.IsMatch(input, @"\d+")) {
//            //    Console.WriteLine("Valid Decimal!");
//            //}
//            //else
//            //{
//            //    Console.WriteLine("Invalid Decimal!");
//            //}


//            //var animals = new String[] {
//            //    "cats", "dogs"
//            //};

//            //var fruits = new String[2];
//            //fruits[0] = "apples";
//            //fruits[1] = "kiwis";


//            var rnd = new Random();

//            var news = rnd.Next(3);

//            var randomnews = new String[] {
//                "The Seahawks Get Blown-up by Nuke!", "The Sun Vaporizes", "Mouse Eats Cat"

//            };

//            Console.WriteLine(randomnews[news]);
//            Console.ReadLine();
//        }
//    }
//}

//    class Program
//    {
//        static void Main(string[] args)
//        {

//            string input = Console.ReadLine();

//            string [] split = input.Split();
            

//            Array.Reverse(split);
//            var fred = string.Join(" ", split);
//            Console.WriteLine(fred);
//            Console.ReadLine();
//        }
//    }
//}

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var fruit = "apples";


//            switch (fruit)
//            {
//                case "apples":
//                    Console.WriteLine("yes apples");
//                    break;
//                case "bannas":
//                    Console.WriteLine("yes bannas");
//                    break;
//                case "kiwis":
//                    Console.WriteLine("yes kiwis");
//                    break;
//                default:
//                    Console.WriteLine("something else");
//                    break;

//            }

//            Console.WriteLine(fruit == "apples" ? "Yes We Have Apples!" : "No, no apples");
//            Console.ReadLine();
//        }
//    }
//}

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var animals = new string[] { "cow", "cat", "python", "simese"};

//            for (int i = 0; i < animals.Length; i++)
//            {
//                Console.WriteLine(animals[i]);
//            }

//                   Console.ReadLine();


//                   foreach (var item in animals)
//                   {
//                       Console.WriteLine(item);   
//                   }


//                   var count = 10;
//            while (count > 0) {
//                Console.WriteLine(count);
//                count--;
//            }
//                   Console.ReadLine();
//        }
//    }
//}

    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 100; i++)
            {
                if (i % 7 == 0)
                {
                    Console.WriteLine(i);
                }

                else { }
            }

            //var count2 = 100;
            //while (count2 % 7 == 0 && count2 > 0) {
            //    Console.WriteLine(count2);
            //    count2 --;
            //}
              

            //Console.WriteLine(count);
            //    count--;
            //}
            Console.ReadLine();
        }
    }
}