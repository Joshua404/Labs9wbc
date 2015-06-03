using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Day_4_Labs
{
    class Program
    {
        static void Main(string[] args)
        {

            //var cart = new ShoppingCart();
            //cart.AddItem("Fritos", 2.33m);
            //cart.AddItem("Fritos", 2.33m);
            //cart.AddItem("Fritos", 2.33m);
            //cart.AddItem("Fritos", 2.33m);

            //Console.WriteLine(cart.GetTotal());
            //Console.ReadLine();

//            var news = new List<NewsItem>();

//            news.Add(new NewsItem { Text = "Martians Attack, But we Blow Them all To Hell With our Nukes (General 'Tom Cruise')", Color = ConsoleColor.DarkRed});
//            news.Add(new NewsItem { Text = "The Seahawks Private Jet Crashes In The Alps, (No Survivors)", Color = ConsoleColor.Green });
//            news.Add(new NewsItem { Text = "Russia Bombs the USA (The Start of WW3)", Color = ConsoleColor.DarkMagenta });


      
//         Random rnd = new Random();
//            int num = rnd.Next(news.Count);
//            var selectedHeadline = news[num];

////         var rnd = new Random();

//////            var news = rnd.Next(3);

////            Console.WriteLine(NewsItem.text, Console.BackgroundColor = NewsItem.color);
//            Console.BackgroundColor = selectedHeadline.Color;
//            Console.WriteLine(selectedHeadline.Text);
//            Console.ReadLine();

            //var profanity = new Dictionary<string, string>();
            //{
            //    profanity.Add("Damn", "D***");
            //    profanity.Add("Fuck", "F***");
            //    profanity.Add("Bitch", "B****");

            //}
            //var input = Console.ReadLine();
            //var badwords = input.ToLower();
            //var badwordsArray = input.Split();
            //var result = " ";
            //foreach(var word in badwordsArray)
            //{
            //    if (profanity.ContainsKey(word))
            //    {
            //    result += profanity[word] + " ";
            //    }
            //    else {}
            //};
            ////var badwords = [];

            //Console.WriteLine(result);
            //Console.ReadLine();



            //async static Task ShowMicrosoftPage()
            //{
            //var client = new HttpClient();
            //var result = await client.GetStringAsync("http://microsoft.com");
            //    Console.WriteLine(result);
            //}

            
            //ShowMicrosoftPage().Wait();
            //Console.ReadLine();




//        using System;
//using System.Net.Http;
//using System.Threading;
//using System.Threading.Tasks;
//namespace MyConsoleApp
//{
//    class Program
//    {
//        public async static Task<int> SlowAdd(int val1, int val2)
//        {
//            await Task.Delay(TimeSpan.FromSeconds(5));
//            return val1 + val2;
//        }

//        public async static Task DoSomething()
//        {
//            Console.WriteLine("{0:T} Before SuperSlow, Thread={1}", DateTime.Now, Thread.CurrentThread.ManagedThreadId);
//            var result = await SlowAdd(3, 4);
//            Console.WriteLine("{0:T} After SuperSlow, Thread={1}, value={2}", DateTime.Now, Thread.CurrentThread.ManagedThreadId, result);
//        }

//        static void Main(string[] args)
//        {
//            // block synchronously until task is completed
//            DoSomething().Wait();
//            // pause
//            Console.ReadLine();
//        }
//    }
//}
        }
    }
}
