using Lesson_task_1.Enums;
using Lesson_task_1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_task_1.Models
{
    internal class CargoServis : ICargoService
    {
        public static Customer[] Customers=[];
        public static Courier[] Couriers=[];
        public static CargoOrder[] CargoOrders=[];

        public void AddCourier(Courier newCourier)
        {
          Array.Resize(ref Couriers, Couriers.Length+1);
            Couriers[Couriers.Length-1] = newCourier;
        }

        public void AddCustomer(Customer newCustomer)
        {
            Array.Resize(ref Customers, Customers.Length + 1);
            Customers[Customers.Length - 1] = newCustomer;
        }

        public void CompleteOrder(int Id)
        {
            CargoOrder exsistOrder=null;
            foreach (var Order in CargoOrders)
            {
                if (Order.Id==Id)
                {
                    exsistOrder=Order;

                }
            }
            if (exsistOrder!=null)
            {
                exsistOrder.UpdateStatus(OrderStatus.Delivered);
                foreach (var courier in Couriers)
                {
                    if (courier.Id==exsistOrder.CourierId)
                    {
                        courier.IsAvailable = true;
                    }
                }
            }


        }

        public void CreateOrder(CargoOrder newCargo)
        {
            Customer existCustomer=null;
            foreach (var customer in Customers)
            {
                if (customer.Id==newCargo.CustomerId)
                {
                    existCustomer = customer;
                }
            }
            if (existCustomer==null)
            {
                Console.WriteLine("Istifadeci tapilmadi :( ");
            } 



            Courier existCourier=null;
            foreach (var Courier in Couriers)
            {
                if (Courier.Id==newCargo.CourierId)
                {
                    existCourier = Courier;
                }
            }

            if (existCourier == null)
            {
                Console.WriteLine("Kuryer tapilmadi :( ");
            }

            if (existCourier.IsAvailable)
            {
                existCourier.IsAvailable=false;
                Array.Resize(ref CargoOrders, CargoOrders.Length + 1);
                CargoOrders[CargoOrders.Length - 1] = newCargo;

            }



        }

        internal void AddCustomer(object customer2)
        {
            throw new NotImplementedException();
        }
    }
}
