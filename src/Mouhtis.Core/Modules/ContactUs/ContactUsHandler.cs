using System.Threading;
using System.Threading.Tasks;
using Almis.SharedKernel.MediatR;
using FluentResults;
using FluentValidation;

namespace Mouhtis.Core.Modules.ContactUs
{
    public class ContactUsHandler : ValidatableRequestHandler<ContactUsRequest, ContactUsResponse>
    {
        public ContactUsHandler(IValidator<ContactUsRequest> validator) : base(validator)
        {
        }

        public override Task<Result<ContactUsResponse>> Handle(ContactUsRequest request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
