using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Transaction;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
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

        [CacheRemoveAspect("ICarService.Get")]
        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car car)
        {
            
            _carDal.Add(car);
            return new SuccessResult(Messages.CarAdded);
        }
        [CacheRemoveAspect("ICarService.Get")]
        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult();
        }
        [CacheAspect]
        public IDataResult<List<Car>> GetAll()
        {
          
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.CarGetAll);
        }
        public IDataResult<List<Car>> GetCarsByBrandId(int brandId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.BrandId == brandId));
        }

        public IDataResult<List<Car>> GetCarsByColorId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ColorId == id));
        }

        [CacheRemoveAspect("ICarService.Get")]
        public IResult Update(Car car)
        {
             _carDal.Update(car);
            return new SuccessResult();
        }

        public IDataResult <List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(),Messages.CarGetAll);
        }

        public IDataResult<Car> GetById(int carId)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c=>c.Id == carId));
        }

        //[TransactionScopeAspect]

        //public IResult AddTransactionalTest(Car car)
        //{
        //    _carDal.Update(car);
        //    _carDal.Add(car);
        //    return new SuccessResult();

            
        //}


        public IDataResult<List<CarDetailDto>> GetCarDetailsByCarId(int carId)
        {
            throw new NotImplementedException();
        }

       
    }
}
