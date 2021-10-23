using System;
using FluentValidation;

namespace Mouhtis.Core.Modules.Company.UpdateCompany
{
    public class UpdateCompanyRequestValidator : AbstractValidator<UpdateCompanyRequest>
    {
        public UpdateCompanyRequestValidator()
        {
        }
    }
}
