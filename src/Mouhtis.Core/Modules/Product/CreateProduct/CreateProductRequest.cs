using FluentResults;
using MediatR;

namespace Mouhtis.Core.Modules.Product.CreateProduct
{
    public class CreateProductRequest : IRequest<Result<CreateProductResponse>>
    {
    }
}
