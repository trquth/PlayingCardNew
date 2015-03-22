using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingCardNew
{
    public interface IDeck
    {
        void Shuffle();
        void Reset();
        ICard TakeCard();
        IEnumerable<ICard> TakeCards(int numberOfCards);
    }
}
