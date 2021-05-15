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
                             join cus in context.Customers on r.CustomerId equals cus.Id
                             join u  in context.Users on r.UserId equals u.Id
                       

 
                             select new RentalDetailDto
                             {
                                 Id = r.Id,
                                 CarId = r.CarId,                            
                                 UserId = u.Id,
                                 CustomerId = cus.Id,
                                 CompanyName = cus.CompanyName,
                                 DailyPrice = c.DailyPrice,
                                 CarName = c.Description,                                
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate,
                                 CustomerName = u.FirstName,
                                 CustomerLastName = u.LastName,
                                 


                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();

            }
        }
    }
}
    