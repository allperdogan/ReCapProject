using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IDataResult<List<Rental>> GetAll();

        IResult AddRental(Rental rental);

        IResult DeleteRental(Rental rental);

        IResult UpdateRental(Rental rental);
    }
}
