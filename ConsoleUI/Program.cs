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
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car { DailyPrice = 1, Description = "BMW Added from program.cs", ModelYear = "2010", BrandId = 1, ColorId = 1 });


            Console.WriteLine("All Cars......................\n");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
           
            Console.WriteLine("\nBMW Brand...................\n");

            foreach (var car in carManager.GetCarsByBrandId(1))
            {
                Console.WriteLine(car.BrandId + "-" + car.Description );
            }
            Console.WriteLine("\nWhite Color Cars.........................\n");

            foreach (var car in carManager.GetCarsByColorId(2))
            {
                Console.WriteLine(car.Description);
            }

           
            

        }
    }
}
