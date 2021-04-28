using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult <List<Car>> GetAll();
        IDataResult<CarDetailDto> GetById(int carId);      
        IDataResult<List<CarDetailDto>> GetCarsByBrandId(int brandId);
        IDataResult<List<CarDetailDto>> GetCarsByColorId(int colorId);
        IDataResult<List<CarDetailDto>> GetCarsByCarId(int carId);
        IDataResult<List<CarDetailDto>> GetCarByBrandAndColor(int brandId, int colorId);
        IResult Add(Car car);
        IResult Delete(Car car);
        IResult  Update(Car car);
        IDataResult<List<CarDetailDto>> GetCarDetails();
     
    }
}
