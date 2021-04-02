using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
	public class EfCarDal : EfEntityRepositoryBase<Car, ReCapProjectContext>, ICarDal
	{
		public List<CarDetailsDto> GetCarDetails(Expression<Func<Car, bool>> filter = null)
		{
			using (ReCapProjectContext context = new ReCapProjectContext())
			{
				var result = from c in filter == null ? context.Cars : context.Cars.Where(filter)
							 join b in context.Brands
								on c.BrandId equals b.Id
							 join clr in context.Colors
								on c.ColorId equals clr.Id
							 select new CarDetailsDto
							 {
								 Id = c.Id,
								 CarName = c.CarName,
								 BrandName = b.BrandName,
								 ColorName = clr.ColorName,
								 DailyPrice = c.DailyPrice,
								 ModelYear = c.ModelYear,
								 Description = c.Description,
								 ImagePath = (from a in context.CarImages where a.CarId == c.Id select a.ImagePath).FirstOrDefault()
							 };
				return result.ToList();
			}
		}

		public List<CarDetailsDto> GetCarDetailsById(int carId)
		{
			using (ReCapProjectContext context = new ReCapProjectContext())
			{
				var result = from c in context.Cars
							 join b in context.Brands
							 on c.BrandId equals b.Id
							 join cl in context.Colors
							 on c.ColorId equals cl.Id
							 where c.Id == carId
							 select new CarDetailsDto
							 {
								 Id = c.Id,
								 CarName=c.CarName,
								 BrandName = b.BrandName,
								 ModelYear = c.ModelYear,
								 ColorName = cl.ColorName,
								 DailyPrice = c.DailyPrice,
								 Description = c.Description,
								 ImagePath = (from a in context.CarImages where a.CarId == c.Id select a.ImagePath).FirstOrDefault()
							 };

				return result.ToList();
			}
		}
	}
}