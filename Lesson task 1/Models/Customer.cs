using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_task_1.Models
{
    internal class Customer
    {
        private  static int _id;
        public int Id { get; set; }
        public string Name { get; set; }
        public string  City   { get; set; }

        public Customer()
        {
            _id++;
            Id = _id;
        }

    }
}
