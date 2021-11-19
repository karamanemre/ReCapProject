using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUII
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            //carManager.Add(new Car {Id=3,BrandId=4,ColorId=3,DailyPrice=380,Description="Deneme",ModelYear="2018" });
            brandManager.Add(new Brand { BrandId=2,BrandName="BMW"});
           





        }
    }
}
