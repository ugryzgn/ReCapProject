using Business.Abstract;
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

        public void Add(Car car)
        {
            if (car.DailyPrice>0)
            {
                _carDal.Add(car);
                Console.WriteLine("Car Successfully Added...");
            }
            else
            {
                Console.WriteLine("The price entered must be greater than zero! The price you entered: " + car.DailyPrice);
            }
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
            Console.WriteLine("Car Successfully Deleted...");
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
           
        }

        public List<Car> GetAllByBrandID(int ID)
        {
            return _carDal.GetAll(c => c.BrandID == ID);
        }


        public List<Car> GetAllByColorID(int ID)
        {
            return _carDal.GetAll(c => c.ColorID == ID);
        }



        public List<Car> GetByDailyPrice(decimal min, decimal max)
        {
            return _carDal.GetAll(c=> c.DailyPrice>=min && c.DailyPrice<=max);
        }

        public List<Car> GetByDescription(string description)
        {
            return _carDal.GetAll(c => c.Description == description);
        }

        public Car GetByID(int ID)
        {
            return _carDal.Get(c => c.ID == ID);
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            return _carDal.GetProductDetails();
        }

        public void Update(Car car)
        {
            if (car.DailyPrice > 0)
            {
                _carDal.Update(car);
                Console.WriteLine("Car Successfully Updated...");
            }
            else
            {
                Console.WriteLine("The price entered must be greater than zero! The price you entered: " + car.DailyPrice);
            }
        }
    }
}
