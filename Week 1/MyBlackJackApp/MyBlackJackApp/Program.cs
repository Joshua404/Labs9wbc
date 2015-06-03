using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlackJackApp
{
    public class Program
    {
        public static void Main()
        {

            
            
            while (true)
                {
                Console.Clear();
                Console.WriteLine("Please press 's' to Start a game or 'q' to quit");
                var start = Console.ReadLine();
                if (start == "s")
                {
                    Game game = new Game();
                    game.PlayGame();
                }
                else if (start == "q")
                    break;
                else
                    Error.ErrorTrigger();
           
                Console.WriteLine("Please Press any key to start over or press 'q' to quit");
                var resp2 = Console.ReadLine();
                    if (resp2 == "q")
                        break;
                 }


             
        }
    }
}
