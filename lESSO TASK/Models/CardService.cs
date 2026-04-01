using lESSO_TASK.Exseption;
using lESSO_TASK.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lESSO_TASK.Models
{
    internal class CardService:ICardService
    {
        public static Card[]Cards=[];

        public void Add(Card card)
        {
            var exsist = Find(card.CardNumber);
            if (exsist == null)
            {
                Array.Resize( ref Cards , Cards .Length+1 );
                Cards[Cards.Length - 1] = card;
            }
            else
            {
               throw new ConflictException("Bu nomre ile kart var ");   
            }

        }

        public Card Find(string cardNumber)
        {
            foreach (var item  in Cards)
            {
                if (item.CardNumber==cardNumber)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
