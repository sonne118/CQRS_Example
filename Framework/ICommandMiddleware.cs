using System.Threading.Tasks;

namespace Framework
{
    interface ICommandMiddleware<TRequest>
    {
        Task HandleAsync(TRequest request, CommandHandlerDelegate next);
    }
}
