using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
	public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCapProjectContext>, IRentalDal
	{
        //Expression<Func<Rental, bool>> filter = null
        //filter == null ? context.Rentals : context.Rentals.Where(filter)
        public List<CarRentalDetailsDto> GetCarRentalDetails(Expression<Func<Rental, bool>> filter = null)
		{
			using (ReCapProjectContext context = new ReCapProjectContext())
			{
                var result = from r in filter == null ? context.Rentals : context.Rentals.Where(filter)
                             join c in context.Cars
                             on r.CarId equals c.Id
                             join cu in context.Customers
                             on r.CustomerId equals cu.Id
                             join b in context.Brands
                             on c.BrandId equals b.Id
                             join u in context.Users
                             on cu.UserId equals u.Id
                             select new CarRentalDetailsDto
                             {
                                 RentalId = r.Id,
                                 CarName = b.BrandName,
                                 CustomerName = u.FirstName + " " + u.LastName,
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate,
                                 TotalPrice = Convert.ToDecimal(r.ReturnDate.Value.Day - r.RentDate.Day) * c.DailyPrice
                             };
                var x= result.ToList();
                return x;
            }
		}
	}
}
