using Lesson_task_2.Exseptions;
using Lesson_task_2.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Lesson_task_2.Models
{
    internal class TaskService : ITaskService
    {
        static List<MyTask> tasks = [];


        public void AddTask(MyTask addtask)
        {
             var excist =GetTask(addtask.Title);
            if (excist != null)
            {
                throw new ConflictException();
            }
            tasks.Add(addtask);
        }

        public MyTask GetTask(string title)
        {
            foreach (var item in tasks)
            {
                if (item.Title==title)
                {
                    return item;
                }
            }
            throw new NotFoundException();
        }
    }
}
