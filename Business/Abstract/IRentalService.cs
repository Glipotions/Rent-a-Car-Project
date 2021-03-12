using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
	public interface IRentalService : IEntityService<Rental>
	{
		IDataResult<List<Rental>> GetAllByCustomerId(int id);

		IDataResult<List<Rental>> GetAllByCarId(int id);
	}
}
