using System.Threading;
using System.Threading.Tasks;
using Almis.SharedKernel.MediatR;
using FluentResults;
using FluentValidation;
using MediatR;

namespace Mouhtis.Core.Modules.Company.UpdateCompany
{
    public class UpdateCompanyHandler : ValidatableRequestHandler<UpdateCompanyRequest, Result<UpdateCompanyResponse>>
    {
        public UpdateCompanyHandler(IValidator<UpdateCompanyRequest> validator) : base(validator)
        {
        }

        public override Task<Result<UpdateCompanyResponse>> Handle(UpdateCompanyRequest request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
