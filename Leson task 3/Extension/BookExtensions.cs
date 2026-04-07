using Lesson_task_3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_task_3.Extension
{
    internal static  class BookExtensions
    {
        public static  string GetShortInfo( Book book)
        {
            return $"{book.Title},  {book.Author},  {book.Price}"; 
        }

        public static decimal ApplyDiscount(this Book book, double percent)
        {
            return book.Price - book.Price * (decimal)percent / 100;
        }

        public static bool IsInStock(this Book book)
        {
            return book.StockCount > 0;
        }
    }
}
