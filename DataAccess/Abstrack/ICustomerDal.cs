using Core.DataAccess;
using Core.DataAccess.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstrack
{
    public interface ICustomerDal : IEntityRepository<Customer>
    {

    }
}
