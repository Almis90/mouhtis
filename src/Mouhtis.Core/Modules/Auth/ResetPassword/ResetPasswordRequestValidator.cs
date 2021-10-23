using FluentValidation;

namespace Mouhtis.Core.Modules.Auth.ResetPassword
{
    public class ResetPasswordRequestValidator : AbstractValidator<ResetPasswordRequest>
    {
        public ResetPasswordRequestValidator()
        {
        }
    }
}
