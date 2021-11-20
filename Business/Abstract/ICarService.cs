using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        public void Add(Car car);
        public void Delete(Car car);
        public void Uptade(Car car);
        public List<Car> GetAll();
        public List<Car> GetCarsByBrandId(int id);
        public List<Car> GetCarsByColorId(int id);
        public List<CarDetailDto> GetCarDetails();


    }
}
