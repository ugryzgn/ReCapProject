﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
   
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
            new Car{CarId=1, ColorId=1, BrandId=1, DailyPrice=150, ModelYear=2020, Description="Manuel Shift"},
            new Car{CarId=2, ColorId=1, BrandId=1, DailyPrice=120, ModelYear=2019, Description="Manuel Shift"},
            new Car{CarId=3, ColorId=2, BrandId=2, DailyPrice=250, ModelYear=2021, Description="Automatic Shift"},
            new Car{CarId=4, ColorId=2, BrandId=3, DailyPrice=200, ModelYear=2020, Description="Automatic Shift"},
            new Car{CarId=5, ColorId=3, BrandId=3, DailyPrice=200, ModelYear=2021, Description="Manuel Shift"},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.CarId==car.CarId);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(c => c.CarId == carId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;

        }
    }
}
