using System.Threading;
using System.Threading.Tasks;
using Almis.SharedKernel.MediatR;
using FluentResults;
using FluentValidation;
using MediatR;

namespace Mouhtis.Core.Modules.Company.CreateCompany
{
    public class CreateCompanyHandler : ValidatableRequestHandler<CreateCompanyRequest, Result<CreateCompanyResponse>>
    {
        public CreateCompanyHandler(IValidator<CreateCompanyRequest> validator) : base(validator)
        {
        }

        public override Task<Result<CreateCompanyResponse>> Handle(CreateCompanyRequest request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
