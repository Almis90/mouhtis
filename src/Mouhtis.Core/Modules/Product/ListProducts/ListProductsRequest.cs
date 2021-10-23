using FluentResults;
using MediatR;

namespace Mouhtis.Core.Modules.Product.ListProducts
{
    public class ListProductsRequest : IRequest<Result<ListProductsResponse>>
    {
    }
}
