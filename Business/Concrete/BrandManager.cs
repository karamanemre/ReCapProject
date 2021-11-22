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
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }
        public IResult Add(Brand brand)
        {
            if (brand.BrandName.Length<2)
            {
                return new ErrorResult(Messages.BrandNameError);
            }
            
            _brandDal.Add(brand);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Brand>> GetAll()
        {
           return new SuccesDataResult<List<Brand>>(_brandDal.GetAll(), Messages.GetData);
        }

        public IDataResult<Brand> GetById(int id)
        {
            return new SuccesDataResult<Brand>(_brandDal.Get(p => p.BrandId == id), Messages.GetData);
        }


        public IResult Uptade(Brand brand)
        {
            _brandDal.Uptade(brand);
            return new SuccessResult(Messages.Uptaded);
        }

        
    }
}
