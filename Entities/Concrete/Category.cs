using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Category : IEntity
    {
        // Çıplak Class kalmasın
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        
        public string Description { get; set; }
        //public byte[] Picture { get; set; }

    }
}
