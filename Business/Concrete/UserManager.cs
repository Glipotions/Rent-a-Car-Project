using Business.Abstract;
using Business.Constant;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
	public class UserManager : IUserService
	{
		IUserDal _userDal;

		public UserManager(IUserDal userDal)
		{
			_userDal = userDal;
		}

		public IResult Add(User entity)
		{
			if (entity.FirstName.Length < 3)
			{
				return new ErrorResult(Messages.UserNamedInvalid);
			}

			_userDal.Add(entity);

			return new SuccessResult(Messages.UserAdded);
		}

		public IResult Delete(User entity)
		{
			_userDal.Delete(entity);

			return new SuccessResult(Messages.UserDeleted);
		}

		public IDataResult<List<User>> GetAll(Expression<Func<User, bool>> filter = null)
		{
			return new SuccessDataResult<List<User>>(_userDal.GetAll());
		}

		public IDataResult<List<User>> GetById(int id)
		{
			return new SuccessDataResult<List<User>>(_userDal.GetAll(u=>u.UserId==id));
		}

		public IResult Update(User entity)
		{
			_userDal.Update(entity);

			return new SuccessResult(Messages.UserUpdate);
		}
	}
}
