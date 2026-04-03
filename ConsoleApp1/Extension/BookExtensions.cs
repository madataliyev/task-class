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
    }
}
