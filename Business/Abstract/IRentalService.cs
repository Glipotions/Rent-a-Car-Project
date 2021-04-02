using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
	public interface IRentalService 
	{
		IDataResult<List<Rental>> GetAll(Expression<Func<Rental, bool>> filter = null);

		IDataResult<List<Rental>> GetById(int id);

		IResult Add(Rental rental);
		IResult Delete(Rental rental);
		IResult Update(Rental rental);

		IDataResult<List<Rental>> GetAllByCustomerId(int id);

		IDataResult<List<Rental>> GetAllByCarId(int id);
		IDataResult<List<CarRentalDetailsDto>> GetCarRentalDetails();
		//Expression<Func<Rental, bool>> filter = null

	}
}
