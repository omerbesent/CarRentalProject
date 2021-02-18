using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }
        public IResult Add(Rental car)
        {
            _rentalDal.Add(car);
            return new SuccessResult(Messages.CarRentalSuccess);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Rental>> GetByCarReturnDateIsNull(int carId)
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(x => x.CarId == carId && x.ReturnDate == null));
        }
    }
}
