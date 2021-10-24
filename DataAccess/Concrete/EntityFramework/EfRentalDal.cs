using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
	public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCapProjectContext>, IRentalDal
	{
		public List<CarRentalDetailsDto> GetCarRentalDetails(Expression<Func<Rental, bool>> filter = null)
		{

			using (ReCapProjectContext context = new ReCapProjectContext())
			{

				var result = from rt in filter == null ? context.Rentals : context.Rentals.Where(filter)
							 join cr in context.Cars on rt.CarId equals cr.Id
							 join cst in context.Customers on rt.CustomerId equals cst.Id
							 join usr in context.Users on cst.UserId equals usr.Id
							 join brd in context.Brands on cr.BrandId equals brd.Id
							 join clr in context.Colors on cr.ColorId equals clr.Id
							 select new CarRentalDetailsDto
							 {
								 Id = rt.Id,
								 CompanyName = cst.CompanyName,
								 CarModelYear = cr.ModelYear,
								 CarDailyPrice = cr.DailyPrice,
								 CarDescription = cr.Description,
								 CarId = rt.CarId,
								 FirstName = usr.FirstName,
								 LastName = usr.LastName,
								 BrandName = brd.BrandName,
								 ColorName = clr.ColorName,
								 RentDate = rt.RentDate,
								 ReturnDate = rt.ReturnDate
							 };
				return result.ToList();
			}
		}
	}
}