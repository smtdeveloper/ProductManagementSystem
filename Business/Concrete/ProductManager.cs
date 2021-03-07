using Business.Abstrack;
using DataAccess.Abstrack;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productdal;

        public ProductManager(IProductDal productDal)
        {
            _productdal = productDal;

        }

        public void Add(Product product)
        {
            _productdal.Add(product);
        }

        public void Delete(Product product)
        {
           _productdal.Delete(product);
        }

        public List<Product> GetAll()
        {
                // iş kodları 
                // yetkisi var mı
 
                return _productdal.GetAll();
        }

        public List<Product> GetAllByCategoryId(int id)
        {
            return _productdal.GetAll(p => p.CategoryId == id);
        }

        public Product GetById(int productId)
        {
            return _productdal.Get(p => p.ProductId == productId);
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _productdal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max); 
        }

        public List<Product> GetByUnitsInStock(short stok)
        {
           return _productdal.GetAll(p => p.UnitsInStock >= stok );
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            return _productdal.GetProductDetails();
        }

        public void Update(Product product)
        {
            _productdal.Update(product);
        }
    }
}
