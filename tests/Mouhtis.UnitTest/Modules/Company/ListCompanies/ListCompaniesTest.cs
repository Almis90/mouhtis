using System;
using System.Collections.Generic;
using System.Threading;
using FluentAssertions;
using FluentValidation.Results;
using Moq;
using Mouhtis.Core.Modules.Company.ListCompanies;

namespace Mouhtis.UnitTest.Modules.Company.ListCompanies
{
    public class ListCompaniesTest
    {
        
        [Fact]
        public async void SignInValidationFailed()
        {
            #region GIVEN
            var validator = new Mock<ListCompaniesRequestValidator>();
            var validationFailures = new List<ValidationFailure> { new ValidationFailure("propertyName", "errorMessage") };

            validator.Setup(x => x.ValidateAsync(It.IsAny<ListCompaniesRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new ValidationResult(validationFailures));

            var request = new ListCompaniesRequest();
            var handler = new ListCompaniesHandler(validator.Object);
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
