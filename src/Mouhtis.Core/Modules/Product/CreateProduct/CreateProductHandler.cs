using System.Threading;
using System.Threading.Tasks;
using Almis.SharedKernel.MediatR;
using FluentResults;
using FluentValidation;
using MediatR;

namespace Mouhtis.Core.Modules.Product.CreateProduct
{
    public class CreateProductHandler : ValidatableRequestHandler<CreateProductRequest, Result<CreateProductResponse>>
    {
        public CreateProductHandler(IValidator<CreateProductRequest> validator) : base(validator)
        {
        }

        public override Task<Result<CreateProductResponse>> Handle(CreateProductRequest request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
