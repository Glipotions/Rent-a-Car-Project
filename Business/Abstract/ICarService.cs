using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
	public interface ICarService:IEntityService<Car>
	{
		List<Car> GetAllByBrandId(int id);
		List<Car> GetAllByColorId(int id);
		List<CarDetailsDto> GetCarDetails();


		//List<Car> GetAll();
		//List<Car> GetAllByBrandId(int id);
		//List<Car> GetAllByColorId(int id);

		//void Add(Car car);
		//void Delete(Car car);
		//void Update(Car car);

	}
}
