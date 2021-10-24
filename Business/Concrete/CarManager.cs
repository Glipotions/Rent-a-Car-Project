using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Concrete
{
	public class CarManager : ICarService
	{
		ICarDal _carDal;
		public CarManager(ICarDal carDal)
		{
			_carDal = carDal;
		}
		[ValidationAspect(typeof(CarValidator))]
		//[SecuredOperation("admin")]
		public IResult Add(Car car)
		{
			_carDal.Add(car);
			return new SuccessResult(Messages.Added);

		}
		[SecuredOperation("admin")]
		public IResult Delete(Car car)
		{

			_carDal.Delete(car);
			return new SuccessResult(Messages.Added);

		}
		//[CacheAspect]
		//public IDataResult<List<Car>> GetAll()
		//{
		//	//if (DateTime.Now.Hour == 03)
		//	//{
		//	//	return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
		//	//}
		//	return new SuccessDataResult<List<Car>>(_carDal.GetAll());
		//}

		//[CacheAspect]
		public IDataResult<List<Car>> GetAll(Expression<Func<Car, bool>> filter = null)
		{
			//if (DateTime.Now.Hour == 22)
			//{
			//	return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
			//}
			return new SuccessDataResult<List<Car>>(_carDal.GetAll());
		}

		public IDataResult<List<CarDetailsDto>> GetAllByBrandId(int id)
		{
			//if (DateTime.Now.Hour == 22)
			//{
			//	return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
			//}
			return new SuccessDataResult<List<CarDetailsDto>>(_carDal.GetCarDetails(c => c.BrandId == id));
		}
		//[CacheAspect]
		public IDataResult<List<CarDetailsDto>> GetAllByColorId(int id)
		{
			//if (DateTime.Now.Hour == 22)
			//{
			//	return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
			//}
			return new SuccessDataResult<List<CarDetailsDto>>(_carDal.GetCarDetails(c => c.ColorId == id));
		}
		//[CacheAspect]
		public IDataResult<List<Car>> GetById(int id)
		{
			//if (DateTime.Now.Hour == 22)
			//{
			//	return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
			//}
			return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.Id == id));
		}

		public IDataResult<List<CarDetailsDto>> GetCarDetails()
		{
			//if (DateTime.Now.Hour == 22)
			//{
			//	return new ErrorDataResult<List<CarDetailsDto>>(Messages.MaintenanceTime);
			//}
			return new SuccessDataResult<List<CarDetailsDto>>(_carDal.GetCarDetails(), Messages.CarDetails);
		}

		public IResult Update(Car car)
		{
			_carDal.Update(car);
			return new SuccessResult(Messages.Updated);

		}

		public IDataResult<List<CarDetailsDto>> GetCarDetailsById(int carId)
		{
			return new SuccessDataResult<List<CarDetailsDto>>(_carDal.GetCarDetailsById(carId));
		}

		public IDataResult<List<CarDetailsDto>> GetCarDetailsFilter(int brandId, int colorId)
		{
			return new SuccessDataResult<List<CarDetailsDto>>(
				_carDal.GetCarDetails(c => c.BrandId == brandId && c.ColorId == colorId));
		}


	}
}
