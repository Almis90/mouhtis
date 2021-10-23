using FluentResults;
using MediatR;

namespace Mouhtis.Core.Modules.Company.DeleteCompany
{
    public class DeleteCompanyRequest : IRequest<Result<DeleteCompanyResponse>>
    {
    }
}
