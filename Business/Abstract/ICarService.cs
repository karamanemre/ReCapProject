using Core.Utilities.DataResults;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        public IResult Add(Car car);
        public IResult Delete(Car car);
        public IResult Uptade(Car car);
        public IDataResult<List<Car>> GetAll();
        public IDataResult<Car> GetById(int id);
        public IDataResult<List<Car>> GetCarsByBrandId(int id);
        public IDataResult<List<Car>> GetCarsByColorId(int id);
        public IDataResult<List<CarDetailDto>> GetCarDetails();


    }
}
