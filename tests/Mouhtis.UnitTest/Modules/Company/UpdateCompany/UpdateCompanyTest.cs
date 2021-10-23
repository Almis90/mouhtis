﻿using System;
using System.Collections.Generic;
using System.Threading;
using FluentAssertions;
using FluentValidation.Results;
using Moq;
using Mouhtis.Core.Modules.Company.UpdateCompany;
using Xunit;

namespace Mouhtis.UnitTest.Modules.Company.UpdateCompany
{
    public class UpdateCompanyTest
    {
        [Fact]
        public async void UpdateCompanyValidationFailed()
        {
            #region GIVEN
            var validator = new Mock<UpdateCompanyRequestValidator>();
            var validationFailures = new List<ValidationFailure> { new ValidationFailure("propertyName", "errorMessage") };

            validator.Setup(x => x.ValidateAsync(It.IsAny<UpdateCompanyRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new ValidationResult(validationFailures));

            var request = new UpdateCompanyRequest();
            var handler = new UpdateCompanyHandler(validator.Object);
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
