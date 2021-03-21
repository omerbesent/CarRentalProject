using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            UserManager userManager = new UserManager(new EfUserDal());

            //CarTest(carManager);

            //RentalAddTest(rentalManager);   

            //CustomerTest(customerManager); 
        }

        private static void RentalAddTest(RentalManager rentalManager)
        {
            if (rentalManager.GetByCarReturnDateIsNull(2).Data.Count == 0)
            {
                var rental = new Rental
                {
                    CarId = 2,
                    CustomerId = 1,
                    RentDate = DateTime.Now
                };
                var result = rentalManager.Add(rental);
                Console.WriteLine(result.Message);
            }
            else
            {
                Console.WriteLine("Araç kiralamada");
            }
        }

        private static void CarTest(CarManager carManager)
        {
            var result = carManager.GetCarDetails();
            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine("{0} - {1} - {2}-  {3}", car.CarName, car.BrandName, car.ColorName, car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void CustomerTest(CustomerManager customerManager)
        {
            var result = customerManager.GetAll();
            if (result.Success)
            {
                foreach (var customer in result.Data)
                {
                    Console.WriteLine("{0} - {1}", customer.CompanyName, customer.Id);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

         
    }
}
