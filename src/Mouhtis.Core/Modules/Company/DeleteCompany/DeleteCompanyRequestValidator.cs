using System;
using FluentValidation;

namespace Mouhtis.Core.Modules.Company.DeleteCompany
{
    public class DeleteCompanyRequestValidator : AbstractValidator<DeleteCompanyRequest>
    {
        public DeleteCompanyRequestValidator()
        {
        }
    }
}
