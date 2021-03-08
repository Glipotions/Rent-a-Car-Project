using Business.Concrete;
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
			CarManager carManager = new CarManager(new InMemoryCarDal());
			foreach (var car in carManager.GetAll())
			{
				Console.WriteLine(car.BrandId+" "+car.DailyPrice+" model: "+car.ModelYear);
			}


		}
	}
}
