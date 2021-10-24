using Core.Entities.Concrete;
using Core.Utilities.Results;
using System.Collections.Generic;

namespace Business.Abstract
{
	public interface IUserService
	{
		//List<OperationClaim> GetClaims(User user);
		//User GetByMail(string email);

		IResult Add(User user);
		IDataResult<List<OperationClaim>> GetClaims(User user);
		IResult Delete(User user);
		IResult Update(User user);

		IDataResult<User> GetByUserId(int Id);
		IDataResult<List<User>> GetAll();
		IDataResult<User> GetByMail(string email);
		IDataResult<User> GetLastUser();

	}
}
