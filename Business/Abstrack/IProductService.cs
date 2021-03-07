using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstrack
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetAllByCategoryId(int id);
        List<Product> GetByUnitPrice(decimal min, decimal max);
        List<Product> GetByUnitsInStock(short stok);

        List<ProductDetailDto> GetProductDetails();

        Product GetById(int productId);
        void Add(Product product);

       



    }
}
