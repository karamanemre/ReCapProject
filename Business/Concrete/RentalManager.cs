using Business.Abstract;
using Business.Constants;
using Core.Utilities.DataResults;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }
        public IResult Add(Rental rental)
        {
            var result = _rentalDal.Get(p=>p.CustomerId==rental.CustomerId);
            if (result.ReturnDate==null)
            {
                return new ErrorResult(Messages.IsCarDeliverVehicleFalse);
                Console.WriteLine("olmaazz");
            }

            if (rental.RentDate < DateTime.Today)
            {
                return new ErrorResult("Kiralama Tarihi Geriye Dönük Olamaz");
            }

            rental.ReturnDate = null;
            _rentalDal.Add(rental);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.Deleted);
        }

        public IResult DeliverVehicle(Rental rental)
        {
            var result = _rentalDal.Get(p=>p.Id==rental.Id);
            result.ReturnDate = DateTime.Now;
            _rentalDal.Uptade(result);
            return new SuccessResult(Messages.CarDeliverVehicle);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccesDataResult<List<Rental>>(_rentalDal.GetAll(),Messages.GetData);
        }

        public IDataResult<Rental> GetById(int id)
        {
            return new SuccesDataResult<Rental>(_rentalDal.Get(p=>p.Id==id),Messages.GetData);
        }

        public IResult Uptade(Rental rental)
        {
            _rentalDal.Uptade(rental);
            return new SuccessResult(Messages.Uptaded);
        }
    }
}
