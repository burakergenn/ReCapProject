using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        IResult Add(User user);
        IResult Update(User user);
        IResult Delete(User user);
        IDataResult<List<User>> GetAll();
        IDataResult<User> GetById(int id);
        IDataResult<List<User>> GetUsersByFirstName(string firstName);
        IDataResult<List<User>> GetUsersByLastName(string lastName);
        IDataResult<User> GetUsersByEmail(string email);
    }
}
