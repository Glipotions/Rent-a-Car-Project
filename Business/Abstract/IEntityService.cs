using Core.Entities;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
	public interface IEntityService<T> where T : class, IEntity, new()
	{
		IDataResult<List<T>> GetAll(Expression<Func<T, bool>> filter = null);
		IDataResult<List<T>> GetById(int id);

		IResult Add(T entity);
		IResult Delete(T entity);
		IResult Update(T entity);

	}
}
