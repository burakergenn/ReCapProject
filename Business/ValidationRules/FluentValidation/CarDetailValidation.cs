using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarDetailValidation : AbstractValidator<CarDetailDto>
    {
        public CarDetailValidation()
        {
            RuleFor(c => c.BrandName).NotNull();
            RuleFor(c => c.BrandName).MinimumLength(2);
            RuleFor(c => c.CarName).NotNull();
            RuleFor(c => c.CarName).MinimumLength(2);
            RuleFor(c => c.ColorName).NotNull();
            RuleFor(c => c.ColorName).MinimumLength(2);
            RuleFor(c => c.DailyPrice).NotNull();
            RuleFor(c => c.DailyPrice).GreaterThan(0);
        }
    }
}
