using FluentValidation;

namespace Mouhtis.Core.Modules.Auth.SignUp
{
    public class SignUpRequestValidator : AbstractValidator<SignUpRequest>
    {
        public SignUpRequestValidator()
        {
        }
    }
}
