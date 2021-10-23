using System.Threading;
using System.Threading.Tasks;
using Almis.SharedKernel.MediatR;
using FluentResults;
using FluentValidation;
using MediatR;

namespace Mouhtis.Core.Modules.Auth.RefreshToken
{
    public class RefreshTokenHandler : ValidatableRequestHandler<RefreshTokenRequest, RefreshTokenResponse>
    {
        public RefreshTokenHandler(IValidator<RefreshTokenRequest> validator) : base(validator)
        {
        }

        public override Task<Result<RefreshTokenResponse>> Handle(RefreshTokenRequest request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
