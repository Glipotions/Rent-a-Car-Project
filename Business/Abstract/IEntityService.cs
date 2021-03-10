using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
	public interface IEntityService<T> where T : class, IEntity, new()
	{
		List<T> GetAll(Expression<Func<T, bool>> filter = null);
		List<T> GetAllByBrandId(int id);
		List<T> GetAllByColorId(int id);

		void Add(T entity);
		void Delete(T entity);
		void Update(T entity);

	}
}
