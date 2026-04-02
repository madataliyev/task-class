using Lesson_task_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_task_2.Interface
{
    interface ITaskService
    {
        MyTask GetTask(string title);
         void AddTask(MyTask addtask);

    }
}
