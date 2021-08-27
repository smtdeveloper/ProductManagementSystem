using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstrack
{
   public interface IProductImageService
    {
        IDataResult<List<ProductImage>> GetAll();
        IDataResult<ProductImage> GetById(int productImageId);
        IDataResult<List<ProductImage>> GetImagesByProductId(int id);

        IResult Add(IFormFile file, ProductImage productImage);
        IResult Update(IFormFile file, ProductImage productImage);
        IResult Delete(ProductImage productImage);
    }
}
