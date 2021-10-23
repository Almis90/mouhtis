using System;
using FluentValidation;

namespace Mouhtis.Core.Modules.Product.UpdateProduct
{
    public class UpdateProductRequestValidator : AbstractValidator<UpdateProductRequest>
    {
        public UpdateProductRequestValidator()
        {
        }
    }
}
