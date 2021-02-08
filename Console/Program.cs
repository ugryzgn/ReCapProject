using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car {ID=37, BrandID=2, ColorID=1, DailyPrice=-250, ModelYear=2021, Description="Automatic Shift" });

            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Add(new Brand { ID = 4, BrandName = "U" });

            ColorManager colorManager = new ColorManager(new EfColorDal());

            System.Console.WriteLine("\n\nCars that ID=27:\n\nID\tColor Name\tDescription\t\tModel Year\tBrand Name\tDaily Price");
            Car carByID = carManager.GetByID(27);
            System.Console.WriteLine($"{carByID.ID}\t{colorManager.GetByID(carByID.ColorID).ColorName}\t\t{carByID.Description}\t{carByID.ModelYear}\t\t{brandManager.GetByID(carByID.BrandID).BrandName}\t{carByID.DailyPrice}");


            System.Console.WriteLine("\n\nCars that BrandID=2:\n\nId\tColor Name\tDescription\t\tModel Year\tBrand Name\tDaily Price");
            foreach (var car in carManager.GetAllByBrandID(2))
            {
                System.Console.WriteLine($"{car.ID}\t{colorManager.GetByID(car.ColorID).ColorName}\t\t{car.Description}\t{car.ModelYear}\t\t{brandManager.GetByID(car.BrandID).BrandName}\t{car.DailyPrice}");
            }


            System.Console.WriteLine("\n\nCars that ColorID=2:\n\nId\tColor Name\tDescription\t\tModel Year\tBrand Name\tDaily Price");
            foreach (var car in carManager.GetAllByColorID(2))
            {
                System.Console.WriteLine($"{car.ID}\t{colorManager.GetByID(car.ColorID).ColorName}\t\t{car.Description}\t{car.ModelYear}\t\t{brandManager.GetByID(car.BrandID).BrandName}\t{car.DailyPrice}");
            }


            System.Console.WriteLine("\n\nCars that daily price between 200 with 400:\n\nId\tColor Name\tDescription\t\tModel Year\tBrand Name\tDaily Price");
            foreach (var car in carManager.GetByDailyPrice(200,400))
            {
                System.Console.WriteLine($"{car.ID}\t{colorManager.GetByID(car.ColorID).ColorName}\t\t{car.Description}\t{car.ModelYear}\t\t{brandManager.GetByID(car.BrandID).BrandName}\t{car.DailyPrice}");
            }


        }
    }
}
