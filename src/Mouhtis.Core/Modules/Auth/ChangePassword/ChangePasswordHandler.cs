using System.Threading;
using System.Threading.Tasks;
using Almis.SharedKernel.MediatR;
using FluentResults;
using FluentValidation;

namespace Mouhtis.Core.Modules.Auth.ChangePassword
{
    public class ChangePasswordHandler : ValidatableRequestHandler<ChangePasswordRequest, ChangePasswordResponse>
    {

        public ChangePasswordHandler(IValidator<ChangePasswordRequest> validator) : base(validator)
        {
        }

        public override Task<Result<ChangePasswordResponse>> Handle(ChangePasswordRequest request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
