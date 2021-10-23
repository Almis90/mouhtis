using System.Collections.Generic;
using System.Threading;
using FluentAssertions;
using FluentValidation.Results;
using Moq;
using Mouhtis.Core.Modules.Auth.RefreshToken;
using Xunit;

namespace Mouhtis.UnitTest.Modules.Auth.RefreshToken
{
    public class RefreshTokenTest
    {
        [Fact]
        public async void SignInValidationFailed()
        {
            #region GIVEN
            var validator = new Mock<RefreshTokenRequestValidator>();
            var validationFailures = new List<ValidationFailure> { new ValidationFailure("propertyName", "errorMessage") };

            validator.Setup(x => x.ValidateAsync(It.IsAny<RefreshTokenRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new ValidationResult(validationFailures));

            var request = new RefreshTokenRequest();
            var handler = new RefreshTokenHandler(validator.Object);
            #endregion

            #region WHEN
            var response = await handler.Handle(request, CancellationToken.None);
            #endregion

            #region THEN
            response.Should().NotBeNull();
            response.Errors.Should().NotBeNullOrEmpty();
            response.Value.Should().BeNull();
            #endregion
        }
    }
}
