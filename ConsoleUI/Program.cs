using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new InMemoryProductDal());         
            foreach (var car in productManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
            Console.WriteLine(" ----------- Bütün Araçlar Listelendi ------------- ");
            foreach (var car in productManager.GetByBrandId("1"))
            {
                Console.WriteLine(car.Description);
            }
            Console.WriteLine(" ----------- Tek Marka Listelendi ------------- ");
            productManager.Add(new Car { Id = 7, BrandId = "1", Description = " BMW123123 " });
            Console.WriteLine(" ----------- BMW ARABA EKLENDİ ------------- ");

            foreach (var car in productManager.GetByBrandId("1"))
            {
                Console.WriteLine(car.Description);
            }
            Console.WriteLine(" ----------- Tek Marka Listelendi ------------- ");
            productManager.Delete(new Car { Id = 1 });
            Console.WriteLine(" ----------- BMW ARABA SİLİNDİ ------------- ");
            foreach (var car in productManager.GetByBrandId("1"))
            {
                Console.WriteLine(car.Description);
            }
            Console.WriteLine(" ----------- Tek Marka Listelendi ------------- ");
            productManager.Update(new Car { Id = 7, Description = " BMW 250i olarak değiştirildi " , BrandId = "1"});
            foreach (var car in productManager.GetByBrandId("1"))
            {
                Console.WriteLine(car.Description);
            }
            Console.WriteLine(" ----------- Tek Marka Listelendi ------------- ");



        }
    }
}
