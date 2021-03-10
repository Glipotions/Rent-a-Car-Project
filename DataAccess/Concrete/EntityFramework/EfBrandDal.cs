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
	public class EfBrandDal : IBrandDal
	{
		public void Add(Brand entity)
		{
			using (NorthwindContext context=new NorthwindContext())
			{
				var addedEntity = context.Entry(entity);
				addedEntity.State = EntityState.Added;
				context.SaveChanges();
			}
		}

		public void Delete(Brand entity)
		{
			using (NorthwindContext context = new NorthwindContext())
			{
				var deleteEntity = context.Entry(entity);
				deleteEntity.State = EntityState.Deleted;
				context.SaveChanges();
			}
		}

		public Brand Get(Expression<Func<Brand, bool>> filter)
		{
			using (NorthwindContext context = new NorthwindContext())
			{
				return context.Set<Brand>().SingleOrDefault(filter);
			}
		}

		public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
		{
			using (NorthwindContext context = new NorthwindContext())
			{
				return filter == null
					? context.Set<Brand>().ToList()
					: context.Set<Brand>().Where(filter).ToList();
			}
		}

		public void Update(Brand entity)
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
