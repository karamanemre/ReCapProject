using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

        public void Add(Car entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Car entity)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Uptade(Car entity)
        {
            throw new NotImplementedException();
        }
    }
}
