using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<User> GetByID(int ID);
        IDataResult<List<User>> GetByFirstName(string name);
        IDataResult<List<User>> GetByLastName(string lastname);
        IDataResult<User> GetByEmail(string email);
        IDataResult<List<User>> GetAll();        
        IResult Add(User user);
        IResult Update(User user);
        IResult Delete(User user);
    }
}
