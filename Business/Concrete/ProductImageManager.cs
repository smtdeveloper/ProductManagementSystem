using Business.Abstrack;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Helpers;
using Core.Utilities.Results;
using DataAccess.Abstrack;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class ProductImageManager : IProductImageService
    {

        private IProductImageDal _productImageDal;

        public ProductImageManager(IProductImageDal productImageDal )
        {
            _productImageDal = productImageDal;
        }

       // [ValidationAspect(typeof(ProductImageValidator))]
        public IResult Add(IFormFile file, ProductImage productImage)
        {
           IResult result =  BusinessRules.Run(CheckIfProductImageLimit(productImage.Id));
            if (result != null)
            {
                return result;
            }
            productImage.ImagePath = FileHelper.Add(file);
            productImage.Date = DateTime.Now;
            _productImageDal.Add(productImage);
            return new SuccessResult(Messages.ProductImageAdded);
        }

        public IResult Delete(ProductImage productImage)
        {
           FileHelper.Delete(productImage.ImagePath);
            _productImageDal.Delete(productImage);
            return new SuccessResult(Messages.ProductImageDeleted);
        }

        public IDataResult<List<ProductImage>> GetAll()
        {

            return new SuccessDataResult<List<ProductImage>>(_productImageDal.GetAll(),Messages.ProductImageGetAll);
        }

        public IDataResult<ProductImage> GetById(int productImageId)
        {
            var result = _productImageDal.Get(p => p.Id == productImageId);

            IfCarImageOfProductNotExistsAddDefault(ref result);
            return new SuccessDataResult<ProductImage>();
        }

       // [ValidationAspect(typeof(ProductImageValidator))]
        public IResult Update(IFormFile file, ProductImage productImage)
        {
            productImage.ImagePath = FileHelper.Update(_productImageDal.Get(p => p.Id == productImage.Id).ImagePath, file);
            productImage.Date = DateTime.Now;
            _productImageDal.Update(productImage);

            return new SuccessResult(Messages.ProductImageUpdate);
        }

        public IDataResult<List<ProductImage>> GetImagesByProductId(int id)
        {
            var result = _productImageDal.GetAll(p => p.ProductId == id);

            IfCarImageOfProductNotExistsAddDefault(ref result);
            return new SuccessDataResult<List<ProductImage>>(result);
        }

        //------------------------------------------------------

        private IResult CheckIfProductImageLimit(int productId)
        {
           var result = _productImageDal.GetAll(p => p.ProductId == productId).Count();
            if (result > 5)
            {
                return new ErrorResult(Messages.ProductImageLimit);
            }

            return new SuccessResult();
        }


        //private IResult CheckIfCarImageNull(int id)
        //{
        //    string path = @"\images\default.jpg";
        //    var result = _productImageDal.GetAll(p => p.ProductId == id).Any();

        //    if (!result)
        //    {
        //        return new SuccessDataResult<List<ProductImage>>
        //        {
        //            new ProductImage
        //            {
        //                ProductId = id,
        //                ImagePath = path,
        //                Date = DateTime.Now
        //            }
        //        };
        //    }

        //    return new SuccessDataResult<List<ProductImage>>(_productImageDal.GetAll(p => p.ProductId == id));
        //}

        private ProductImage CreateDefaultProductImage()
        {
            var defaultCarImage = new ProductImage
            {
                ImagePath =
                    $@"{Environment.CurrentDirectory}\Public\Images\ProductImage\default.png",
                Date = DateTime.Now
            };

            return defaultCarImage;
        }

        

        private void IfCarImageOfProductNotExistsAddDefault(ref List<ProductImage> result)
        {
            if (!result.Any()) result.Add(CreateDefaultProductImage());
        }

        private void IfCarImageOfProductNotExistsAddDefault(ref ProductImage result)
        {
            if (result == null) result = CreateDefaultProductImage();
        }

       
    }
}
