﻿using Core.DataAccess.EntityFramework;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCapContext>, IRentalDal
    {

        //public List<CarDetailDto> GetCarDetails()
        //{
        //    using (ReCapContext context = new ReCapContext())
        //    {
        //        var result = from c in context.Cars
        //                     join br in context.Brands
        //                     on c.BrandId equals br.BrandId
        //                     join cl in context.Colors
        //                     on c.ColorId equals cl.ColorId
        //                     select new CarDetailDto { CarId = c.Id, CarName = c.CarName, BrandName = br.BrandName, ColorName = cl.ColorName, DailyPrice = c.DailyPrice };
        //        return result.ToList();
        //    };
        //}

    }
}
