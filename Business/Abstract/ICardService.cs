using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
	public interface ICardService
	{
		IResult Add(Card card);
		IResult Update(Card card);
		IResult Delete(Card card);

		IDataResult<List<Card>> GetByCustomerId(int id);
		IResult Payment(Card card);
		IDataResult<Card> GetByUserId(int id);
		IDataResult<List<Card>> GetAll();
	}
}
