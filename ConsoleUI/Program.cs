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

            BrandManager brandManager = new BrandManager(new EfBrandDal());

            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }

            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.ColorName);
            }

            CarManager carManager = new CarManager(new EfCarDal());

            Console.WriteLine("All Cars......................\n");
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine("-> " + car.BrandName + "---" + car.CarName + "--Color-----> " + car.ColorName);
            }



        }


    }
}
