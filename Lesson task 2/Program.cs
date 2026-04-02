using Lesson_task_2.Models;

namespace Lesson_task_2
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            MyTask task = new MyTask()
            {
                Title = "Task 1",
                Description = "This is first task. ",
                DeadLine = DateTime.Now.AddDays(1),
               

            };
           

            TaskService taskService = new TaskService();
            try
            {
                taskService.GetTask(" :)  ");
                Console.WriteLine("Task added successfully");
            }
            catch (Exception)
            {

                Console.WriteLine("Task tapilmadi :(  ");
            }

            
        }
    }
}
