using Lesson_task_3.Enums;
using Lesson_task_3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_task_3.Interface
{
    interface IBookService
    {
        void Add(Book book);
        Book GetById(int id);
        List<Book> GetByGenre(Genre genre);
       


    }
}
