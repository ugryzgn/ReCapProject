using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IDataResult<Rental> GetByID(int ID);
        IDataResult<List<Rental>> GetByCarID(int ID);
        IDataResult<List<Rental>> GetByCustomerID(int ID);
        IDataResult<List<Rental>> GetByRentDate(string rentdate);
        IDataResult<List<Rental>> GetByReturnDate(string returndate);
        IDataResult<List<Rental>> GetAll();
        IResult Add(Rental rental);
        IResult Update(Rental rental);
        IResult Delete(Rental rental);
    }
}
