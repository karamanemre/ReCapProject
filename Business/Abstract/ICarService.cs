using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        public List<Car> GetAll();
        public List<Car> GetById(int Id);
        public void Add(Car car);
        public void Delete(Car car);
        public void Uptade(Car car);
    }
}
