using Almis.SharedKernel.MediatR;

namespace Mouhtis.Core.Modules.Auth.SignIn
{
    public class SignInRequest : IResultRequest<SignInResponse>
    {
        public string UsernameOrEmail { get; set; }
        public string Password { get; set; }
    }
}
