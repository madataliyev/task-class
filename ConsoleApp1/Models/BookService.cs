using Lesson_task_3.Enums;
using Lesson_task_3.Exceptions;
using Lesson_task_3.Exseptions;
using Lesson_task_3.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Lesson_task_3.Models
{
    internal class BookService : IBookService
    {

        public static List<Book> Books = [];
        public void Add(Book book)
        {
            var exsistBook = Books.Find(x => x.Title == book.Title);
            if (exsistBook == null)
            {
                Books.Add(book);
            }
            else
            {
                throw new ConflictException();
            }
            
        }
       
        public Book GetById(int id)
        {
            var existId = Books.Find(i => i.ID == id);
            if (existId == null)
            {
                throw new NotFoundException();

            }
            return existId;
        }

        
    
    }
}
