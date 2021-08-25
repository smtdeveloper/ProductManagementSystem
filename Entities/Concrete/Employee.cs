using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
  public  class Employee : IEntity
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime HireDate { get; set; } // İşe Alma Tarihi
        public string Address { get; set; }
        public string HomePhone { get; set; }

        // public string Notes { get; set; }
        // public string PhotoPath { get; set; }
        // public string City { get; set; }
        // public DateTime BirthDate { get; set; }
    }
}
