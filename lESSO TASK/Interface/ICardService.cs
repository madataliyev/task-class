using lESSO_TASK.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lESSO_TASK.Interface
{
    interface ICardService
    {
        void Add(Card card);
        Card Find (string cardNumber);
    }
}
