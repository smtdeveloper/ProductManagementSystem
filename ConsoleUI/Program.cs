using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProduckDal());

            foreach (var item in productManager.GetByUnitInStock(50))
            {
                Console.WriteLine(" Ürün Id         : " + item.ProductId);
                Console.WriteLine(" Ürün CategoryId : " + item.CategoryId);
                Console.WriteLine(" Ürün İsimleri   : " + item.ProductName);
                Console.WriteLine(" Ürün Fiyatı     : " + item.UnitPrice);
                Console.WriteLine(" Ürün Stok adet  : " + item.UnitsInStock);
                
                Console.WriteLine("------------------------------------------------SMTcoder");

            }

           
        }
    }
}
