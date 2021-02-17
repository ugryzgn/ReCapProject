using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
   
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
            new Car{ID=1, ColorID=1, BrandID=1, DailyPrice=150, ModelYear=2020, Description="Manuel Shift"},
            new Car{ID=2, ColorID=1, BrandID=1, DailyPrice=120, ModelYear=2019, Description="Manuel Shift"},
            new Car{ID=3, ColorID=2, BrandID=2, DailyPrice=250, ModelYear=2021, Description="Automatic Shift"},
            new Car{ID=4, ColorID=2, BrandID=3, DailyPrice=200, ModelYear=2020, Description="Automatic Shift"},
            new Car{ID=5, ColorID=3, BrandID=3, DailyPrice=200, ModelYear=2021, Description="Manuel Shift"},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.ID==car.ID);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(c => c.ID == carId).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.ID == car.ID);
            carToUpdate.BrandID = car.BrandID;
            carToUpdate.ColorID = car.ColorID;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;

        }
    }
}
