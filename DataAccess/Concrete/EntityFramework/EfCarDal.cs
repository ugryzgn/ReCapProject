using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentacarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (RentacarContext context=new RentacarContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandID equals b.ID
                             join co in context.Colors
                             on c.ColorID equals co.ID
                             select new CarDetailDto {CarName=c.CarName, BrandName=b.BrandName,
                                                          ColorName=co.ColorName, DailyPrice=c.DailyPrice };
                return result.ToList();
            }
        }
    }
}
