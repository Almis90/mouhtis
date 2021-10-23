using FluentResults;
using MediatR;

namespace Mouhtis.Core.Modules.Company.UpdateCompany
{
    public class UpdateCompanyRequest : IRequest<Result<UpdateCompanyResponse>>
    {
    }
}
