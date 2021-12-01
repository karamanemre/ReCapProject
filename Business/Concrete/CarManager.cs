using Business.Abstract;
using Business.Constants;
using Core.Utilities.DataResults;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IResult Add(Car car)
        {
            if (car.DailyPrice<=0)
            {
                Console.WriteLine("Araç Fiyatı 0'dan Küçük Olamaz");
                return new ErrorResult("Ekleme Başarısız"); 
            }
            _carDal.Add(car);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccesDataResult<List<Car>>(_carDal.GetAll(),"Araçlar Listelendi");
        }

        public IDataResult<Car> GetById(int id)
        {
            return new SuccesDataResult<Car>(_carDal.Get(p=>p.Id==id));
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {

            return new SuccesDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(), "İşlem Başarılı");
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int id)
        {
            return new SuccesDataResult<List<Car>>(_carDal.GetAll(p => p.BrandId == id).ToList(),"İşlem Başarılı");
        }

        public IDataResult<List<Car>> GetCarsByColorId(int id)
        {
            return new SuccesDataResult<List<Car>>(_carDal.GetAll(p => p.ColorId == id).ToList(), "Araç Getirildi");
        }

        public IResult Uptade(Car car)
        {
            _carDal.Uptade(car);
            return new SuccessResult(Messages.Uptaded); 
        }
    }
}
