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
                new Product{ProduckId = 1 ,CategoryId = 1 , ProductName = "Bardak" , UnitPrice = 15 , UnitsInStok = 15},
                new Product{ProduckId = 2 ,CategoryId = 1 , ProductName = "Kamere" , UnitPrice = 500 , UnitsInStok = 52},
                new Product{ProduckId = 3 ,CategoryId = 2 , ProductName = "Telefon" , UnitPrice = 1500 , UnitsInStok = 2},
                new Product{ProduckId = 4 ,CategoryId = 2 , ProductName = "Klavye" , UnitPrice = 150 , UnitsInStok = 65},
                new Product{ProduckId = 5 ,CategoryId = 2 , ProductName = "Fare" , UnitPrice = 85 , UnitsInStok = 1}

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
            Product productToDelete = productToDelete = _products.SingleOrDefault(p => p.ProduckId == produck.ProduckId);

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
            Product productToUpdate  = _products.SingleOrDefault(p => p.ProduckId == produck.ProduckId);

            productToUpdate.ProductName = produck.ProductName;
            productToUpdate.CategoryId = produck.CategoryId;
            productToUpdate.UnitPrice = produck.UnitPrice;
            productToUpdate.UnitsInStok = produck.UnitsInStok;

        }
    }
}
