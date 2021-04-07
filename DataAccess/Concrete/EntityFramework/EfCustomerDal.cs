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
							 select new CustomerDetailsDto {
								 Id = u.Id,
								 UserId = c.UserId,
								 FirstName=u.FirstName,
								 LastName=u.LastName,
								 CompanyName=c.CompanyName,
								 FindexPoint = (int)c.FindexPoint,
								 Email =u.Email };
				return result.ToList();
			}
		}
		public CustomerDetailsDto GetByEmail(Expression<Func<CustomerDetailsDto, bool>> filter)
		{
			using (var context = new ReCapProjectContext())
			{
				var result = from customer in context.Customers
							 join user in context.Users
							 on customer.UserId equals user.Id
							 select new CustomerDetailsDto
							 {
								 Id = customer.Id,
								 UserId = customer.UserId,
								 FirstName = user.FirstName,
								 LastName = user.LastName,
								 Email = user.Email,
								 CompanyName = customer.CompanyName,
								 FindexPoint = (int)customer.FindexPoint
							 };

				return result.SingleOrDefault(filter);
			}
		}
	}
}
