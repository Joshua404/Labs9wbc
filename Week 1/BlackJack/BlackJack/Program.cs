using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)

            {
                Console.Clear();
                Game game = new Game();
                game.PlayGame();

                Console.WriteLine("Press any key to beging or press 'q' to quit");
                var resp = Console.ReadLine();
                if (resp == "q")
                break;

            
            }

        }
    }
}
