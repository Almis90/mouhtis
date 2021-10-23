using System.Collections.Generic;
using System.Threading;
using FluentAssertions;
using FluentValidation.Results;
using Moq;
using Mouhtis.Core.Modules.Auth.SignIn;
using Xunit;

namespace Mouhtis.UnitTest.Modules.Auth.SignIn
{
    public class SignInTest
    {
        [Fact]
        public async void SignInValidationFailed()
        {
            #region GIVEN
            var validator = new Mock<SignInRequestValidator>();
            var validationFailures = new List<ValidationFailure> { new ValidationFailure("propertyName", "errorMessage") };

            validator.Setup(x => x.ValidateAsync(It.IsAny<SignInRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new ValidationResult(validationFailures));

            var request = new SignInRequest();
            var handler = new SignInHandler(validator.Object);
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

        [Fact]
        public async void SignInSuccess()
        {
            #region GIVEN
            var validator = new Mock<SignInRequestValidator>();
            var validationFailures = new List<ValidationFailure> { new ValidationFailure("propertyName", "errorMessage") };
            validator.Setup(x => x.ValidateAsync(It.IsAny<SignInRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new ValidationResult(validationFailures));
            var request = new SignInRequest { UsernameOrEmail = "Username", Password = "P@ssw0rd" };
            var handler = new SignInHandler(validator.Object);
            #endregion

            #region WHEN
            var response = await handler.Handle(request, CancellationToken.None);
            #endregion

            #region THEN
            response.Should().NotBeNull();
            response.Errors.Should().BeEmpty();
            response.Value.Should().NotBeNull();
            response.Value.AccessToken.Should().NotBeNullOrWhiteSpace();
            response.Value.RefreshToken.Should().NotBeNullOrWhiteSpace();
            #endregion
        }
    }
}
