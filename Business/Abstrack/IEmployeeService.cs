using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstrack
{
  public interface IEmployeeService 
    {
        IDataResult<List<Employee>> GetAll();
        IDataResult<Employee> GetById(int employeeId);

        Result Add(Employee employee);
        Result Delete(Employee employee);
        Result Update(Employee employee);
    }
}
