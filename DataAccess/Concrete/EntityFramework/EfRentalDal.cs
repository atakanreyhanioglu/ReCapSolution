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
    public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCapSqlContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails(Expression<Func<RentalDetailDto, bool>> filter = null)
        {
            using (ReCapSqlContext context = new ReCapSqlContext())
            {
                var result = from r in context.Rentals
                             join c in context.Cars on r.CarId equals c.Id
                             join cu in context.Customers on r.CustomerId equals cu.UserId
                             join u in context.Users on cu.UserId equals u.Id
                             join clr in context.Colors on c.ColorId equals clr.ColorId
                             join b in context.Brands on c.BrandId equals b.BrandId

 
                             select new RentalDetailDto
                             {
                                 Id = r.Id,
                                 CarId = r.CarId,
                                 CustomerId = r.CustomerId,
                                 UserId = u.Id,
                                 DailyPrice = c.DailyPrice,
                                 CarName = c.Description,  
                                 BrandName = b.BrandName,
                                 ColorName = clr.ColorName,
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate,
                                 CustomerName = u.FirstName,
                                 CustomerLastName = u.LastName,
                                 CustomerCompanyName = cu.CompanyName


                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();

            }
        }
    }
}
