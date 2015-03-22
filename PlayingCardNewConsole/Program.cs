using PlayingCardNew;
using PlayingCardNew.Standard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingCardNewConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            IDeck MyCard = new Deck();
            MyCard.Shuffle();

            var Card = MyCard.TakeCard() as Card;
            System.Console.WriteLine("La bai vua rut la {0} {1}", Card.CardNumber.ToString(), Card.Suit.ToString());

            System.Console.ReadLine();
        }
    }
}
