using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Abstract
{
	public interface ICarService
	{
		IDataResult<List<Car>> GetAll(Expression<Func<Car, bool>> filter = null);
		IDataResult<List<Car>> GetById(int id);
		IResult Add(Car entity);
		IResult Delete(Car entity);
		IResult Update(Car entity);

		IDataResult<List<CarDetailsDto>> GetAllByBrandId(int id);
		IDataResult<List<CarDetailsDto>> GetAllByColorId(int id);
		IDataResult<List<CarDetailsDto>> GetCarDetails();
		IDataResult<List<CarDetailsDto>> GetCarDetailsById(int carId);
		IDataResult<List<CarDetailsDto>> GetCarDetailsFilter(int brandId, int colorId);

	}
}
