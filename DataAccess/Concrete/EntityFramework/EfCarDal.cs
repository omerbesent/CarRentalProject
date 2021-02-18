using System.Collections.Generic;
using System.Linq;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarRentalContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands on c.BrandId equals b.BrandId
                             join col in context.Colors on c.ColorId equals col.ColorId
                             select new CarDetailDto { Id = c.Id, CarName = c.Description, BrandName = b.Brandname, ColorName = col.ColorName, DailyPrice = c.DailyPrice };

                return result.ToList();
            }
        }
    }
}
