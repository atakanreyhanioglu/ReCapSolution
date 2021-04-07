using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal
    {
        List<Car> GetAll();

        List<Car> GetByBrandId(string brandId);
        void Add(Car car);

        void Update(Car car);

        void Delete(Car car);
    }
}
