using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;
using Entities.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
             //CarManagerTest();
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            if(result.Success==true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarName);
                }
                
                
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            

        }






        private static void CarManagerTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

          var result = carManager.Add(new Car { Description = "y", ColorId = 1, BrandId = 2, DailyPrice = 500, ModelYear = "111" });

          /*  var result = carManager.GetCarDetails();
            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarName + "/" + car.BrandName);
                    

                }
                Console.WriteLine(result.Message);

            }
            else
            {
                Console.WriteLine(result.Message);
            }*/
        }
    }
}
