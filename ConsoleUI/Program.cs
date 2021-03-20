    using Business.Concrete;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Data Transformation Object

            ProduckManager();

            //IoC - Öğreneceyiz 

            //CategoryManager();



        }

        private static void CategoryManager()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var item in categoryManager.GetAll().Data)  // IResult yapısını kurduk  category için .Data eklemelisin.
            {
                Console.WriteLine(" CategoryName : " + item.CategoryName);
            }
        }

        private static void ProduckManager()
        {
            ProductManager productManager = new ProductManager(new EfProduckDal() 
                ,new CategoryManager(new EfCategoryDal()));

            var result = productManager.GetProductDetails();

            if (result.Success)
            {
                foreach (var item in result.Data )
                {
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine(" Product Name  : " + item.ProductName);
                    Console.WriteLine(" Category Name : " + item.CategoryName);
                    Console.WriteLine(" Stok          : " + item.UnitsInStock);
                    Console.WriteLine("   ");

                }
               
            }
            else
            {
                Console.WriteLine(result.Message);
            }

        }
    }
}
