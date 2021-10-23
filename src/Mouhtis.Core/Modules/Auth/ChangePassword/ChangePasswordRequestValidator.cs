using FluentValidation;

namespace Mouhtis.Core.Modules.Auth.ChangePassword
{
    public class ChangePasswordRequestValidator : AbstractValidator<ChangePasswordRequest>
    {
        public ChangePasswordRequestValidator()
        {
        }
    }
}
