using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Elimizdeki tüm araçları listelemek için
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }



            Console.WriteLine("----InMemoryDal da Add/Delete/Update gibi işlemleri test edelim-----");
            //Yeni bir araç ekleyelim
            ICarDal inMemoryCarDal = new InMemoryCarDal();
            inMemoryCarDal.Add(new Car {Id=8,BrandId=2,ColorId=4,ModelYear=2021,DailyPrice=300,Description= "Volkswagen - Manuel-Benzin" });

            //Elimizdeki bir aracı güncelleyelim. Id si 2 olan aracı güncellemek istiyorum model bilgisini yanlış girmişim ve modelini 2021 yapıcam diyelim
            inMemoryCarDal.Update(new Car { Id = 2, BrandId = 1, ColorId = 3, ModelYear = 2021, DailyPrice = 300, Description = "BMW - Manuel-Dizel" });

            //Elimizdeki bir aracın kaza yaptığını ve hurdaya çıktığını veya sattığımızı varsayıp onu listeden çıkartalım
            inMemoryCarDal.Delete(new Car { Id = 7, BrandId = 4, ColorId = 1, ModelYear = 2017, DailyPrice = 200, Description = "Renault - Manuel-Dizel" });


            foreach (var car in inMemoryCarDal.GetAll())
            {
                Console.WriteLine(car.Description);
            }


            //Burada ID bilgisini verdiğimiz aracın bilgisini isteyelim
            foreach (var car in inMemoryCarDal.GetById(5))
            {
                Console.WriteLine(car.Description);
            }



        }
    }
}
