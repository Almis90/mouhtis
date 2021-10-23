using System;
using FluentValidation;

namespace Mouhtis.Core.Modules.Company.ListCompanies
{
    public class ListCompaniesRequestValidator : AbstractValidator<ListCompaniesRequest>
    {
        public ListCompaniesRequestValidator()
        {
        }
    }
}
