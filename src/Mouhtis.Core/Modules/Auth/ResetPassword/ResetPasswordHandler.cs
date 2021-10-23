using System.Threading;
using System.Threading.Tasks;
using Almis.SharedKernel.MediatR;
using FluentResults;
using FluentValidation;

namespace Mouhtis.Core.Modules.Auth.ResetPassword
{
    public class ResetPasswordHandler : ValidatableRequestHandler<ResetPasswordRequest, ResetPasswordResponse>
    {
        public ResetPasswordHandler(IValidator<ResetPasswordRequest> validator) : base(validator)
        {
        }

        public override Task<Result<ResetPasswordResponse>> Handle(ResetPasswordRequest request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
