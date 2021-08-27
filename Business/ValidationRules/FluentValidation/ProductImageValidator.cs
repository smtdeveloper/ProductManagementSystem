using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
   public class ProductImageValidator : AbstractValidator<ProductImage> 
    {
        public ProductImageValidator()
        {
          //  RuleFor(p => p.Id).NotEmpty();
           // RuleFor(p => p.ProductId).NotEmpty();
            // RuleFor(p => p.ImagePath).NotEmpty();

        }
    }
}
