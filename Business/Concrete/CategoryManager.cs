using Business.Abstrack;
using Business.BussinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstrack;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using ValidationException = FluentValidation.ValidationException;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

       // [ValidationAspect(typeof(CategoryValidator))]
        public IResult Add(Category category)
        {
            IResult result = BusinessRules.Run(CheckIfCategoryNameExists(category.CategoryName));

            if (result != null)
            {
                return result;
            }

            _categoryDal.Add(category);
            return new SuccessResult(Messages.CategoryAdded);
        }

        public IResult Delete(Category category)
        {
            _categoryDal.Delete(category);
            return new SuccessResult(Messages.CategoryDelete);
        }

        public IDataResult<List<Category>> GetAll()
        {
             //  
            // iş kodları
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll());
        }


        // select * from Category where Category = 3
        public IDataResult<Category> GetById(int categoryId)
        {
            return new SuccessDataResult<Category>(_categoryDal.Get(c => c.CategoryId == categoryId));

        }


        // [ValidationAspect(typeof(CategoryValidator))]
        public IResult Update(Category category)
        {

            IResult result = BusinessRules.Run(CheckIfCategoryNameExists(category.CategoryName));

            if (result != null)
            {
                return result;
            }

            _categoryDal.Update(category);
            return new SuccessResult(Messages.CategoryUpdate   );
        }

        private IResult CheckIfCategoryNameExists(string categoryName)
        {
           var result = _categoryDal.GetAll(p => p.CategoryName == categoryName).Any();
            if (result == true)
            {
                return new ErrorResult(Messages.CategoryNameAlreadyExists);
            }

            return new SuccessResult();
        }

    }
}
