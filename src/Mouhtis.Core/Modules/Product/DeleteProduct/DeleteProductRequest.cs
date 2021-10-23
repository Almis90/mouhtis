using FluentResults;
using MediatR;

namespace Mouhtis.Core.Modules.Product.DeleteProduct
{
    public class DeleteProductRequest : IRequest<Result<DeleteProductResponse>>
    {
    }
}
