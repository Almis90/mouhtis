using System.Threading;
using System.Threading.Tasks;
using FluentResults;
using FluentValidation;
using FluentValidation.Results;
using MediatR;

namespace Almis.SharedKernel.MediatR
{
    public abstract class ValidatableRequestHandler<TRequest, TResponse>
        : IRequestHandler<TRequest, Result<TResponse>>
        where TRequest : IResultRequest<TResponse>
    {
        protected IValidator<TRequest> _validator;

        protected ValidatableRequestHandler(IValidator<TRequest> validator)
        {
            _validator = validator;
        }

        public Task<ValidationResult> IsValid(TRequest request)
        {
            return _validator.ValidateAsync(request);
        }

        public abstract Task<Result<TResponse>> Handle(TRequest request, CancellationToken cancellationToken);
    }
}
