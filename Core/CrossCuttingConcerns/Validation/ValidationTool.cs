﻿using FluentValidation;

namespace Core.CrossCuttingConcerns.Validition
{
    public static class ValidationTool
    {
        public static void Validate(IValidator validator, object entity)
        {
            var context = new ValidationContext<object>(entity);
            var result = validator.Validate(context);
            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }
            //var context = new ValidationContext<Product>(product);
            //ProductValidator productValidator = new ProductValidator();
            //var result = productValidator.Validate(product);
            //if (!result.IsValid)
            //{
            //    throw new ValidationException(result.Errors);
            //}

        }
    }
}
