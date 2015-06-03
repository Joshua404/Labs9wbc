using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlackJackApp
{
    public class Error
    {
        public static void ErrorTrigger()
        {
            while (true)
            {
                Console.WriteLine("You did not enter a valid option, please press 't' to try again or 'q' to quit");
                var resp = Console.ReadLine();
                if (resp == "t")
                    Program.Main();

                else if (resp == "q")
                    Environment.Exit(0);


                else
                    Error.ErrorTrigger();
            }
         }
        
        
    }

}
