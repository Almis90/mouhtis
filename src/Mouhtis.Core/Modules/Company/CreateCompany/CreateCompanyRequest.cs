using FluentResults;
using MediatR;

namespace Mouhtis.Core.Modules.Company.CreateCompany
{
    public class CreateCompanyRequest : IRequest<Result<CreateCompanyResponse>>
    {

    }
}
