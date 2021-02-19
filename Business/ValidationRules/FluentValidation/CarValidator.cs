using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.BrandId).NotNull();
            RuleFor(c => c.ColorId).NotNull();
            RuleFor(c => c.Model).NotNull();
            RuleFor(c => c.Model).MinimumLength(1);
            RuleFor(c => c.ModelYear).NotNull();
            RuleFor(c => c.DailyPrice).NotNull();
            RuleFor(c => c.DailyPrice).GreaterThan(0);
            RuleFor(c => c.Description).MinimumLength(1);
        }
    }
}
