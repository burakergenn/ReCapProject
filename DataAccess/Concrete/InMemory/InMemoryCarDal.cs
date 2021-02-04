using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        List<Brand> _brands;
        List<Color> _colors;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=1,ColorId=1,ModelYear=2020,DailyPrice=350,Description="BMW - Otomatik-Dizel"},
                new Car{Id=2,BrandId=1,ColorId=3,ModelYear=2019,DailyPrice=300,Description="BMW - Manuel-Dizel"},
                new Car{Id=3,BrandId=2,ColorId=2,ModelYear=2021,DailyPrice=300,Description="Volkswagen - Manuel-Benzin"},
                new Car{Id=4,BrandId=2,ColorId=4,ModelYear=2018,DailyPrice=250,Description="Volkswagen - Otomatik-Dizel"},
                new Car{Id=5,BrandId=3,ColorId=2,ModelYear=2018,DailyPrice=500,Description="Land Rover - Otomatik-Benzin"},
                new Car{Id=6,BrandId=3,ColorId=3,ModelYear=2020,DailyPrice=700,Description="Land Rover - Otomatik-Benzin"},
                new Car{Id=7,BrandId=4,ColorId=1,ModelYear=2017,DailyPrice=200,Description="Renault - Manuel-Dizel"}
            };

            _brands = new List<Brand>
            {
                new Brand{Id=1,Name="BMW"},
                new Brand{Id=2,Name="Volkswagen"},
                new Brand{Id=3,Name="Land Rover"},
                new Brand{Id=4,Name="Renault"}
            };

            _colors = new List<Color>
            {
                new Color{Id=1,Name="Siyah"},
                new Color{Id=2,Name="Beyaz"},
                new Color{Id=3,Name="Gri"},
                new Color{Id=4,Name="Kırmızı"},
            };



        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(p => p.Id == Id).ToList();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
