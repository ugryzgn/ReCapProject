using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());


            //AddTest(brandManager);
            //AddTest(carManager);
            //AddTest(colorManager);

            //GetAllTest(brandManager);
            //GetAllTest(colorManager);
            //GetAllTest(carManager);

            //GetByIDTest(brandManager);
            //GetByIDTest(carManager);
            //GetByIDTest(colorManager);

            //DeleteTest(brandManager);
            //DeleteTest(carManager);
            //DeleteTest(colorManager);

            //UpdateTest(brandManager);
            //UpdateTest(carManager);
            //UpdateTest(colorManager);

            DtoTest(carManager);
            
        }

        private static void DtoTest(CarManager carManager)
        {
            Console.WriteLine("\n\nAll Cars:\n\nCar Name\t\tBrand\t\tColor\t\tDaily Price");
            foreach (var car in carManager.GetProductDetails())
            {
                Console.WriteLine($"{car.CarName}\t{car.BrandName}\t{car.ColorName}\t\t{car.DailyPrice}");
            }
        }

        private static void AddTest(BrandManager brandManager)
        {
            brandManager.Add(new Brand { ID = 4, BrandName = "BMW" });
        }

        private static void AddTest(CarManager carManager)
        {
            carManager.Add(new Car { ID = 37, BrandID = 3, ColorID = 3, DailyPrice = 100, ModelYear = 2019, Description = "Manual Shift" });
        }

        private static void AddTest(ColorManager colorManager)
        {
            colorManager.Add(new Color { ID = 4, ColorName = "Blue" });
        }
        

        private static void DeleteTest(BrandManager brandManager)
        {
            brandManager.Delete(new Brand { ID = 4 });
        }

        private static void DeleteTest(CarManager carManager)
        {
            carManager.Delete(new Car { ID = 37 });
        }

        private static void DeleteTest(ColorManager colorManager)
        {
            colorManager.Delete(new Color { ID = 4 });
        }


        private static void GetAllTest(BrandManager brandManager)
        {
            Console.WriteLine("\n\nAll Brands: \n\nID\tBrand Name");
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine($"{brand.ID}\t{brand.BrandName}");
            }
        }

        private static void GetAllTest(CarManager carManager)
        {
            Console.WriteLine("\n\nAll Cars:\n\nId\tColor ID\tDescription\t\tModel Year\tBrand ID\tDaily Price");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine($"{car.ID}\t{car.ColorID}\t\t{car.Description}\t{car.ModelYear}\t\t{car.BrandID}\t\t{car.DailyPrice}");
            }
        }

        private static void GetAllTest(ColorManager colorManager)
        {
            Console.WriteLine("\n\nAll Colors: \n\nID\tColor Name");
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine($"{color.ID}\t{color.ColorName}");
            }
        }

        private static void GetByIDTest(BrandManager brandManager)
        {
            Console.WriteLine("\n\nBrand that ID=3: \n\nID\tBrand Name");
            Brand brand = brandManager.GetByID(3);
            Console.WriteLine($"{brand.ID}\t{brand.BrandName}");
        }

        private static void GetByIDTest(CarManager carManager)
        {
            Console.WriteLine("\n\nCar that ID=27:\n\nId\tColor ID\tDescription\t\tModel Year\tBrand ID\tDaily Price");
            Car car = carManager.GetByID(27);
            Console.WriteLine($"{car.ID}\t{car.ColorID}\t\t{car.Description}\t{car.ModelYear}\t\t{car.BrandID}\t\t{car.DailyPrice}");
        }

        private static void GetByIDTest(ColorManager colorManager)
        {
            Console.WriteLine("\n\nColor that ID=4: \n\nID\tColor Name");
            Color color = colorManager.GetByID(4);
            Console.WriteLine($"{color.ID}\t{color.ColorName}");
        }


        private static void UpdateTest(BrandManager brandManager)
        {
            brandManager.Update(new Brand { ID = 3, BrandName = "Renault" });
        }

        private static void UpdateTest(CarManager carManager)
        {
            carManager.Update(new Car { ID = 27, CarName="Volvo S60", BrandID = 3, ColorID = 1, Description = "Automatic Shift", ModelYear = 2021, DailyPrice = 1000 });
        }

        private static void UpdateTest(ColorManager colorManager)
        {
            colorManager.Update(new Color { ID = 3, ColorName = "Yellow" });
        }

    }
}
