using System;
using System.Collections.Generic;
using System.Threading;
using FluentAssertions;
using FluentValidation.Results;
using Moq;
using Mouhtis.Core.Modules.Product.DeleteProduct;
using Xunit;

namespace Mouhtis.UnitTest.Modules.Product.DeleteProduct
{
    public class DeleteProductTest
    {
        [Fact]
        public async void DeleteProductValidationFailed()
        {
            #region GIVEN
            var validator = new Mock<DeleteProductRequestValidator>();
            var validationFailures = new List<ValidationFailure> { new ValidationFailure("propertyName", "errorMessage") };

            validator.Setup(x => x.ValidateAsync(It.IsAny<DeleteProductRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new ValidationResult(validationFailures));

            var request = new DeleteProductRequest();
            var handler = new DeleteProductHandler(validator.Object);
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
