using Business.Abstract;
using Business.Constant;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
	public class CarManager : ICarService
	{
		ICarDal _carDal;
		public CarManager(ICarDal carDal)
		{
			_carDal = carDal;
		}

		public IResult Add(Car car)
		{
			if(car.CarName.Length<2 || car.DailyPrice <= 0)
			{
				return new ErrorResult(Messages.CarNamedInvalid);
			}
			_carDal.Add(car);
			return new SuccessResult(Messages.Added);

		}

		public IResult Delete(Car car)
		{

			_carDal.Delete(car);
			return new SuccessResult(Messages.Added);
			
		}

		public IDataResult<List<Car>> GetAll()
		{
			if (DateTime.Now.Hour == 22)
			{
				return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
			}
			return new SuccessDataResult<List<Car>>(_carDal.GetAll());
		}

		public IDataResult<List<Car>> GetAll(Expression<Func<Car, bool>> filter = null)
		{
			//if (DateTime.Now.Hour == 22)
			//{
			//	return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
			//}
			return new SuccessDataResult<List<Car>>(_carDal.GetAll());
		}

		public IDataResult<List<Car>> GetAllByBrandId(int id)
		{
			//if (DateTime.Now.Hour == 22)
			//{
			//	return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
			//}
			return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.BrandId == id));
		}

		public IDataResult<List<Car>> GetAllByColorId(int id)
		{
			//if (DateTime.Now.Hour == 22)
			//{
			//	return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
			//}
			return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ColorId == id));
			
		}

		public IDataResult<List<Car>> GetById(int id)
		{
			//if (DateTime.Now.Hour == 22)
			//{
			//	return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
			//}
			return new SuccessDataResult<List<Car>>(_carDal.GetAll(c=>c.Id==id));
		}

		public IDataResult<List<CarDetailsDto>> GetCarDetails()
		{
			//if (DateTime.Now.Hour == 22)
			//{
			//	return new ErrorDataResult<List<CarDetailsDto>>(Messages.MaintenanceTime);
			//}
			return new SuccessDataResult<List<CarDetailsDto>>(_carDal.GetCarDetails());
		}

		public IResult Update(Car car)
		{
			_carDal.Update(car);
			return new SuccessResult(Messages.Updated);
			
		}

	}
}
