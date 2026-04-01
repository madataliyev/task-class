using Lesson_task_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_task_1.Interface
{
    internal interface ICargoService 
    {

        void AddCustomer(Customer newCustomer);
        void AddCourier(Courier newCourier);

        void CreateOrder(CargoOrder newCargo);

        void CompleteOrder(int Id);



    }
}
