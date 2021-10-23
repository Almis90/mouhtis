using System.Threading;
using System.Threading.Tasks;
using Almis.SharedKernel.MediatR;
using FluentResults;
using FluentValidation;
using MediatR;

namespace Mouhtis.Core.Modules.Company.ListCompanies
{
    public class ListCompaniesHandler : ValidatableRequestHandler<ListCompaniesRequest, Result<ListCompaniesResponse>>
    {
        public ListCompaniesHandler(IValidator<ListCompaniesRequest> validator) : base(validator)
        {
        }

        public override Task<Result<ListCompaniesResponse>> Handle(ListCompaniesRequest request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
