using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    class EmployeeValidator : AbstractValidator<Employee>
    {
        public EmployeeValidator()
        {
            RuleFor(p => p.FirstName).NotEmpty().WithMessage("Please specify a First Name");
            RuleFor(p => p.LastName).NotEmpty().WithMessage("Please specify a Last Name");
            RuleFor(p => p.FirstName).MinimumLength(2);
            RuleFor(p => p.LastName).MinimumLength(2);
            RuleFor(p => p.Address).NotEmpty();

        }
    }
}
