using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
	public class BrandManager : IBrandService
	{
		IBrandDal _brandDal;

		public BrandManager(IBrandDal brandDal)
		{
			_brandDal = brandDal;
		}
		public void Add(Brand entity)
		{
			_brandDal.Add(entity);
		}

		public void Delete(Brand entity)
		{
			_brandDal.Delete(entity);
		}

		public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
		{
			return _brandDal.GetAll();
		}

		public List<Brand> GetAllByBrandId(int id)
		{
			return _brandDal.GetAll(b => b.BrandId==id);
		}

		public List<Brand> GetAllByColorId(int id)
		{
			throw new NotImplementedException();
		}

		public void Update(Brand entity)
		{
			_brandDal.Update(entity);
		}
	}
}
