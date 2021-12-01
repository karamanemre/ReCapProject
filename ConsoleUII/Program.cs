using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            UserManager userManager = new UserManager(new EfUserDal());
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            //Console.WriteLine(DateTime.Today);
            //rentalManager.Add(new Rental {Id=2,CarId=1,CustomerId=1,RentDate=DateTime.Now,ReturnDate= DateTime.Now });
            
            rentalManager.DeliverVehicle(new Rental { Id = 1, CarId = 2, CustomerId = 1, RentDate = DateTime.Now, ReturnDate = null });
           
            //customerManager.Add(new Customer { Id = 2,UserId=2,CompanyName="Şirket"});
            //userManager.Add(new User { Id=3,FirstName="Yusuf",LastName="Ulusoy",Email="tt@gmail.com",Password="45"});

            //Console.WriteLine(carManager.GetCarDetails().Message);

            //foreach (var item in carManager.GetAll().Data)
            //{
            //    Console.WriteLine(item.CarName);

            //}
            //brandManager.Delete(new Brand { BrandId = 3, BrandName = "Audi" });
            //carManager.Add(new Car {Id=3,BrandId=4,ColorId=3,DailyPrice=380,Description="Deneme",ModelYear="2018" });
            //brandManager.Add(new Brand { BrandId=3,BrandName="Audi"});






        }
    }
}
