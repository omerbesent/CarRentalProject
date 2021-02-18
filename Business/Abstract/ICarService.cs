using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dtos;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetCarsByBrand(int brandId);
        IDataResult<List<Car>> GetCarsByColor(int colorId);
        IDataResult<List<CarDetailDto>> GetCarDetails();
        IResult Add(Car car);
    }
}
