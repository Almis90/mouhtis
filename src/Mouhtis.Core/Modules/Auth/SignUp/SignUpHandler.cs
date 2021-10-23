using System.Threading;
using System.Threading.Tasks;
using Almis.SharedKernel.MediatR;
using FluentResults;
using FluentValidation;

namespace Mouhtis.Core.Modules.Auth.SignUp
{
    public class SignUpHandler : ValidatableRequestHandler<SignUpRequest, SignUpResponse>
    {
        public SignUpHandler(IValidator<SignUpRequest> validator) : base(validator)
        {
        }

        public override Task<Result<SignUpResponse>> Handle(SignUpRequest request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
