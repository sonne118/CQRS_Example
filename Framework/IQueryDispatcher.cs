using System.Threading.Tasks;

namespace Framework
{
    public interface IQueryDispatcher
    {
        Task<TResponse> SendAsync<TResponse>(IQuery<TResponse> query);
    }
}
