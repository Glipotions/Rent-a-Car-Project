using Business.Abstract;
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

		public void Add(Car car)
		{
			if(car.CarName.Length>=2 && car.DailyPrice>=0)
			_carDal.Add(car);
			else
			{
				Console.WriteLine("Araba ismini veya Fiyatını yanlış girdiniz!!");
			}
		}

		public void Delete(Car car)
		{
			_carDal.Delete(car);
		}

		public List<Car> GetAll()
		{
			return _carDal.GetAll();
		}

		public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
		{
			return _carDal.GetAll();
		}

		public List<Car> GetAllByBrandId(int id)
		{
			return _carDal.GetAll(c =>c.BrandId==id);
		}

		public List<Car> GetAllByColorId(int id)
		{
			return _carDal.GetAll(c => c.ColorId == id);
		}

		public List<CarDetailsDto> GetCarDetails()
		{
			return _carDal.GetCarDetails();
		}

		public void Update(Car car)
		{
			_carDal.Update(car);
		}

	}
}
