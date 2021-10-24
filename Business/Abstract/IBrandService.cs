using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Abstract
{
	public interface IBrandService
	{
		//IDataResult<List<Brand>> GetAllByBrandId(int id);
		IDataResult<List<Brand>> GetAll(Expression<Func<Brand, bool>> filter = null);

		IDataResult<List<Brand>> GetById(int id);

		IResult Add(Brand brand);
		IResult Delete(Brand brand);
		IResult Update(Brand brand);

	}
}
