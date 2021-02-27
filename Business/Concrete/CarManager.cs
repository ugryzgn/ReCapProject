using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspect.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
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

        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car car)
        {
            if (car.DailyPrice<0)
            {
                return new ErrorResult(Messages.CarErrorAdded);
            }
            _carDal.Add(car);
            return new SuccessResult(Messages.CarSuccessAdded);
            
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.CarSuccessDeleted);
        }

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

        public IDataResult<Car> GetByID(int ID)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c => c.ID == ID), Messages.CarSuccessGetByID);
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(),Messages.CarSuccessDto);
        }

        [ValidationAspect(typeof(CarValidator))]
        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(Messages.CarSuccessUpdated);   
        }
    }
}
