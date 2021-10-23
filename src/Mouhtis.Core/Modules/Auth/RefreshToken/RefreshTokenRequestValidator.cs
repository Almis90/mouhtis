using FluentValidation;

namespace Mouhtis.Core.Modules.Auth.RefreshToken
{
    public class RefreshTokenRequestValidator : AbstractValidator<RefreshTokenRequest>
    {
        public RefreshTokenRequestValidator()
        {
            RuleFor(x => x.AccessToken).NotEmpty();
        }
    }
}
