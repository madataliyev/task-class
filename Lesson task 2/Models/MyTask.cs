using Lesson_task_2.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_task_2.Models
{
    internal class MyTask
    {
        private static int  _id;
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public DateTime DeadLine { get; set; }
        public MyTaskStatus TaskStatus { get; set; }

        public MyTask()
        {
            _id++;
            Id = _id;
             Created = DateTime.Now;
        }
        public override string ToString()
        {
            return $"Id= {Id},  basliq = {Title}, Izahat= {Description}";
        }


    }

   
}
