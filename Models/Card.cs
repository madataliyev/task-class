using lESSO_TASK.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lESSO_TASK.Models
{
    internal class Card
    {
        private static int id;
        public int ID { get; set; }
        public decimal Balance { get; set; }
        public int Bonus { get; set; }
        public string CardNumber { get; set; }
        public Bank Bank { get ; set; }

        public Card()
        {
            id++;
            ID = id;
        }



        public bool WithDraw(decimal Amount )
        {
            if (Balance>=Amount)
            {
                Balance -= Amount; 
                return true;
            }
            return false;
        }
        

    }
}
