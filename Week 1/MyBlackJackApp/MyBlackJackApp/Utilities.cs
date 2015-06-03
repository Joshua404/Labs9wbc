using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlackJackApp
{
    public class Utilities
    {
        public static Dictionary<int, string> CreateDictionary()
        {
            var Cards = new Dictionary<int, string>();

            for (int f = 0; f < 13; f++)
            {
                Cards.Add(f, "Hearts");
            }

            for (int f = 13; f < 26; f++)
            {
                Cards.Add(f, "Clubs");
            }

            for (int f = 26; f < 39; f++)
            {
                Cards.Add(f, "Spades");
            }

            for (int f = 39; f < 52; f++)
            {
                Cards.Add(f, "Diamonds");
            }
            return Cards;
        }

    }
}
