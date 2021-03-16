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
	public class EfCustomerDal : EfEntityRepositoryBase<Customer, ReCapProjectContext>, ICustomerDal
	{
		public List<CustomerDetailsDto> GetCustomerDetails()
		{
			using (ReCapProjectContext context = new ReCapProjectContext())
			{
				var result = from c in context.Customers
							 join u in context.Users
							 on c.UserId equals u.Id
							 select new CustomerDetailsDto { Id=u.Id, FirstName=u.FirstName,LastName=u.LastName,CompanyName=c.CompanyName,Email=u.Email };
				return result.ToList();
			}
		}


	}
}
