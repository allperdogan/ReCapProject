﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();

        IDataResult<List<Car>> GetCarsByBrandId(int brandId);

        IDataResult<List<Car>> GetCarsByColorId(int colorId);

        IResult AddCar(Car car);

        IResult DeleteCar(Car car);

        IResult UpdateCar(Car car);

        IDataResult<List<CarDetailDto>> GetCarDetail();

        IDataResult<Car> GetByCarId(int carId);
    }
}
