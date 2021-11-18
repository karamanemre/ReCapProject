using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;

        public InMemoryCarDal()
        {
            _car = new List<Car> { new Car { Id = 1, BrandId = 1, ColorId = 5, ModelYear = "2021", DailyPrice = 100, Description = "Test" },
                new Car { Id = 2, BrandId = 3, ColorId = 4, ModelYear = "2026", DailyPrice = 320, Description = "Deneme" } };
        }

        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car carDelete = _car.SingleOrDefault(p => p.Id == car.Id);
            _car.Remove(carDelete);
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetById(int Id)
        {
           
            return _car.Where(p => p.Id == Id).ToList(); ;
        }

        public void Uptade(Car car)
        {
            Car carUptade = _car.SingleOrDefault(p=>p.Id==car.Id);
            carUptade.Id = car.Id;
            carUptade.BrandId = car.BrandId;
            carUptade.ColorId = car.ColorId;
            carUptade.ModelYear = car.ModelYear;
            carUptade.DailyPrice = car.DailyPrice;
            carUptade.Description = car.Description;
        }
    }
}
