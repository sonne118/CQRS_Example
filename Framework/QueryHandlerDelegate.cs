using System.Threading.Tasks;

namespace Framework
{
    public delegate Task<TResponse> QueryHandlerDelegate<TResponse>();

}
