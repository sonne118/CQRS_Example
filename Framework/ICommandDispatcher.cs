using System.Threading.Tasks;

namespace Framework
{
    interface ICommandDispatcher
    {
        Task SendAsync<TCommand>(TCommand command) where TCommand : ICommand;
    }
}
