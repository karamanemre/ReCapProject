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
    public class CustomerManager:ICustomerService
    {
        ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

      
        public IResult Add(Customer customer)
        {
            _customerDal.Add(customer);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Customer customer)
        {
            _customerDal.Delete(customer);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccesDataResult<List<Customer>>(_customerDal.GetAll(), Messages.GetData);

        }

        public IDataResult<Customer> GetById(int id)
        {
            return new SuccesDataResult<Customer>(_customerDal.Get(p => p.UserId == id), Messages.GetData);
        }

        public IResult Uptade(Customer customer)
        {
            _customerDal.Uptade(customer);
            return new SuccessResult(Messages.Uptaded);
        }
    }
}
