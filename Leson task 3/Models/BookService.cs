using Lesson_task_3.Enums;
using Lesson_task_3.Exceptions;
using Lesson_task_3.Exseptions;
using Lesson_task_3.Interface;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Lesson_task_3.Models
{
    internal class BookService : IBookService
    {
        private static string _filePath = "C:\\Users\\Classtime.PC_3_506_5\\Desktop\\Task\\ConsoleApp1\\Data.json";

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


        public List<Book>GetByGenre(Genre genre)
        {
            return Books.FindAll(i=>i.Genre == genre);
        }


        public Book GetMostExpensiveBook()
        {
           return Books.MaxBy(i=> i.Price);
            
        }
        
        public Book GetCheapestBook()
        {
           return Books.MinBy(i=> i.Price);
            
        } 
        
        public decimal GetAveragePrice()
        {
          return Books.Average(i=> i.Price);                         

        }

        public int CountByGenre(Genre genre)
        {
            return Books.Count(i=> i.Genre == genre);
        }

        public List<Book> GetByPriceRange(double min, double max)
        {
            return Books.FindAll(i => i.Price > (decimal)min && i.Price < (decimal)max);
        }




        public void WriteToFile()
        {
            using FileStream fileStream = new FileStream(_filePath, FileMode.Create);
            using StreamWriter streamWriter = new StreamWriter(fileStream);

            string json = JsonSerializer.Serialize(Books);
            streamWriter.WriteLine(json);
        }
         public void ReadFromFile()
        {
            using FileStream fileStream = new FileStream(_filePath, FileMode.Open);
            using StreamReader streamReader = new StreamReader(fileStream);

            string json = streamReader.ReadToEnd();
            Books = JsonSerializer.Deserialize<List<Book>>(json);
        }




    }
}
