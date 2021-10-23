using System;
using System.Collections.Generic;
using System.Threading;
using FluentAssertions;
using FluentValidation.Results;
using Moq;
using Mouhtis.Core.Modules.Product.UpdateProduct;
using Xunit;

namespace Mouhtis.UnitTest.Modules.Product.UpdateProduct
{
    public class UpdateProductTest
    {
        [Fact]
        public async void UpdateCompanyValidationFailed()
        {
            #region GIVEN
            var validator = new Mock<UpdateProductRequestValidator>();
            var validationFailures = new List<ValidationFailure> { new ValidationFailure("propertyName", "errorMessage") };

            validator.Setup(x => x.ValidateAsync(It.IsAny<UpdateProductRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new ValidationResult(validationFailures));

            var request = new UpdateProductRequest();
            var handler = new UpdateProductHandler(validator.Object);
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
