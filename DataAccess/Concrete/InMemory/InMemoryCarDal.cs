using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car> {
            new Car { Id=1, Description="Leon",ModelYear=2019,DailyPrice =150000, BrandId=1, ColorId=1 },
            new Car { Id=2, Description="Golf",ModelYear=2019,DailyPrice =180000, BrandId=2, ColorId=1 },
            new Car { Id=3, Description="Polo",ModelYear=2019,DailyPrice =120000, BrandId=2, ColorId=1 },
            new Car { Id=4, Description="Egea",ModelYear=2019,DailyPrice =100000, BrandId=3, ColorId=1 },
            new Car { Id=5, Description="Doblo",ModelYear=2019,DailyPrice =80000, BrandId=3, ColorId=1 }
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            var deletedCar = _cars.SingleOrDefault(x => x.Id == car.Id);
            _cars.Remove(deletedCar);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars.ToList();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car GetById(int carId)
        {
            return _cars.SingleOrDefault(x => x.Id == carId);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            var updatedCar = _cars.SingleOrDefault(x => x.Id == car.Id);
            updatedCar.Description = car.Description;
            updatedCar.ModelYear = car.ModelYear;
            updatedCar.DailyPrice = car.DailyPrice;
            updatedCar.BrandId = car.BrandId;
            updatedCar.ColorId = car.ColorId; 
        }
    }
}
