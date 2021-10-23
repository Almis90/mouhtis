using System;
using System.Collections.Generic;
using System.Threading;
using FluentAssertions;
using FluentValidation.Results;
using Moq;
using Mouhtis.Core.Modules.Company.CreateCompany;
using Mouhtis.Core.Modules.Company.DeleteCompany;
using Xunit;

namespace Mouhtis.UnitTest.Modules.Company.DeleteCompany
{
    public class DeleteCompanyTest
    {
        [Fact]
        public async void SignInValidationFailed()
        {
            #region GIVEN
            var validator = new Mock<DeleteCompanyRequestValidator>();
            var validationFailures = new List<ValidationFailure> { new ValidationFailure("propertyName", "errorMessage") };

            validator.Setup(x => x.ValidateAsync(It.IsAny<DeleteCompanyRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new ValidationResult(validationFailures));

            var request = new DeleteCompanyRequest();
            var handler = new DeleteCompanyHandler(validator.Object);
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
