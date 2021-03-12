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
	public class EfRentalDal : EfEntityRepositoryBase<Rental, NorthwindContext>, IRentalDal
	{
		public List<CarRentalDetailsDto> GetCarRentalDetails(Expression<Func<Rental, bool>> filter = null)
		{
			using (NorthwindContext context = new NorthwindContext())
			{
                var result = from rnt in filter is null ? context.Rentals : context.Rentals.Where(filter)
                             join cr in context.Cars on rnt.CarId equals cr.Id
                             join col in context.Colors on cr.ColorId equals col.ColorId
                             join brd in context.Brands on cr.BrandId equals brd.BrandId
                             join cus in context.Customers on rnt.CustomerId equals cus.CustomerId
                             join usr in context.Users on cus.UserId equals usr.UserId
                             select new CarRentalDetailsDto
                             {
                                 RentalId = rnt.Id,
                                 CustomerName = usr.FirstName,
                                 CustomerLastName = usr.LastName,
                                 CustomerCompanyName = cus.CompanyName,
                                 CarName = cr.Description,
                                 BrandName = brd.BrandName,
                                 ColorName = col.ColorName,
                                 DailyPrice = cr.DailyPrice,
                                 RentDate = rnt.RentDate,
                                 ReturnDate = rnt.ReturnDate
                             };

                return result.ToList();
            }
		}
	}
}
