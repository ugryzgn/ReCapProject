using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspect.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        [ValidationAspect(typeof(CustomerValidator))]
        public IResult Add(Customer customer)
        {
            _customerDal.Add(customer);
            return new SuccessResult(Messages.CustomerSuccessAdded);
        }

        public IResult Delete(Customer customer)
        {
            _customerDal.Delete(customer);
            return new SuccessResult(Messages.CustomerSuccessDeleted);
        }

        public IDataResult<Customer> GetByID(int ID)
        {
            return new SuccessDataResult<Customer>(_customerDal.Get(cu=>cu.ID==ID),Messages.CustomerSuccessGetByID);
        }
        
        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(),Messages.CustomerSuccessGetAll);
        }

        public IDataResult<List<Customer>> GetByCompanyName(string companyName)
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(cu=>cu.CompanyName==companyName), Messages.CustomerSuccessGetBy);
        }
                
        public IDataResult<Customer> GetByUserID(int ID)
        {
            return new SuccessDataResult<Customer>(_customerDal.Get(cu=> cu.UserID== ID),Messages.CustomerSuccessGetByID);
        }

        [ValidationAspect(typeof(CustomerValidator))]
        public IResult Update(Customer customer)
        {
            _customerDal.Update(customer);
            return new SuccessResult(Messages.CustomerSuccessUpdated);
        }
    }
}
