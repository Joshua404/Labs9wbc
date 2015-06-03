using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAwesomeLibrary
{
   public class StringUtilities
    {
        public static string CleanInput(string input)
        {
            return input.Trim().ToLowerInvarient();
        }

        private static void DoSomething()
        {
        
        }


    }

   class MyClass
   {
       void DoSomething()
       { 
       //StringUtilities.DoSomething()
       }
   
   }
}
