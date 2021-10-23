using System.Threading;
using System.Threading.Tasks;
using Almis.SharedKernel.MediatR;
using FluentResults;
using FluentValidation;
using MediatR;

namespace Mouhtis.Core.Modules.Company.DeleteCompany
{
    public class DeleteCompanyHandler : ValidatableRequestHandler<DeleteCompanyRequest, Result<DeleteCompanyResponse>>
    {
        public DeleteCompanyHandler(IValidator<DeleteCompanyRequest> validator) : base(validator)
        {
        }

        public override Task<Result<DeleteCompanyResponse>> Handle(DeleteCompanyRequest request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
