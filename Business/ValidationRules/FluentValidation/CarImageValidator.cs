﻿using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CarImageValidator : AbstractValidator<CarImage>
    {
        public CarImageValidator()
        {
            RuleFor(c => c.Id).NotNull();
            RuleFor(c => c.CarId).NotNull();
            RuleFor(c => c.DateCreated).NotNull();
            RuleFor(c => c.DateModified).NotNull();
            RuleFor(c => c.ImagePath).NotNull();
        }
    }
}