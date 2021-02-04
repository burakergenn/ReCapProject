using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            ICarService carManager = new CarManager(new EfCarDal());
            IBrandService brandManager = new BrandManager(new EfBrandDal());
            IColorService colorManager = new ColorManager(new EfColorDal());

            foreach (var car in carManager.GetAll())
            {
                //burada aracın herhangi bir özelliğini yazdırabiliriz.
                Console.WriteLine(car.Model);
            }

            brandManager.Add(new Brand  {Name = "Sarı" });
            foreach (var color in brandManager.GetAll())
            {
                Console.WriteLine(color.Name);
            }


        }
    }
}
