using System.Threading;
using System.Threading.Tasks;
using Almis.SharedKernel.MediatR;
using FluentResults;
using FluentValidation;
using MediatR;

namespace Mouhtis.Core.Modules.Product.ListProducts
{
    public class ListProductsHandler : ValidatableRequestHandler<ListProductsRequest, Result<ListProductsResponse>>
    {
        public ListProductsHandler(IValidator<ListProductsRequest> validator) : base(validator)
        {
        }

        public override Task<Result<ListProductsResponse>> Handle(ListProductsRequest request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
