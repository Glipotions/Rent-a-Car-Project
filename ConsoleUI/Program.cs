using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
	class Program
	{
		static void Main(string[] args)
		{

			//foreach (var car in carManager.GetAll())
			//{
			//	Console.WriteLine(car.BrandId+" "+car.DailyPrice+" model: "+car.ModelYear);
			//}



			//BrandManager brandManager = new BrandManager(new EfBrandDal());
			//brandManager.Add(new Brand { BrandId = 1, BrandName = "Mercedes" });
			//brandManager.Add(new Brand { BrandId = 2, BrandName = "Bmw" });
			//brandManager.Add(new Brand { BrandId = 3, BrandName = "Volkswagen" });
			//brandManager.Add(new Brand { BrandId = 4, BrandName = "Ford" });
			//brandManager.Add(new Brand { BrandId = 5, BrandName = "Skoda" });

			//ColorManager colorManager = new ColorManager(new EfColorDal());
			//colorManager.Add(new Color { ColorId = 1, ColorName = "Siyah" });
			//colorManager.Add(new Color { ColorId = 2, ColorName = "Kırmızı" });
			//colorManager.Add(new Color { ColorId = 3, ColorName = "Gri" });
			//colorManager.Add(new Color { ColorId = 4, ColorName = "Beyaz" });


			CarManager carManager = new CarManager(new EfCarDal());
			//carManager.Add(new Car { Id = 1, BrandId = 1 ,ColorId=1,CarName="Benz",DailyPrice=220000,Description="Sport Car",ModelYear=2019});
			//carManager.Add(new Car { Id = 2, BrandId = 1, ColorId = 4, CarName = "4-matic", DailyPrice = 250000, Description = "Sport Car", ModelYear = 2020 });
			//carManager.Add(new Car { Id = 3, BrandId = 2, ColorId = 2, CarName = "M3", DailyPrice = 200000, Description = "Hatchback", ModelYear = 2015 });
			//carManager.Add(new Car { Id = 4, BrandId = 3, ColorId = 1, CarName = "Passat", DailyPrice = 130000, Description = "Sedan", ModelYear = 2016 });
			//carManager.Add(new Car { Id = 5, BrandId = 5, ColorId = 3, CarName = "Süper-B", DailyPrice = 120000, Description = "Hatchback", ModelYear = 2015 });

			carManager.Add(new Car { Id = 6, BrandId = 5, ColorId = 3, CarName = "B", DailyPrice = 120000, Description = "Hatchback", ModelYear = 2015 });

			carManager.Add(new Car { Id = 7, BrandId = 5, ColorId = 3, CarName = "3", Description = "Hatchback", ModelYear = 2015 });


		}
	}
}
