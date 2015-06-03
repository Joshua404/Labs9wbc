using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlackJackApp
{
    public class Game
    {
        public Game()
        {
            Deck = CreateDeckasList();
        }

        public List<Card> Deck { get; set; }

        public List<Card> CreateDeckasList()
        {
            var Cards = new List<Card>();
            for (int f = 0; f < 13; f++)
            {
                var card = new Card { Id = f, Face = f, Suite = '♥' };
                Cards.Add(card);
            }

            for (int f = 0; f < 13; f++)
            {
                var card = new Card { Id = f + 13, Face = f, Suite = '♣' };
                Cards.Add(card);
            }

            for (int f = 0; f < 13; f++)
            {
                var card = new Card { Id = f + 26, Face = f, Suite = '♠' };
                Cards.Add(card);
            }

            for (int f = 0; f < 13; f++)
            {
                var card = new Card { Id = f + 39, Face = f, Suite = '♦' };
                Cards.Add(card);
            }
            return Cards;
        }

        public List<Card> DealNewHand()
        {
            const int cardsInHand = 2;
            var rnd = new Random();
            var hand = new List<Card>();
            var temp = new Card();


            for (int f = 0; f < cardsInHand; f++ )
            {
                temp = Deck[rnd.Next(Deck.Count)];
                hand.Add(temp);
                Deck.Remove(temp);


            }

            return hand;
        }

        public int GetHandValue(List<Card> hand)
        {

            var sum = 0;
            var numAces = 0;

            foreach (var card in hand)
            {
                if (card.Face == 0 || card.Face == 11 || card.Face == 12)
                { sum += 10; }

                else if (card.Face == 1)
                {
                    sum += 11;
                    numAces++;
                }

                else

                    sum += card.Face;
            }
            for(int f = 0; f < numAces; f++)
            {
                if(sum > 21)
                   sum -=10;

            }
            return sum;
       
        }



        public List<Card> Hit(List<Card> hand)
        {
            var rnd = new Random();
            var temp = Deck[rnd.Next(Deck.Count)];

            hand.Add(temp);
            Deck.Remove(temp);


            return hand;
        }




        public void PlayGame()
        {


            var rnd = new Random();
            List<Card> deck = CreateDeckasList();
            var playerBusts = false;
            var dealerBusts = false;


            Console.WriteLine("Welcome to BlackJack.......");


            var playerHand = DealNewHand();
            var dealerHand = DealNewHand();

            Console.Write("The Dealers hand ");
            foreach (var card in dealerHand)
            {
                Console.Write(card);
            }


            while (true)
            {
                
                Console.Write(" Your hand ");
                foreach (var card in playerHand)
                {
                    Console.Write(card);
                }
                if (playerBusts)
                {
                    Console.WriteLine("You busted");
                    break;
                }

                Console.WriteLine(" You want to hit? [y/n]");
                var response = Console.ReadLine();

                if (response == "y")
                    playerHand = Hit(playerHand);

                else if (response == "n")
                    break;

                else
                    Console.WriteLine("Please enter 'y' or 'n'");

                
                if (GetHandValue(playerHand) >= 22)
                {
                    playerBusts = true;
                }
            }

            Console.WriteLine("You have {0} points in your hand", GetHandValue(playerHand));


            
            while (!playerBusts)
            {
                Console.Write("The Dealers hand ");
                foreach (var card in dealerHand)
                {
                    Console.Write(card);
                }

                if (GetHandValue(dealerHand) < 17)
                {
                    Console.Write("The Dealer hits ");
                    dealerHand = Hit(dealerHand);
                }
                else if (GetHandValue(dealerHand) > 21)
                {
                    Console.WriteLine("The Dealer busts, You win");
                    dealerBusts = true;
                    break;
                }
                else
                {
                    Console.WriteLine("The Dealer stays");
                    break;
                }
            }

            
            if (!dealerBusts && !playerBusts)
            {

                var endPlayerValue = GetHandValue(playerHand);
                var endDealerValue = GetHandValue(dealerHand);

                Console.WriteLine(" Your hand has {0} points, the Dealer's hand has {1} points ", endPlayerValue, endDealerValue);

                if (endPlayerValue > endDealerValue || dealerBusts)
                    Console.WriteLine("You won");
                else
                    Console.WriteLine("You lost");
            }


        }
    }
}