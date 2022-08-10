using System.Threading.Tasks;

namespace Framework
{
    public interface IQueryMiddleware<TRequest, TResponse>
    {
        Task<TResponse> HandleAsync(TRequest request, QueryHandlerDelegate<TResponse> next);
    }
}
