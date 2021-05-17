using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class PaymentManager : IPaymentService
    {
        IPaymentDal _paymentDal;
        public PaymentManager(IPaymentDal paymentDal)
        {
            _paymentDal = paymentDal;

        }

        public IResult Add(Payment payment)
        {

            _paymentDal.Add(payment);

            return new SuccessResult();
        }

        public IResult Delete(Payment payment)
        {
            _paymentDal.Delete(payment);
            return new SuccessResult();
        }

        public IDataResult<Payment> Get(Payment payment)
        {
            return new SuccessDataResult<Payment>(_paymentDal.Get(x => x.Id == payment.Id));
        }

        public IDataResult<List<Payment>> GetAll()
        {
            return new SuccessDataResult<List<Payment>>(_paymentDal.GetAll());
        }

        public IDataResult<Payment> GetByPaymentId(int paymentId)
        {
            var result = _paymentDal.Get(x => x.Id == paymentId);
            if (result == null)
            {
                return new ErrorDataResult<Payment>();
            }
            return new SuccessDataResult<Payment>(result);
        }

        public IDataResult<Payment> GetPaymentByUserId(int userId)
        {
            var result = _paymentDal.Get(p => p.UserId == userId);
            if (result == null)
            {
                return new ErrorDataResult<Payment>();
            }
            return new SuccessDataResult<Payment>(result);

        }

        public IResult Update(Payment payment)
        {
            _paymentDal.Update(payment);
            return new SuccessResult();
        }


    }
}
