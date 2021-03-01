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

            foreach (var item in productManager.GetAll())
            {
                Console.WriteLine(item.ProductName);
                    
            }

           
        }
    }
}
