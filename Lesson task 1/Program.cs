using Lesson_task_1.Models;

namespace Lesson_task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer() { Name = "Elvin", City = "Baki"};
            Customer customer1= new Customer() { Name = "Elcin", City = "Baki"};



            Courier Courier = new Courier() { Name = "Eli", IsAvailable= true};
            Courier Courier1 = new Courier() { Name = "Veli", IsAvailable = true };



            CargoOrder cargoOrder = new CargoOrder() {CustomerId=2, CourierId=2};


            CargoServis cargoServis = new CargoServis();
            cargoServis.AddCustomer(customer);
            cargoServis.AddCustomer(customer1);

            cargoServis.AddCourier(Courier);
            cargoServis.AddCourier(Courier1);

            cargoServis.CreateOrder(cargoOrder);




        }
    }
}
