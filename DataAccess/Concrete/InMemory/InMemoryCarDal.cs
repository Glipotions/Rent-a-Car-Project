using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
	public class InMemoryCarDal : ICarDal
	{
		List<Car> _cars;

		public InMemoryCarDal()
		{
			_cars = new List<Car>{
				new Car{Id=1,BrandId=1,ColorId=1,DailyPrice=128000,ModelYear=2010,Description="Sport Car" },
				new Car{Id=2,BrandId=2,ColorId=1,DailyPrice=13000,ModelYear=2012,Description="Sport Car" },
				new Car{Id=3,BrandId=3,ColorId=2,DailyPrice=95000,ModelYear=2015,Description="Van" },
				new Car{Id=4,BrandId=2,ColorId=2,DailyPrice=116000,ModelYear=2018,Description="Minibüs" },
				new Car{Id=5,BrandId=1,ColorId=2,DailyPrice=145000,ModelYear=2019,Description="Tır" }
			};
		}

		public void Add(Car car)
		{
			_cars.Add(car);
		}


		public void Delete(Car car)
		{
			Car carToDelete = _cars.SingleOrDefault(c=>c.Id==car.Id);
		}

		public List<Car> GetAll()
		{
			return _cars;
		}

		public List<Car> GetById(int id)
		{
			return _cars.Where(c => c.Id == id).ToList();
		}

		public void Update(Car car)
		{
			Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
			carToUpdate.ColorId = car.ColorId;
			carToUpdate.BrandId = car.BrandId;
			carToUpdate.DailyPrice = car.DailyPrice;
			carToUpdate.Description = car.Description;
			carToUpdate.ModelYear = car.ModelYear;
		}
	}
}
