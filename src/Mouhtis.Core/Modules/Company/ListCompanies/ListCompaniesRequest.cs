using FluentResults;
using MediatR;

namespace Mouhtis.Core.Modules.Company.ListCompanies
{
    public class ListCompaniesRequest : IRequest<Result<ListCompaniesResponse>>
    {
    }
}
