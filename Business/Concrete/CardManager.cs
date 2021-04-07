using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CardManager : ICardService
    {
        private ICardDal _cardDal;

        public CardManager(ICardDal creditCardDal)
        {
            _cardDal = creditCardDal;
        }

        [ValidationAspect(typeof(CardValidator))]
        public IResult Add(Card card)
        {

            _cardDal.Add(card);
            return new SuccessResult(Messages.CreditCardAdded);
        }

        public IResult Delete(Card card)
        {
            _cardDal.Delete(card);
            return new SuccessResult(Messages.CardDeleted);
        }

        public IResult Payment(Card card)
        {
            if (!card.CardNumber.StartsWith("0")) return new ErrorResult(Messages.PaymentError);
            return new SuccessResult(Messages.PaymentSuccess);
        }

        public IDataResult<Card> GetByUserId(int userId)
        {
            return new SuccessDataResult<Card>(_cardDal.Get(c => c.Id == userId));
        }

        public IDataResult<List<Card>> GetAll()
        {
            var getAll = _cardDal.GetAll();
            return new SuccessDataResult<List<Card>>(getAll);
        }
        public IDataResult<List<Card>> GetByCustomerId(int customerId)
        {
            var getByCustomerId = _cardDal.GetAll(card => card.CustomerId == customerId);
            return new SuccessDataResult<List<Card>>(getByCustomerId);
        }

        public IResult Update(Card card)
        {
            _cardDal.Update(card);
            return new SuccessResult(Messages.CardUpdated);
        }

        public bool CheckCardNumber(string cardNumber)
        {
            var getByCardNumber = _cardDal.Get(card => card.CardNumber == cardNumber);

            if (getByCardNumber != null)
                return true;

            return false;
        }
    }
}
