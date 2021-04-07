using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Car car)
        {
            _productDal.Add(car);
        }

        public void Delete(Car car)
        {
            _productDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _productDal.GetAll();
        }

        public List<Car> GetByBrandId(string brandId)
        {
            return _productDal.GetByBrandId(brandId);
        }

        public void Update(Car car)
        {
           _productDal.Update(car);
        }

        
    }
}
