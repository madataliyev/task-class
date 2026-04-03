using Lesson_task_3.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_task_3.Models
{
    internal class Book
    {
        private static int _id;
        public int ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int PageCount { get; set; }
        public decimal Price { get; set; }
        public int StockCount { get; set; }
        public Genre Genre { get; set; }
        public DateTime CreatedAt { get; set; }

        public Book()
        {
            _id++;
            ID = _id;
            CreatedAt = DateTime.Now;
        }
        public override string ToString()
        {
            return $"{ID} , {Title}";
        }
    }
    
}
