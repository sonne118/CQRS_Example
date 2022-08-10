using System.Threading.Tasks;

namespace Framework
{
    public interface IQueryHandler<TRequest, TResponse>
    {
        Task<TResponse> HandleAsync(TRequest request);
    }
}
