using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Core.DataAccess.EntityFramework;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarRentDbContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetail()
        {
            using (CarRentDbContext context = new CarRentDbContext())
            {
                var result = from p in context.Cars
                             join b in context.Brands
                             on p.BrandId equals b.Id
                             join c in context.Colors
                             on p.ColorId equals c.Id
                             select new CarDetailDto { CarName = p.Model,BrandName=b.Name,ColorName=c.Name,DailyPrice=p.DailyPrice };
                return result.ToList();
            }

            
        }
    }
}
