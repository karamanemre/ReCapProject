using Core.Utilities.DataResults;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {
        public IResult Add(Rental rental);
        public IResult Delete(Rental rental);
        public IResult Uptade(Rental rental);
        public IDataResult<List<Rental>> GetAll();
        public IDataResult<Rental> GetById(int id);
        public IResult DeliverVehicle(Rental rental);
    }
}
