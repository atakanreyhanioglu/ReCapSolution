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
       

        public List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            using (ReCapSqlContext contex = new ReCapSqlContext())
            {
                var result = from c in contex.Cars
                             join b in contex.Brands on c.BrandId equals b.BrandId
                             join clr in contex.Colors on c.ColorId equals clr.ColorId

                             select new CarDetailDto
                             {
                                 CarId = c.Id,
                                 BrandId = c.BrandId,
                                 ColorId = c.ColorId,
                                 CarName = c.Description,
                                 BrandName = b.BrandName,
                                 ColorName = clr.ColorName,
                                 ModelYear = c.ModelYear,
                                 DailyPrice = c.DailyPrice,
                                 CarImage = (from i in contex.CarImages
                                             where (c.Id == i.CarId)
                                             select new CarImage { CarImageId = i.CarImageId, CarId = c.Id, Date = i.Date, ImagePath = i.ImagePath }).ToList()
                             };



                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }

        }
        


    }
}
