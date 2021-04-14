using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapSqlContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (ReCapSqlContext contex = new ReCapSqlContext())
            {
                var result = from c in contex.Cars
                             join co in contex.Colors on c.ColorId equals co.ColorId
                             join br in contex.Brands on c.BrandId equals br.BrandId

                             select new CarDetailDto
                             {
                                 CarId = c.Id,
                                 DailyPrice = c.DailyPrice,
                                 CarName = c.Description,
                                 ColorName = co.ColorName,
                                 BrandName = br.BrandName

                             };
                return result.ToList();


            }
            
        }
    }
}
