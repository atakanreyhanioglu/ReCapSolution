using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult <List<Car>> GetAll();
        IDataResult<Car> GetById(int carId);      
        IDataResult<List<Car>> GetCarsByBrandId(int brandId);
        IDataResult<List<Car>> GetCarsByColorId(int colorId);    
        IResult Add(Car car);
        IResult Delete(Car car);
        IResult  Update(Car car);

        
        IDataResult<List<CarDetailDto>> GetCarDetails();


    }
}
