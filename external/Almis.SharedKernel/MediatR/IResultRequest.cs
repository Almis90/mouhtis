using FluentResults;
using MediatR;

namespace Almis.SharedKernel.MediatR
{
    public interface IResultRequest<TResponse> : IRequest<Result<TResponse>>
    {
    }
}
