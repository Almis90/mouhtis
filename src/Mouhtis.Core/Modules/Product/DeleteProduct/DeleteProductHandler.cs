using System.Threading;
using System.Threading.Tasks;
using Almis.SharedKernel.MediatR;
using FluentResults;
using FluentValidation;
using MediatR;

namespace Mouhtis.Core.Modules.Product.DeleteProduct
{
    public class DeleteProductHandler : ValidatableRequestHandler<DeleteProductRequest, Result<DeleteProductResponse>>
    {
        public DeleteProductHandler(IValidator<DeleteProductRequest> validator) : base(validator)
        {
        }

        public override Task<Result<DeleteProductResponse>> Handle(DeleteProductRequest request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
