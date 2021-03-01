using DataAccess.Abstrack;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProduckDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProduckDal() // constacter
        {
            _products = new List<Product> 
            { 
                new Product{ProductId = 1 ,CategoryId = 1 , ProductName = "Bardak" , UnitPrice = 15 , UnitsInStock = 15},
                new Product{ProductId = 2 ,CategoryId = 1 , ProductName = "Kamere" , UnitPrice = 500 , UnitsInStock = 52},
                new Product{ProductId = 3 ,CategoryId = 2 , ProductName = "Telefon" , UnitPrice = 1500 , UnitsInStock = 2},
                new Product{ProductId = 4 ,CategoryId = 2 , ProductName = "Klavye" , UnitPrice = 150 , UnitsInStock = 65},
                new Product{ProductId = 5 ,CategoryId = 2 , ProductName = "Fare" , UnitPrice = 85 , UnitsInStock = 1}

            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Add(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product produck)
        {
            Product productToDelete = productToDelete = _products.SingleOrDefault(p => p.ProductId == produck.ProductId);

            _products.Remove(productToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();  // && ve 

        }

        public void Update(Product produck)
        {
            // göderdiğim ürün id'sine sahip olan ürünü bul 
            Product productToUpdate  = _products.SingleOrDefault(p => p.ProductId == produck.ProductId);

            productToUpdate.ProductName = produck.ProductName;
            productToUpdate.CategoryId = produck.CategoryId;
            productToUpdate.UnitPrice = produck.UnitPrice;
            productToUpdate.UnitsInStock = produck.UnitsInStock;

        }
    }
}
