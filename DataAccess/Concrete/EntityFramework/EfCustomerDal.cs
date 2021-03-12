using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
	public class EfCustomerDal : EfEntityRepositoryBase<Customer, NorthwindContext>, ICustomerDal
	{
		public List<CustomerDetailsDto> GetCustomerDetails()
		{
			using (NorthwindContext context = new NorthwindContext())
			{
				var result = from c in context.Customers
							 join u in context.Users
							 on c.UserId equals u.UserId
							 select new CustomerDetailsDto { Id=u.UserId,FirstName=u.FirstName,LastName=u.LastName,CompanyName=c.CompanyName,Email=u.Email };
				return result.ToList();
			}
		}


	}
}
