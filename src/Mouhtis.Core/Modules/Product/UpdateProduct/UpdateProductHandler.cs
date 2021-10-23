using System.Threading;
using System.Threading.Tasks;
using Almis.SharedKernel.MediatR;
using FluentResults;
using FluentValidation;
using MediatR;

namespace Mouhtis.Core.Modules.Product.UpdateProduct
{
    public class UpdateProductHandler : ValidatableRequestHandler<UpdateProductRequest, Result<UpdateProductResponse>>
    {
        public UpdateProductHandler(IValidator<UpdateProductRequest> validator) : base(validator)
        {
        }

        public override Task<Result<UpdateProductResponse>> Handle(UpdateProductRequest request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
