using Lesson_task_1.Enums;
using Lesson_task_1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_task_1.Models
{
    internal class CargoOrder
    {
        private static int _id;
        public int Id { get; set; }

        public int CustomerId { get; set; }
        public int CourierId { get; set; }

        public decimal TotalPrice { get; set; }

        public DateTime CreatedAt { get; set; }

        public OrderStatus Status { get; set; }

       

        public CargoOrder()
        {
            _id++;
            Id = _id;

            CreatedAt = DateTime.Now;

            Status = OrderStatus.Created;

        }
        public void UpdateStatus(OrderStatus newStatus)
        {
            if (Status==OrderStatus.Delivered || Status==OrderStatus.Cancelled)
            {
                Console.WriteLine("Status deyismek mumkun olmadi ");

            }
            

        }
    }
}
