using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingCardNew.Standard
{
    public class Deck: IDeck
    {
        public Deck()
        {
            Reset();
        }
        public List<Card> Cards { get; set; }
        /// <summary>
        /// Xao tron bai mot cach ngau nhien bang LINQ
        /// </summary>
        public void Shuffle()
        {
            Cards = Cards.OrderBy(c => Guid.NewGuid()).ToList();
        }
        /// <summary>
        /// Dung o ham khoi tao cua bo bai de tao ra bo bai 52 la
        /// </summary> 
        public void Reset()
        {
            Cards = Enumerable.Range(1, 4).SelectMany(s => Enumerable.Range(1, 13).Select(c => new Card()
            {
                Suit = (Suit)s,
                CardNumber = (CardNumber)c

            })).ToList();
        }
        /// <summary>
        /// Lay mot la bai tu bo bai roi tra ve. Dong thoi, no se 
        /// bo la bai ra khoi bo bai de k bi lay lai nua
        /// </summary>
        /// <returns>Tra ve mot la bai tu bo bai, Neu k co bai trong bo bai se tra ve null</returns>
        public ICard TakeCard()
        {
            var card = Cards.FirstOrDefault();
            Cards.Remove(card);
            return card;
        }
        /// <summary>
        /// Tuong tu nhu TakeCard nhung se lay nhieu hon mot la bai
        /// </summary>
        /// <param name="cards"></param>
        /// <returns>Tra ve so muon lay la bai tu bo bai, Neu k co bai trong bo bai se tra ve null</returns>
        public IEnumerable<ICard> TakeCards(int numberOfCards)
        {
            var cards = Cards.Take(numberOfCards);
            var takeCards = cards as Card[] ?? cards.ToArray();
            Cards.RemoveAll(takeCards.Contains);
            return takeCards;
        }
    }
}
