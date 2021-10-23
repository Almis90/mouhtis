using Almis.SharedKernel.MediatR;

namespace Mouhtis.Core.Modules.Auth.RefreshToken
{
    public class RefreshTokenRequest : IResultRequest<RefreshTokenResponse>
    {
        public string AccessToken { get; set; }
    }
}
