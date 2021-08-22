using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstrack
{
   public interface IOrderService
    {
        IDataResult<List<Order>> GetAll();
        IDataResult<Order> GetId(int id);
        IResult Add(Order order);
        IResult Delete(Order order);
        IResult Update(Order order);

    }
}
