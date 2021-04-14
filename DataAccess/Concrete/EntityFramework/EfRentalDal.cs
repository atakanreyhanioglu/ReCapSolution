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
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (ReCapSqlContext context = new ReCapSqlContext())
            {
                var result = from r in context.Rentals
                             join c in context.Cars on r.CarId equals c.Id
                             join co in context.Colors on c.ColorId equals co.ColorId
                             join b in context.Brands on c.BrandId equals b.BrandId
                             join cu in context.Customers on r.CustomerId equals cu.UserId
                             join u in context.Users on r.CustomerId equals u.Id

                             select new RentalDetailDto
                             {
                                 Id = r.Id,
                                 DailyPrice = c.DailyPrice,
                                 CarName = c.Description,
                                 ColorName = co.ColorName,
                                 BrandName = b.BrandName,
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate,
                                 CustomerName = u.FirstName,
                                 CustomerLastName = u.LastName,
                                 CustomerCompanyName = cu.CompanyName


                             };
                return result.ToList();

            }
        }
    }
}
