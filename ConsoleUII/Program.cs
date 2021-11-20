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
            
            foreach (var item in carManager.GetCarDetails())
            {
                Console.WriteLine("{0} / {1} / {2} / {3}",item.BrandName,item.CarName,item.ColorName,item.DailyPrice);
                
            }
            //brandManager.Delete(new Brand { BrandId = 3, BrandName = "Audi" });
            //carManager.Add(new Car {Id=3,BrandId=4,ColorId=3,DailyPrice=380,Description="Deneme",ModelYear="2018" });
            //brandManager.Add(new Brand { BrandId=3,BrandName="Audi"});
           





        }
    }
}
