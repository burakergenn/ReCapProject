using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userdal)
        {
            _userDal = userdal;
        }

        public IResult Add(User user)
        {
            if (user.FirstName.Length<2)
            {
                return new ErrorResult();
            }
            _userDal.Add(user);
            return new SuccessResult(Messages.UserAdded);
        }

        public IResult Delete(User user)
        {
            _userDal.Delete(user);
            return new SuccessResult();
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll());
        }

        public IDataResult<User> GetById(int id)
        {
            return new SuccessDataResult<User>(_userDal.Get(p => p.Id == id));
        }

        public IDataResult<User> GetUsersByEmail(string email)
        {
            return new SuccessDataResult<User>(_userDal.Get(p => p.Email == email));
        }

        public IDataResult<List<User>> GetUsersByLastName(string lastName)
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(p => p.LastName == lastName));
        }

        public IDataResult<List<User>> GetUsersByFirstName(string firstName)
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(p => p.FirstName == firstName));
        }

        public IResult Update(User user)
        {
            _userDal.Update(user);
            return new SuccessResult();
        }
    }
}
