using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Abstract
{
	public interface ICustomerService
	{
		IDataResult<List<Customer>> GetAll(Expression<Func<Customer, bool>> filter = null);

		//IDataResult<List<Customer>> GetById(int id);
		IDataResult<CustomerDetailsDto> GetByEmail(string email);
		IDataResult<Customer> GetById(int id);
		IResult Add(Customer entity);
		IResult Delete(Customer entity);
		IResult Update(Customer entity);
		IDataResult<List<Customer>> GetAll();
		IDataResult<List<Customer>> GetAllByUserId(int id);
		IDataResult<List<CustomerDetailsDto>> GetCustomerDetails();
	}
}
