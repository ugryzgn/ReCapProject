using Business.Concrete;
using Core.Entities.Concrete;
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
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            CarManager carManager = new CarManager(new EfCarDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            UserManager userManager = new UserManager(new EfUserDal());


            //AddTest(brandManager);
            //AddTest(carManager);
            //AddTest(colorManager);
            //AddTest(customerManager);
            //AddTest(rentalManager);
            //AddTest(userManager);

            //DeleteTest(brandManager);
            //DeleteTest(carManager);
            //DeleteTest(colorManager);
            //DeleteTest(customerManager);
            //DeleteTest(rentalManager);
            //DeleteTest(userManager);

            //DtoTest(carManager);

            //GetAllTest(brandManager);
            //GetAllTest(colorManager);
            //GetAllTest(carManager);

            //GetByDescriptionTest(carManager);

            //GetByIDTest(brandManager);
            //GetByIDTest(carManager);
            //GetByIDTest(colorManager);

            //UpdateTest(brandManager);
            //UpdateTest(carManager);
            //UpdateTest(colorManager);

            


        }

        //private static void DeleteTest(UserManager userManager)
        //{
        //    var result = userManager.Delete(new User { ID = 1});
        //    Console.WriteLine(result.Message);
        //}

        private static void DeleteTest(RentalManager rentalManager)
        {
            var result = rentalManager.Delete(new Rental { ID = 1 });
            Console.WriteLine(result.Message);
        }

        private static void DeleteTest(CustomerManager customerManager)
        {
            var result = customerManager.Delete(new Customer { ID = 1 });
            Console.WriteLine(result.Message);
        }

        //private static void AddTest(UserManager userManager)
        //{
        //    var result = userManager.Add(new User { ID = 1, FirstName = "Uğur", LastName = "Yazgan", Email = "ugryazgn@gmail.com", Password = "123456" });
        //    Console.WriteLine(result.Message);
        //}

        private static void AddTest(CustomerManager customerManager)
        {
            var result = customerManager.Add(new Customer { ID = 1, UserID = 1, CompanyName = "X" });
            Console.WriteLine(result.Message);
        }

        private static void AddTest(RentalManager rentalManager)
        {
            var result = rentalManager.Add(new Rental { ID = 1, CarID = 1, CustomerID = 1, RentDate = "16.02.2021", ReturnDate = "17.02.2021" });
            Console.WriteLine(result.Message);
        }

        private static void AddTest(BrandManager brandManager)
        {
            var result = brandManager.Add(new Brand { ID = 4, BrandName = "BMW" });
            Console.WriteLine(result.Message);
        }

        private static void AddTest(CarManager carManager)
        {
            var result = carManager.Add(new Car { ID = 37, BrandID = 3, ColorID = 3, DailyPrice = 100, ModelYear = 2019,
                                                  Description = "Manual Shift" });
            Console.WriteLine(result.Message);
        }

        private static void AddTest(ColorManager colorManager)
        {
            var result = colorManager.Add(new Color { ID = 4, ColorName = "Blue" });
            Console.WriteLine(result.Message);
        }
        

        private static void DeleteTest(BrandManager brandManager)
        {
            var result = brandManager.Delete(new Brand { ID = 4 });
            Console.WriteLine(result.Message);
        }

        private static void DeleteTest(CarManager carManager)
        {
            var result = carManager.Delete(new Car { ID = 37 });
            Console.WriteLine(result.Message);
        }

        private static void DeleteTest(ColorManager colorManager)
        {
            var result = colorManager.Delete(new Color { ID = 4 });
            Console.WriteLine(result.Message);
        }

        private static void DtoTest(CarManager carManager)
        {
            var result = carManager.GetCarDetails();
            Console.WriteLine(result.Message);
            Console.WriteLine("\n\nAll Cars:\n\nCar Name\t\tBrand\t\tColor\t\tDaily Price");
            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine($"{car.CarName}\t{car.BrandName}\t{car.ColorName}\t\t{car.DailyPrice}");
                }
            }

        }

        private static void GetAllTest(BrandManager brandManager)
        {
            var result = brandManager.GetAll();
            Console.WriteLine(result.Message);
            Console.WriteLine("\n\nAll Brands: \n\nID\tBrand Name");
            foreach (var brand in result.Data)
            {
                Console.WriteLine($"{brand.ID}\t{brand.BrandName}");
            }
        }

        private static void GetAllTest(CarManager carManager)
        {
            var result = carManager.GetAll();
            Console.WriteLine(result.Message);
            Console.WriteLine("\n\nAll Cars:\n\nId\tColor ID\tDescription\t\tModel Year\tBrand ID\tDaily Price");
            foreach (var car in result.Data)
            {
                Console.WriteLine($"{car.ID}\t{car.ColorID}\t\t{car.Description}\t{car.ModelYear}\t\t{car.BrandID}\t\t{car.DailyPrice}");
            }
        }

        private static void GetAllTest(ColorManager colorManager)
        {
            var result = colorManager.GetAll();
            Console.WriteLine(result.Message);
            Console.WriteLine("\n\nAll Colors: \n\nID\tColor Name");
            foreach (var color in result.Data)
            {
                Console.WriteLine($"{color.ID}\t{color.ColorName}");
            }
        }
        private static void GetByDescriptionTest(CarManager carManager)
        {
            var result = carManager.GetByDescription("Automatic Shift");
            Console.WriteLine(result.Message);
            if (result.Success)
            {
                Console.WriteLine("\n\nAll Cars:\n\nId\tColor ID\tDescription\t\tModel Year\tBrand ID\tDaily Price");
                foreach (var car in result.Data)
                {
                    Console.WriteLine($"{car.ID}\t{car.ColorID}\t\t{car.Description}\t{car.ModelYear}\t\t{car.BrandID}\t\t{car.DailyPrice}");
                }
            }
        }

        private static void GetByIDTest(BrandManager brandManager)
        {
            var result = brandManager.GetByID(3);
            Console.WriteLine(result.Message);
            if (result.Success)
            {
                Console.WriteLine("\n\nBrand that ID=3: \n\nID\tBrand Name");
                var brand = result.Data;
                Console.WriteLine($"{brand.ID}\t{brand.BrandName}");
            }
            
            
            
        }

        private static void GetByIDTest(CarManager carManager)
        {
            var result = carManager.GetByID(27);
            Console.WriteLine(result.Message);
            if (result.Success)
            {
                Console.WriteLine("\n\nCar that ID=27:\n\nId\tColor ID\tDescription\t\tModel Year\tBrand ID\tDaily Price");
                var car = result.Data;
                Console.WriteLine($"{car.ID}\t{car.ColorID}\t\t{car.Description}\t{car.ModelYear}\t\t{car.BrandID}\t\t{car.DailyPrice}");
            }
            
        }

        private static void GetByIDTest(ColorManager colorManager)
        {
            var result = colorManager.GetByID(4);
            Console.WriteLine(result.Message);
            if (result.Success)
            {
                Console.WriteLine("\n\nColor that ID=4: \n\nID\tColor Name");
                var color = result.Data;
                Console.WriteLine($"{color.ID}\t{color.ColorName}");
            }
        }


        private static void UpdateTest(BrandManager brandManager)
        {
            var result = brandManager.Update(new Brand { ID = 3, BrandName = "Renault" });
            Console.WriteLine(result.Message);
        }

        private static void UpdateTest(CarManager carManager)
        {
            var result = carManager.Update(new Car { ID = 27, CarName="Volvo S60", BrandID = 3, ColorID = 1, Description = "Automatic Shift", ModelYear = 2021, DailyPrice = 1000 });
            Console.WriteLine(result.Message);
        }

        private static void UpdateTest(ColorManager colorManager)
        {
            var result = colorManager.Update(new Color { ID = 3, ColorName = "Yellow" });
            Console.WriteLine(result.Message);
        }

    }
}
