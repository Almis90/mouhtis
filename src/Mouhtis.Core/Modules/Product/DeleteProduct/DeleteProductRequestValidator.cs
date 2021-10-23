using System;
using FluentValidation;

namespace Mouhtis.Core.Modules.Product.DeleteProduct
{
    public class DeleteProductRequestValidator : AbstractValidator<DeleteProductRequest>
    {
        public DeleteProductRequestValidator()
        {
        }
    }
}
