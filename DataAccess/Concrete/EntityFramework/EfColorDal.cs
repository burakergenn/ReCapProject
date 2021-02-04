using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfColorDal : IColorDal
    {
        public void Add(Color entity)
        {
            using (CarRentDbContext context = new CarRentDbContext())
            {
                var addedColor = context.Entry(entity);
                addedColor.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Color entity)
        {
            using (CarRentDbContext context = new CarRentDbContext())
            {
                var deletedColor = context.Entry(entity);
                deletedColor.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }


        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            using (CarRentDbContext context = new CarRentDbContext())
            {
                return filter == null ? context.Set<Color>().ToList() : context.Set<Color>().Where(filter).ToList();
            }
        }

        public void Update(Color entity)
        {
            using (CarRentDbContext context = new CarRentDbContext())
            {
                var updatedColor = context.Entry(entity);
                updatedColor.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        Color IEntityRepository<Color>.Get(Expression<Func<Color, bool>> filter)
        {
            using (CarRentDbContext context = new CarRentDbContext())
            {
                return context.Set<Color>().SingleOrDefault(filter);
            }
        }
    }
}
