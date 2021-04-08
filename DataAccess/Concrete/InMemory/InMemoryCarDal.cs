using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;


namespace DataAccess.Concrete.InMemory
{
   public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car {Id = 1 , BrandId = 1, ColorId = 547, DailyPrice = 125500 , Description = "BMW 320d" , ModelYear = "2018"},
                new Car {Id = 2 , BrandId = 1, ColorId = 527, DailyPrice = 95500 , Description = "BMW 300" , ModelYear = "2018"},
                new Car {Id = 3 , BrandId = 2, ColorId = 347,DailyPrice = 75000 , Description = "VW Golf" , ModelYear = "2016"},
                new Car {Id = 4 , BrandId = 2, ColorId = 421,DailyPrice = 175000 , Description = "VW Passat" , ModelYear = "2020"},
                new Car {Id = 5 , BrandId = 3, ColorId = 446,DailyPrice = 155000 , Description = "Honda Civic" , ModelYear = "2021"},
                new Car {Id = 6 , BrandId = 3, ColorId = 234,DailyPrice = 135000 , Description = "Honda Civic" , ModelYear = "2020"},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetByBrandId(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
