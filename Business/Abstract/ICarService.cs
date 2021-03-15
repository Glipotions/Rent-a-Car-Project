using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
	public interface ICarService:IEntityService<Car>
	{
		IDataResult<List<Car>> GetAllByBrandId(int id);
		IDataResult<List<Car>> GetAllByColorId(int id);
		IDataResult<List<CarDetailsDto>> GetCarDetails();
	}
}
