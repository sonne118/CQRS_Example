using System.Threading.Tasks;

namespace Framework
{
    interface ICommandHandler<TRequest>
    {
        Task HandleAsync(TRequest request);
    }
}
