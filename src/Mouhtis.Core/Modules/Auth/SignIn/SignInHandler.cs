using System.Threading;
using System.Threading.Tasks;
using Almis.SharedKernel.MediatR;
using FluentResults;
using FluentValidation;

namespace Mouhtis.Core.Modules.Auth.SignIn
{
    public class SignInHandler : ValidatableRequestHandler<SignInRequest, SignInResponse>
    {
        public SignInHandler(IValidator<SignInRequest> validator) : base(validator)
        {
        }

        public override Task<Result<SignInResponse>> Handle(SignInRequest request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
