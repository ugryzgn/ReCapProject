using Business.Abstract;
using Business.BusinessAspect.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspect.Autofac.Caching;
using Core.Aspect.Autofac.Transaction;
using Core.Aspect.Autofac.Validation;
using Core.Utilities.Business.BusinessRules;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
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

        [SecuredOperation("car.add,admin")]
        [ValidationAspect(typeof(CarValidator))]
        [CacheRemoveAspect("ICarService.Get")]
        public IResult Add(Car car)
        {
            IResult result = BusinessRules.Run(CheckIfCarNameExist(car.CarName));
            if (result!=null)
            {
                return result;
            }
            _carDal.Add(car);
            return new SuccessResult(Messages.CarSuccessAdded);
            
        }

        [TransactionScopeAspect]
        [ValidationAspect(typeof(CarValidator))]
        [SecuredOperation("car.add,admin")]
        [CacheRemoveAspect("ICarService.Get")]
        public IResult AddTransactionTest(Car car)
        {
            IResult result = BusinessRules.Run(CheckIfCarNameExist(car.CarName));
            if (result != null)
            {
                return result;
            }

            Add(car);
            if (car.DailyPrice<100)
            {
                throw new Exception(Messages.TransactionCanceled);
            }
            Add(car);
            return new SuccessResult(Messages.CarSuccessAdded);
        }

        [CacheRemoveAspect("ICarService.Get")]
        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.CarSuccessDeleted);
        }

        [CacheAspect]
        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(),Messages.CarSuccessGetAll);
           
        }

        public IDataResult<List<Car>> GetAllByBrandID(int ID)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.BrandID == ID),Messages.CarSuccessGetBy);
        }

        public IDataResult<List<Car>> GetAllByColorID(int ID)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ColorID == ID), Messages.CarSuccessGetBy);
        }

        public IDataResult<List<Car>> GetByDailyPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c=> c.DailyPrice>=min && c.DailyPrice<=max),Messages.CarSuccessGetBy);
        }

        public IDataResult<List<Car>> GetByDescription(string description)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.Description == description), Messages.CarSuccessGetBy);
        }

        [CacheAspect]
        public IDataResult<Car> GetByID(int ID)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c => c.ID == ID), Messages.CarSuccessGetByID);
        }

        [CacheAspect]
        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(),Messages.CarSuccessDto);
        }

        [ValidationAspect(typeof(CarValidator))]
        [CacheRemoveAspect("ICarService.Get")]
        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(Messages.CarSuccessUpdated);
        }







        //                        ------- Business Codes -----
        private IResult CheckIfCarNameExist(string carName) 
        {
            var result = _carDal.GetAll(c => c.CarName == carName).Any();
            if (result)
            {
                return new ErrorResult(Messages.CarNameAlreadyExist);
            }

            return new SuccessResult();
        }
    }
}
