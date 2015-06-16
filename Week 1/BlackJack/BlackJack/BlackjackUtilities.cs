using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class BlackjackUtilities
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

            for (int f = 39; f < 52; f++ )
            {
                Cards.Add(f, "Diamonds");
            }
            return Cards;
        }

        public static List<Card> CreateDeckasList()
        {
            var Cards = new List<Card>();
            for (int f = 0; f < 13; f++) 
            {
                var card = new Card { Id = f, Face = f, Suite = "H" };
                Cards.Add(card);
            }

            for (int f = 0; f < 13; f++) 
            {
                var card = new Card { Id = f + 13, Face = f, Suite = "C" };
                Cards.Add(card);
            }

            for (int f = 0; f < 13; f++) 
            {
                var card = new Card { Id = f + 26, Face = f, Suite = "S" };
                Cards.Add(card);
            }

            for (int f = 0; f < 13; f++)
            {
                var card = new Card { Id = f + 39, Face = f, Suite = "D" };
                Cards.Add(card);
            }
            return Cards;
        }

    }
}
