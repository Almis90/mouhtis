using FluentResults;
using MediatR;

namespace Mouhtis.Core.Modules.Product.UpdateProduct
{
    public class UpdateProductRequest : IRequest<Result<UpdateProductResponse>>
    {
    }
}
