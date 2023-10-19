using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>() { 
                new Car { Id = 1, BrandId = 1, ColorId=2, DailyPrice=980000, ModelYear=2023,Description="4x4" },
                new Car { Id = 2, BrandId = 2, ColorId=3, DailyPrice=940000, ModelYear=2021, Description="V8"},
                new Car { Id = 3, BrandId = 1, ColorId=2, DailyPrice=668000, ModelYear=2020, Description="1.6 TDI"},
                new Car { Id = 4, BrandId = 2, ColorId=1, DailyPrice=868000, ModelYear=2023, Description="1.5 TSI"}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car deletedCar = _cars.SingleOrDefault(c=>c.Id==car.Id); 
            _cars.Remove(deletedCar);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c=>c.Id == id).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car updatedCar = _cars.SingleOrDefault(c=>c.Id== car.Id);
            updatedCar.BrandId = car.BrandId;
            updatedCar.ColorId = car.ColorId;
            updatedCar.ModelYear = car.ModelYear;
            updatedCar.DailyPrice = car.DailyPrice;
            updatedCar.Description = car.Description;
        }
    }
}
