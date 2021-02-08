using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetAllByBrandID(int ID); 
        List<Car> GetAllByColorID(int ID);
        List<Car> GetByDailyPrice(decimal min, decimal max);
        List<Car> GetByDescription(string description);
        Car GetByID(int ID);
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
    }
}
