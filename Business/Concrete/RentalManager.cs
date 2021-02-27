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
    public class RentalManager : IRentalService
    {
        IRentalDal _rentaldal;

        public RentalManager(IRentalDal rentaldal)
        {
            _rentaldal = rentaldal;
        }

        [ValidationAspect(typeof(RentalValidator))]
        public IResult Add(Rental rental)
        {
            _rentaldal.Add(rental);
            return new SuccessResult(Messages.CustomerSuccessAdded);
        }

        public IResult Delete(Rental rental)
        {
            _rentaldal.Delete(rental);
            return new SuccessResult(Messages.CustomerSuccessDeleted);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentaldal.GetAll(),Messages.CustomerSuccessGetAll);
        }

        public IDataResult<List<Rental>> GetByCarID(int ID)
        {
            return new SuccessDataResult<List<Rental>>(_rentaldal.GetAll(r => r.CarID == ID), Messages.CustomerSuccessGetBy);
        }

        public IDataResult<List<Rental>> GetByCustomerID(int ID)
        {
            return new SuccessDataResult<List<Rental>>(_rentaldal.GetAll(r => r.CustomerID == ID), Messages.CustomerSuccessGetBy);
        }

        public IDataResult<Rental> GetByID(int ID)
        {
            return new SuccessDataResult<Rental>(_rentaldal.Get(r=>r.ID==ID),Messages.CustomerSuccessGetByID);
        }

        public IDataResult<List<Rental>> GetByRentDate(string rentdate)
        {
           return new SuccessDataResult<List<Rental>>(_rentaldal.GetAll(r => r.RentDate == rentdate), Messages.CustomerSuccessGetBy);
        }

        public IDataResult<List<Rental>> GetByReturnDate(string returndate)
        {
            return new SuccessDataResult<List<Rental>>(_rentaldal.GetAll(r => r.ReturnDate == returndate), Messages.CustomerSuccessGetBy);
        }

        [ValidationAspect(typeof(RentalValidator))]
        public IResult Update(Rental rental)
        {
            _rentaldal.Update(rental);
            return new SuccessResult(Messages.CustomerSuccessUpdated);
        }
    }
}
