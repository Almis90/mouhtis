using System;
using System.Collections.Generic;
using System.Threading;
using FluentAssertions;
using FluentValidation;
using FluentValidation.Results;
using Moq;
using Mouhtis.Core.Modules.Company.CreateCompany;
using Mouhtis.Core.Modules.Product.CreateProduct;
using Xunit;

namespace Mouhtis.UnitTest.Modules.Product.CreateProduct
{
    public class CreateProductTest
    {
        [Fact]
        public async void CreateProductValidationFailed()
        {
            #region GIVEN
            var validator = new Mock<CreateProductRequestValidator>();
            var validationFailures = new List<ValidationFailure> { new ValidationFailure("propertyName", "errorMessage") };

            validator.Setup(x => x.ValidateAsync(It.IsAny<CreateProductRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new ValidationResult(validationFailures));

            var request = new CreateProductRequest();
            var handler = new CreateProductHandler(validator.Object);
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
