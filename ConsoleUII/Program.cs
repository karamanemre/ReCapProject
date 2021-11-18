using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUII
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            //carManager.Add(new Car() { Id = 3, BrandId = 8, ColorId = 10, ModelYear = "2005", DailyPrice = 50, Description = "Eklendi" });

            //foreach (var item in carManager.GetAll())
            //{
            //    Console.WriteLine(item.Description);
            //}



            //carmanager.delete(new car() { ıd = 1, brandıd = 8, colorıd = 10, modelyear = "2005", dailyprice = 50, description = "silindi" });

            //foreach (var item in carmanager.getall())
            //{
            //    console.writeline(item.description);
            //}

            //foreach (var item in carManager.GetAll())
            //{
            //    Console.WriteLine(item.ModelYear);
            //}

            //carManager.Uptade(new Car() { Id = 2, BrandId = 8, ColorId = 10, ModelYear = "2006", DailyPrice = 50, Description = "Güncellendi" });

            //foreach (var item in carManager.GetAll())
            //{
            //    Console.WriteLine(item.ModelYear);
            //}




            foreach (var item in carManager.GetById(1))
            {
                Console.WriteLine(item.ModelYear);
            }

        }
    }
}
