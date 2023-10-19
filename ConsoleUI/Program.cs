using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetCarDetail().Data)
            {
                Console.WriteLine(car.BrandName+" "+car.CarName+" "+car.ColorName+" "+car.DailyPrice);
            }
            //foreach (var car in carManager.GetCarsByBrandId(2))
            //{
            //    Console.WriteLine(car.CarName);
            //}

            //Car car1 = new Car() { BrandId=2, ColorId=3 , DailyPrice=1000 , ModelYear = 2020 , Description = "aaa", CarName = "alper" };

            //carManager.AddCar(car1);

            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.Id + " " + car.CarName + " " + car.DailyPrice + " " + car.Description);
            //}

            //carManager.DeleteCar(car1);
            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.CarName);
            //}
        }
    }
}