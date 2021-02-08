using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void Add(Brand brand)
        {
            if (brand.BrandName.Length >= 2)
            {
                _brandDal.Add(brand);
                Console.WriteLine("Brand Successfully Added...");
            }
            else
            {
                Console.WriteLine("The brand name entered must be at least two characters! The value you entered: " + brand.BrandName);
            }
        }

        public void Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            Console.WriteLine("Brand Successfully Added...");
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public Brand GetByID(int ID)
        {
            return _brandDal.Get(b => b.ID == ID);
        }

        public void Update(Brand brand)
        {
            if (brand.BrandName.Length >= 2)
            {
                _brandDal.Update(brand);
                Console.WriteLine("Brand Successfully Updated...");
            }
            else
            {
                Console.WriteLine("The brand name entered must be at least two characters! The length of value you entered: " + brand.BrandName.Length);
            }
        }
    }
}
