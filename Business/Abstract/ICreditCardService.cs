using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICreditCardService
    {
        IResult Add(CreditCard card);
        IResult Payment(CreditCard card);
        IDataResult<CreditCard> GetByUserId(int id);
        IDataResult<List<CreditCard>> GetAll(int userId);
    }
}
