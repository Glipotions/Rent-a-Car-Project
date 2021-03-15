using Business.Abstract;
using Business.Constant;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
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
	public class CustomerManager : ICustomerService
	{
		ICustomerDal _customerDal;

		public CustomerManager(ICustomerDal customerDal)
		{
			_customerDal = customerDal;
		}

		[ValidationAspect(typeof(CustomerValidator))]
		public IResult Add(Customer entity)
		{
			_customerDal.Add(entity);
			return new SuccessResult(Messages.CustomerAdded);
		}

		public IResult Delete(Customer entity)
		{
			_customerDal.Delete(entity);
			return new SuccessResult(Messages.CustomerDeleted);
		}

		public IDataResult<List<Customer>> GetAll(Expression<Func<Customer, bool>> filter = null)
		{
			return new SuccessDataResult<List<Customer>>(_customerDal.GetAll());
		}

		public IDataResult<List<Customer>> GetAllByUserId(int id)
		{
			return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(c => c.UserId == id));
		}

		public IDataResult<List<Customer>> GetById(int id)
		{
			return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(c=>c.CustomerId==id));
		}

		public IDataResult<List<CustomerDetailsDto>> GetCustomerDetails()
		{
			return new SuccessDataResult<List<CustomerDetailsDto>>(_customerDal.GetCustomerDetails());
		}

		public IResult Update(Customer entity)
		{
			_customerDal.Update(entity);
			return new SuccessResult(Messages.CustomerUpdated);
		}
	}
}
