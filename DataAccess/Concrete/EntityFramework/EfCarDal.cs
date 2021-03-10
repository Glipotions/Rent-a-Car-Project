using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
	public class EfCarDal : ICarDal
	{
		public void Add(Car entity)
		{
			using (NorthwindContext context=new NorthwindContext())
			{
				var addEntity = context.Entry(entity);
				addEntity.State = EntityState.Added;
				context.SaveChanges();
			}
		}

		public void Delete(Car entity)
		{
			using (NorthwindContext context = new NorthwindContext())
			{
				var deleteEntity = context.Entry(entity);
				deleteEntity.State = EntityState.Deleted;
				context.SaveChanges();
			}
		}

		public Car Get(Expression<Func<Car, bool>> filter = null)
		{
			using (NorthwindContext context=new NorthwindContext())
			{
				return context.Set<Car>().SingleOrDefault(filter);
			}
		}

		public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
		{
			using (NorthwindContext context = new NorthwindContext())
			{
				return filter == null
					? context.Set<Car>().ToList()
					: context.Set<Car>().Where(filter).ToList();
			}
		}

		public void Update(Car entity)
		{
			using (NorthwindContext context = new NorthwindContext())
			{
				var updateEntity = context.Entry(entity);
				updateEntity.State = EntityState.Modified;
				context.SaveChanges();
			}
		}
	}
}
