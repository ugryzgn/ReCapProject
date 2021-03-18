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
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentacarContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentDetails()
        {
            using (RentacarContext context = new RentacarContext())
            {
                var result = from r in context.Rentals
                             join c in context.Cars
                             on r.CarID equals c.ID
                             join cu in context.Customers
                             on r.CustomerID equals cu.ID
                             join u in context.Users
                             on cu.UserID equals u.ID
                             select new RentalDetailDto { ID = r.ID, CarName = c.CarName, FirstName = u.FirstName,
                                 LastName = u.LastName, RentDate = r.RentDate, ReturnDate = r.ReturnDate };
                return result.ToList();
            }
        }
    }
}
