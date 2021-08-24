using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {

            // ctrl + K + D  CODE DÜZENLER :) 

            RuleFor(p => p.ProductName).NotEmpty();
            RuleFor(p => p.ProductName).NotEmpty().WithMessage("Please specify a Product Name");
            RuleFor(p => p.ProductName).MinimumLength(2);
            RuleFor(p => p.UnitPrice).NotEmpty();
            RuleFor(p => p.UnitPrice).GreaterThan(0);
            RuleFor(P => P.UnitPrice).GreaterThan(10).When(p => p.CategoryId == 1);
            RuleFor(p => p.ProductName).Must(StartWithA).WithMessage(" Ürünler A harfi ile başlamalı");
          




        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
