using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspect.Autofac.Validation;
using Core.Utilities.Business.BusinessRules;
using Core.Utilities.Helpers;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;

        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }

        [ValidationAspect(typeof(CarImageValidator))]
        public IResult Add(IFormFile file, CarImage carImage)
        {
            IResult result = BusinessRules.Run(CheckIfImagesOfCarLimitExceeded(carImage.CarID));
            if (result != null)
            {
                return result;
            }

            carImage.ImagePath = FileHelper.Add(file);
            carImage.Date = DateTime.Now;
            _carImageDal.Add(carImage);
            return new SuccessResult(Messages.CarImageSuccessAdded);
        }

       
        public IResult Delete(CarImage carImage)
        {
            FileHelper.Delete(carImage.ImagePath);
            _carImageDal.Delete(carImage);
            return new SuccessResult(Messages.CarImageSuccessDeleted);
        }


        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll());
        }

        public IDataResult<List<CarImage>> GetByCarID(int carid)
        {
            CheckIfCarImageNull(carid);
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(p => p.CarID == carid));
        }

        public IDataResult<CarImage> GetByID(int id)
        {
            return new SuccessDataResult<CarImage>(_carImageDal.Get(ci => ci.ID == id));
        }

        [ValidationAspect(typeof(CarImageValidator))]
        public IResult Update(IFormFile file, CarImage carImage)
        {
            IResult result = BusinessRules.Run(CheckIfImagesOfCarLimitExceeded(carImage.CarID));
            if (result != null)
            {
                return result;
            }
            carImage.ImagePath = FileHelper.Update(_carImageDal.Get(ci => ci.ID == carImage.ID).ImagePath, file);
            carImage.Date = DateTime.Now;
            _carImageDal.Update(carImage);
            return new SuccessResult(Messages.CarImageSuccessUpdated);
        }








        //                        ------- Business Codes -----
        private IResult CheckIfImagesOfCarLimitExceeded(int carid)
        {
            var result = _carImageDal.GetAll(ci => ci.CarID == carid).Count();
            if (result >= 5)
            {
                return new ErrorResult(Messages.ImagesOfCarLimitExceeded);
            }
            return new SuccessResult();
        }

        private List<CarImage> CheckIfCarImageNull(int id)
        {
            string path = @"C:\Users\Ugur\source\repos\ReCapProject\WebAPI\Images\CarImages\default.jpg";
            var result = _carImageDal.GetAll(c => c.CarID == id).Any();
            if (!result)
            {
                return new List<CarImage> { new CarImage { CarID = id, ImagePath = path, Date = DateTime.Now } };
            }
            return null;
        }

       
    }
}
