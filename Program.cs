using lESSO_TASK.Enums;
using lESSO_TASK.Models;

namespace lESSO_TASK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Card card1 = new()
            {
                Balance = 2000,
                CardNumber = "5239151795523623",
                Bank = Bank.Kapital
            };
            Card card2 = new()
            {
                Balance = 770,
                CardNumber = "5239151795527777",
                Bank = Bank.Kapital
            };
            Console.WriteLine(card1.ID);
            Console.WriteLine(card2.ID);

            CardService cardService = new();
            cardService.Add(card1);
            cardService.Add(card2);

            Card card3 = new()
            {
                Balance = 109,
                CardNumber = "5239151755557777",
                Bank = Bank.ABB
            };
            cardService.Add(card3);

        }
    }
}
