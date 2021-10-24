using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccess.Abstract
{
	public interface ICustomerDal : IEntityRepository<Customer>
	{
		CustomerDetailsDto GetByEmail(Expression<Func<CustomerDetailsDto, bool>> filter);
		List<CustomerDetailsDto> GetCustomerDetails();
	}
}
