using System;
using FluentValidation;

namespace Mouhtis.Core.Modules.Product.CreateProduct
{
    public class CreateProductRequestValidator : AbstractValidator<CreateProductRequest>
    {
        public CreateProductRequestValidator()
        {
        }
    }
}
